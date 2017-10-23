using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace UrzadzeniaPeryferyjnemodem
{
    public partial class Form1 : Form
    {
        SerialPort serialport;
        string receivedData;
        delegate void A();
        A  delegat;
        int speed=9600;
       

        public Form1()
        {
            InitializeComponent();
        }

        
        private void WpiszOdebrane()
        {
            textBox1.Text+=serialport.ReadByte().ToString("X") + " ";
        }
        private void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            textBox1.Invoke(delegat);
        }
        private void buttonSend_Click(object sender, EventArgs e) 
        {
            if(serialport.IsOpen)
            {
                try
                {
                    serialport.Write(comboBox2.Text + System.Environment.NewLine);
                    textBox1.Text += comboBox2.Text + System.Environment.NewLine;
                }catch(Exception ex)
                {
                    textBox1.Text += " Error!"+ex.Message + System.Environment.NewLine;
                }
                serialport.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);
                delegat = new A(WpiszOdebrane);
            }
        }

       
        private void buttonConnect_Click(object sender, EventArgs e)
        {


            try
            {

                if (serialport.IsOpen==false)
                {
                    serialport.PortName = comboBoxPorts.SelectedItem.ToString();
                    serialport.Open();
                    textBox1.Text += " Connection open!" + System.Environment.NewLine;
                }
            }

            /*
    try
    {
        serialport = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);//TODO: nazwa portu,szybkosc transmisji, bit parzystoci,bity danych, bit zatrzymania
        serialport.Open();
        textBox1.Text += " Connection open!" + System.Environment.NewLine;

    }
    */
            catch (Exception exception)
            {
                textBox1.Text += "Error !" + exception.Message + System.Environment.NewLine;
            }

            
            
        }

       /* private void dataRecived(object sender, SerialDataReceivedEventArgs e)
        {
            receivedData = serialport.ReadExisting();
            if(receivedData != null)
            {
                BeginInvoke(new A((string text)=> { textBox1.Text += text; }), new object[] { receivedData }); 
            }
        }*/
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (serialport.IsOpen)
            {
                serialport.Close();
                textBox1.Text += "Connection close !" + System.Environment.NewLine;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            speed = Int32.Parse(comboBox1.SelectedItem.ToString());
            serialport = new SerialPort(" ", speed, Parity.None, 8, StopBits.One);//TODO: nazwa portu,szybkosc transmisji, bit parzystoci,bity danych, bit zatrzymania

            String[] ports = SerialPort.GetPortNames();
            foreach (String x in ports)
                comboBoxPorts.Items.Add(x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialport.Write("ATD "+textBox2.Text + System.Environment.NewLine);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialport.Write("ATA" + System.Environment.NewLine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                serialport.Write("+" + System.Environment.NewLine);
                System.Threading.Thread.Sleep(500);
            }
            System.Threading.Thread.Sleep(1000);
        }
    }
}
