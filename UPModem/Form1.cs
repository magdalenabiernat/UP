using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace UPModem
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        string receivedData;
        delegate void SetTextCallback(string text);

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
                serialPort.RtsEnable = true;
                serialPort.DtrEnable = true;
                serialPort.Handshake = Handshake.None;
                serialPort.WriteTimeout = 500;
                serialPort.ReadTimeout = 500;
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
                serialPort.Open();
                textBoxCommunicationWindow.Text += "COM1: Connection open!" + System.Environment.NewLine;
            }catch(Exception exception)
            {
                textBoxCommunicationWindow.Text += "Connection error!" + exception.Message + System.Environment.NewLine;
            }
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            receivedData= serialPort.ReadExisting();
            if (receivedData != null)
            {
                BeginInvoke(new SetTextCallback((string text) => { textBoxCommunicationWindow.Text += text; }), new object[] { receivedData });
            }
        }


        private void buttonDisconnect_Click(object sender, EventArgs e)
        {   if (serialPort.IsOpen)
            {
                serialPort.Close();
                textBoxCommunicationWindow.Text += "Connection port's been closed" + System.Environment.NewLine;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
           
            if(serialPort.IsOpen)
            {
                try
                {
                    
                    serialPort.Write(textBoxMessage.Text + System.Environment.NewLine);
                    textBoxCommunicationWindow.Text +=  textBoxMessage.Text + System.Environment.NewLine;
                }
                catch (Exception exception)
                {
                    textBoxCommunicationWindow.Text += "WR Error! : " + exception.Message + System.Environment.NewLine;
                }
            }
            else
            {
                textBoxCommunicationWindow.Text += "Connection is closed" + System.Environment.NewLine;
            }

        
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
