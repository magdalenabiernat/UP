using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace GPS_BB
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SerialPort port = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
        private string data = "";

        private void button1_Click(object sender, EventArgs e)
        {
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedEventHandler);
            port.Open();
            if (port.IsOpen)
                MessageBox.Show("Port otwarty");

            else
                MessageBox.Show("Błąd otwierania portu");
        }

        public void DataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if (InvokeRequired)
                Invoke(DataReceivedEventHandler(sender,e), sender, e);
            else
            {
                var senderPort = (SerialPort)sender;
                data += senderPort.ReadExisting();
                textBox1.Text = data;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            port.Close();
            var ns = 0.0;
            var we = 0.0;
            string[] tempStr = null;
            bool gpsSignal = false;
            foreach (var line in textBox1.Lines)
            {
                if (line.Contains("GPGGA"))
                {
                    tempStr = line.Split(',');
                    if (tempStr[2] != "")
                    {
                        gpsSignal = true;
                        ns = Convert.ToDouble(tempStr[2]) / 100;
                        we = Convert.ToDouble(tempStr[4]) / 100;

                    }

                }

            }
            if (!gpsSignal)
            {
                MessageBox.Show("Błąd");
            }
            else
            {
                if (tempStr[3] == "S")
                    ns *= -1;
                if (tempStr[5] == "W")
                    we *= -1;
                var link = $"https://www.google.pl/maps/@{ns},{we},14z";
                webBrowser1.Navigate(link);
                textBox1.Text = link;
            }
        }

    }
}
