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
        delegate void A(string text);
        public Form1()
        {
            InitializeComponent();
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
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialport = new SerialPort("", 1, Parity.Even, 1, StopBits.None);//TODO: nazwa portu,szybkosc transmisji, bit parzystoci,bity danych, bit zatrzymania
                serialport.Open();
                textBox1.Text += " Connection open!" + System.Environment.NewLine;
            }catch(Exception exception)
            {
                textBox1.Text += "Error !" + exception.Message + System.Environment.NewLine;
            }
        }

        private void dataRecived(object sender, SerialDataReceivedEventArgs e)
        {
            receivedData = serialport.ReadExisting();
            if(receivedData != null)
            {
                BeginInvoke(new A((string text)=> { textBox1.Text += text; }), new object[] { receivedData }); 
            }
        }
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (serialport.IsOpen)
            {
                serialport.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
