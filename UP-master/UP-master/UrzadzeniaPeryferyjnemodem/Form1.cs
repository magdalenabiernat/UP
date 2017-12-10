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
    public partial class FormUP_Modem : Form
    {
        SerialPort serialport;
        delegate void A();
        A  delegat;
        int speed=9600;
       

        public FormUP_Modem()
        {
            InitializeComponent();
        }

        
        private void WpiszOdebrane()
        {
            textBoxInformation.Text+=serialport.ReadByte().ToString("X") + " ";
        }
        private void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            textBoxInformation.Invoke(delegat);
        }
        private void buttonSend_Click(object sender, EventArgs e) 
        {
            if(serialport.IsOpen)
            {
                try
                {
                    serialport.Write(comboBoxMessage.Text + System.Environment.NewLine);
                    textBoxInformation.Text += comboBoxMessage.Text + System.Environment.NewLine;
                }catch(Exception ex)
                {
                    textBoxInformation.Text += " Error!"+ex.Message + System.Environment.NewLine;
                }
                serialport.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);
                delegat = new A(WpiszOdebrane);
            }
        }

       
        private void buttonOpen_Click(object sender, EventArgs e)
        {
                       try
            {

                if (serialport.IsOpen == false)
                {
                    serialport.PortName = comboBoxPorts.SelectedItem.ToString();
                    serialport.Open();
                    textBoxInformation.Text += " Connection open!" + System.Environment.NewLine;
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
                textBoxInformation.Text += "Error !" + exception.Message + System.Environment.NewLine;
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
        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (serialport.IsOpen)
            {
                serialport.Close();
                textBoxInformation.Text += "Connection close !" + System.Environment.NewLine;
            }
        }

    

        private void buttonStart_Click(object sender, EventArgs e)
        {
            speed = Int32.Parse(comboBoxSpeed.SelectedItem.ToString());
            serialport = new SerialPort(" ", speed, Parity.None, 8, StopBits.One);//TODO: nazwa portu,szybkosc transmisji, bit parzystoci,bity danych, bit zatrzymania

            String[] ports = SerialPort.GetPortNames();
            foreach (String x in ports)
                comboBoxPorts.Items.Add(x);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {

            // to jest przekopiowane z kliknięcia Send i zmieniona pierwsza linia w try
            if (serialport.IsOpen)
            {
                try
                {
                    serialport.Write("ATD " + textBoxConnect.Text + System.Environment.NewLine);
                    //textBoxInformation.Text += comboBoxMessage.Text + System.Environment.NewLine;
                }
                catch (Exception ex)
                {
                    textBoxInformation.Text += " Error!" + ex.Message + System.Environment.NewLine;
                }
                serialport.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);
                delegat = new A(WpiszOdebrane);
            }

        }

        private void buttonPickUp_Click(object sender, EventArgs e)
        {
            serialport.Write("ATA" + System.Environment.NewLine);
        }

        private void buttonDissconnect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                serialport.Write("+" + System.Environment.NewLine);
                System.Threading.Thread.Sleep(500);
            }
            System.Threading.Thread.Sleep(1000);
        }

        private void textBoxConnect_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInformation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
