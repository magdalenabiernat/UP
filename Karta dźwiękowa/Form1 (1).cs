using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Karta_dzwiekowa
{
    public partial class Form1 : Form
    {
        private string filePath = "";
        private SoundPlayer soundPlayer;
        private bool wasPlayed;

        NAudio.Wave.WaveIn sourceStream = null;
        NAudio.Wave.DirectSoundOut waveOut = null;
        NAudio.Wave.WaveFileWriter waveWriter = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Audio files (.wav)|*.wav";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fileDialog.FileName;
                labelFilePath.Text = $"Wybrany plik: {filePath}";
                FillListBox();
            }
        }

        private void FillListBox()
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

                BinaryReader reader = new BinaryReader(fileStream);

                byte[] wave = reader.ReadBytes(24);

                fileStream.Position = 0;

                int chunkID = reader.ReadInt32();
                int fileSize = reader.ReadInt32();
                int riffType = reader.ReadInt32();

                var fileFormat = Encoding.Default.GetString(wave);
                string format = fileFormat.Substring(8, 4);
                 

                int fmtID = reader.ReadInt32();
                int fmtSize = reader.ReadInt32();
                int fmtCode = reader.ReadInt16();
                int channels = reader.ReadInt16();
                int sampleRate = reader.ReadInt32();
                int byteRate = reader.ReadInt32();
                int fmtBlockAlign = reader.ReadInt16();
                int bitDepth = reader.ReadInt16();

                reader.Close();

                string chunkIDStr = $"Chunk ID: {chunkID}";
                string fileSizeStr = $"File size: {fileSize}";
                string riffTypeStr = $"Riff type: {riffType}";
                string fileFormatStr = $"File format: {format}";
                string fmtIDStr = $"Fmt ID: {fmtID}";
                string fmtSizeStr = $"Fmt size: {fmtSize}";
                string fmtCodeStr = $"File code: {fmtCode}";
                string channelsStr = $"Channels: {channels}";
                string sampleRateStr = $"Sample rate: {sampleRate}";
                string byteRateStr = $"Byte rate: {byteRate}";
                string fmtBlockAlignStr = $"Fmt block align: {fmtBlockAlign}";
                string bitDepthStr = $"Bit depth: {bitDepth}";

                listBoxFileInfo.Items.Clear();
                listBoxFileInfo.Items.AddRange(new string[]
                {
                    chunkIDStr, fileSizeStr, riffTypeStr, fileFormatStr, fmtIDStr, fmtSizeStr, fmtCodeStr,
                    channelsStr, sampleRateStr, byteRateStr, fmtBlockAlignStr, bitDepthStr
                });
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (filePath == String.Empty)
                MessageBox.Show("Wybierz plik!");
            else
            {
                soundPlayer = new SoundPlayer(filePath);
                if (!wasPlayed)
                {
                    buttonPlay.Text = "Zatrzymaj";
                    wasPlayed = !wasPlayed;
                    soundPlayer.Play();
                }
                else
                {
                    buttonPlay.Text = "Odwtórz";
                    wasPlayed = !wasPlayed;
                    soundPlayer.Stop();
                }
            }
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            if (listBoxDevices.SelectedItems.Count == 0) return;

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Wave File (*.wav)|*.wav;";
            if (save.ShowDialog() != DialogResult.OK) return;

            int deviceNumber = listBoxDevices.SelectedIndex;

            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = deviceNumber;
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);

            sourceStream.DataAvailable += new EventHandler<NAudio.Wave.WaveInEventArgs>(sourceStream_DataAvailable);
            waveWriter = new NAudio.Wave.WaveFileWriter(save.FileName, sourceStream.WaveFormat);

            sourceStream.StartRecording();
            labelRecording.Text = "Nagrywanie...";
        }

        private void sourceStream_DataAvailable(object sender, NAudio.Wave.WaveInEventArgs e)
        {
            if (waveWriter == null) return;

            waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
            waveWriter.Flush();
        }


        private void buttonFindDevice_Click(object sender, EventArgs e)
        {
            List<NAudio.Wave.WaveInCapabilities> sources = new List<NAudio.Wave.WaveInCapabilities>();

            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
                sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));

            listBoxDevices.Items.Clear();

            foreach (var source in sources)
            {
                string item = source.ProductName;
                listBoxDevices.Items.Add(item);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
            if (sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.Dispose();
                sourceStream = null;
            }
            if (waveWriter != null)
            {
                waveWriter.Dispose();
                waveWriter = null;
            }

            labelRecording.Text = "";
        }
    }
}
