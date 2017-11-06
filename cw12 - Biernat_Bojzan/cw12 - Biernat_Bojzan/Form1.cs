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
using Accord.Video.FFMPEG;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;

namespace cw12___Biernat_Bojzan
{
    //aberacja sferyczna
    //synchrnizacja klatek
    public partial class obsługaKameryUSB : Form
    {
        private FilterInfoCollection usbCamera;
        private FilterInfoCollection usbCamera2;
        private VideoCaptureDevice camera1;
        private VideoCaptureDevice camera2;
        private VideoFileWriter writer1;
        private VideoFileWriter writer2;

        public obsługaKameryUSB()
        {
            InitializeComponent();
        }

          private void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap pictureBoxBitmap = (Bitmap)eventArgs.Frame.Clone();
            Bitmap movieFileBitmap = (Bitmap)eventArgs.Frame.Clone();
            obrazekLewy.Image = pictureBoxBitmap;

         //   throw new NotImplementedException();
        }
        private void cam_NewFrame2(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap pictureBoxBitmap2 = (Bitmap)eventArgs.Frame.Clone();
            Bitmap movieFileBitmap = (Bitmap)eventArgs.Frame.Clone();
            obrazekPrawy.Image = pictureBoxBitmap2;

            //   throw new NotImplementedException();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            usbCamera = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            usbCamera2 = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in usbCamera)
            {
                listaKamerGórna.Items.Add(VideoCaptureDevice.Name);
            }
            foreach (FilterInfo VideoCaptureDevice in usbCamera2)
            {
                listaKamerDolna.Items.Add(VideoCaptureDevice.Name);
            }
            listaKamerGórna.SelectedIndex = 1;
            listaKamerDolna.SelectedIndex = 2;
            camera1 = new VideoCaptureDevice();
            camera2 = new VideoCaptureDevice();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(camera1.IsRunning&&camera2.IsRunning&nazwaDoZapisuZdjecia.Text!="")
            {
                if (camera1.IsRunning)
                {
                    string sciezka = @"C:\Users\lab\Videos\" + nazwaDoZapisuZdjecia.Text + ".jpg";
                    obrazekLewy.Image.Save(sciezka, ImageFormat.Jpeg);
                }
                if (camera2.IsRunning)
                {
                    string sciezka = @"C:\Users\lab\Videos\" + nazwaDoZapisuZdjecia.Text + "1.jpg";
                    obrazekPrawy.Image.Save(sciezka, ImageFormat.Jpeg);
                }
            }

        }

        private void włączGórne_Click(object sender, EventArgs e)
        {
            if (camera2.IsRunning)
                camera2.Stop();
            camera2 = new VideoCaptureDevice(usbCamera2[listaKamerDolna.SelectedIndex].MonikerString);
            camera2.NewFrame += new NewFrameEventHandler(cam_NewFrame2);
            camera2.Start();
            writer2 = new VideoFileWriter();
            writer2.Open(@"C:\Users\magda\Desktop\Madzia\PWr\UP\cw12\film1.avi", 1280, 720, 30, VideoCodec.MPEG4);
        }

        private void wyłączGórne_Click(object sender, EventArgs e)
        {
            if (camera2.IsRunning)
            {
                camera2.Stop();
                writer2.Close();
                obrazekPrawy.Image = null;
            }
        }

        private void włączDolne_Click(object sender, EventArgs e)
        {
            if (camera1.IsRunning)
                camera1.Stop();
            camera1 = new VideoCaptureDevice(usbCamera[listaKamerGórna.SelectedIndex].MonikerString);
            camera1.NewFrame += new NewFrameEventHandler(cam_NewFrame);
            camera1.Start();
            writer1 = new VideoFileWriter();
            writer1.Open(@"C:\Users\magda\Desktop\Madzia\PWr\UP\cw12\film.avi", 1280, 720, 30, VideoCodec.MPEG4);
        }

        private void wyłączDolne_Click(object sender, EventArgs e)
        {
            if (camera1.IsRunning)
            {
                camera1.Stop();
                writer1.Close();
                obrazekLewy.Image = null;
            }
        }
    }
}
