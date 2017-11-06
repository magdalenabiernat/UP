using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using Accord.Video.FFMPEG;
namespace USBCamera
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection usbCamera;
        private VideoCaptureDevice camera;
        private VideoFileWriter writer;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {   
            //Dodanie wszystkich dostępnych kamer do menu
            usbCamera = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in usbCamera)
            {
                comboBoxSelectCamera.Items.Add(VideoCaptureDevice.Name);
            }
            comboBoxSelectCamera.SelectedIndex = 0;
            camera = new VideoCaptureDevice();
        }

        private void buttonTurnOn_Click(object sender, EventArgs e)
        {
                if (camera.IsRunning == true)
                    camera.Stop();

                camera = new VideoCaptureDevice(usbCamera[comboBoxSelectCamera.SelectedIndex].MonikerString);
                //dodanie metody obsługującej przechwyt klatki
                camera.NewFrame += new NewFrameEventHandler(cam_NewFrame);
                camera.Start();

            //rozpoczęcie nagrywania
              writer = new VideoFileWriter();
            writer.Open(@"C:\Users\m-mic\Documents\video.avi",1280, 720, 30, VideoCodec.MPEG4);
            //Bitmap image = new Bitmap(1280, 720, PixelFormat.Format24bppRgb);
            //// write 1000 video frames
            //for (int i = 0; i < 1000; i++)
            //{
            //    image.SetPixel(i % 1280, i % 720, Color.Red);
            //    writer.WriteVideoFrame(image);
            //}
        }


        private void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {   
            Bitmap htmlBitmap = (Bitmap)eventArgs.Frame.Clone();
            Bitmap pictureBoxBitmap = (Bitmap)eventArgs.Frame.Clone();
            Bitmap movieFileBitmap = (Bitmap)eventArgs.Frame.Clone();

            //konfiguracja kodeka dla klatki używanej w podglądzie poprzez przeglądarkę WWW
            System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
            ImageCodecInfo encoderInfo = ImageCodecInfo.GetImageEncoders().First(i => i.MimeType == "image/jpeg");
            EncoderParameters encoderParams = new EncoderParameters(1);
            EncoderParameter parameter = new EncoderParameter(myEncoder, 25L);
            encoderParams.Param[0] = parameter;

            //ustawienie klatki w pictureBoxie
            pictureBox1.Image = pictureBoxBitmap;

            try
            {
                htmlBitmap.Save(@"C:\Users\m-mic\Pictures\frame.jpg", encoderInfo, encoderParams);
                for (int i = 0; i < 1000; i++)
            {
                movieFileBitmap.SetPixel(i % 1280, i % 720, Color.Red);
                writer.WriteVideoFrame(movieFileBitmap);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex);
            }
        }

        private void buttonTurnOff_Click(object sender, EventArgs e)
        {
            if (camera.IsRunning)
            {
                camera.Stop();
                writer.Close();
            }
        }

        private void buttonTakePicture_Click(object sender, EventArgs e)
        {
            if (camera.IsRunning && textBoxFileName.Text!="")
            {
                string path = @"C:\Users\m-mic\Pictures\" + textBoxFileName.Text + ".jpg" ;
                pictureBox1.Image.Save(path, ImageFormat.Jpeg);
            }       
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (camera.IsRunning)
            {
                camera.Stop();
                writer.Close();
            }
        }

        private void buttonOpenBrowser_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\m-mic\Pictures\camera.html");
        }
    }
}
