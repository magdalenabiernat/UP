using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace Scanner
{
    public partial class Form1 : Form
    {
        WIA.CommonDialog Dialog1 = new WIA.CommonDialog();
        static WIA.Device Scanner;
 
        Byte[] imageBytes;
        
        private const string wiaFormatBMP = "{B96B3CAB-0728-11D3-9D7B-0000F81EF32E}";
        private const string wiaFormatJPEG = "{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Select();
        }




        private void button2_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null)
            {


                FileStream file = File.OpenWrite("d.bmp");
                file.Write(imageBytes, 0, imageBytes.Length);
                file.Close();
                MessageBox.Show("zapisano");
            }
        }

        private bool chooseDevice()
        {
            try
            {
                Scanner = Dialog1.ShowSelectDevice(WIA.WiaDeviceType.ScannerDeviceType, true, true);
                if (Scanner != null) return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Nie wybrano skanera " + ex.Message, "Wybierz urz?dzenie",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

      
        private static void SetWIAProperty(IProperties properties, object propName, object propValue)
        {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }



        private static void AdjustScannerSettings(IItem scannnerItem, int scanResolutionDPIHorizontal,int scanResolutionDPIVertical, int scanStartLeftPixel, int scanStartTopPixel,
                int scanWidthPixels, int scanHeightPixels, int brightnessPercents, int contrastPercents, int colorMode)
        {
            const string WIA_SCAN_COLOR_MODE = "6146";
            const string WIA_HORIZONTAL_SCAN_RESOLUTION_DPI = "6147";
            const string WIA_VERTICAL_SCAN_RESOLUTION_DPI = "6148";
            const string WIA_HORIZONTAL_SCAN_START_PIXEL = "6149";
            const string WIA_VERTICAL_SCAN_START_PIXEL = "6150";
            const string WIA_HORIZONTAL_SCAN_SIZE_PIXELS = "6151";
            const string WIA_VERTICAL_SCAN_SIZE_PIXELS = "6152";
            const string WIA_SCAN_BRIGHTNESS_PERCENTS = "6154";
            const string WIA_SCAN_CONTRAST_PERCENTS = "6155";
            


            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_RESOLUTION_DPI, scanResolutionDPIHorizontal);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_RESOLUTION_DPI, scanResolutionDPIVertical);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_START_PIXEL, scanStartLeftPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_START_PIXEL, scanStartTopPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_SIZE_PIXELS, scanWidthPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_SIZE_PIXELS, scanHeightPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_BRIGHTNESS_PERCENTS, brightnessPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_CONTRAST_PERCENTS, contrastPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_COLOR_MODE, colorMode);

           
            //SetWIAProperty(Scanner.Properties, 3097, WIA_PAGE_ISO_A4);
        }

        private void InitializeITEM()
        {
            
            try
            {
                WIA.Item item = Scanner.Items[1] as WIA.Item;

                Int32 DPI = 300;// Convert.ToInt32(textBox1.Text);
                Int32 contrast; //= Convert.ToInt32(textBox2.Text);
                Int32 brightness;// = Convert.ToInt32(textBox3.Text);
                Int32 colormode;

                if (textBox1.Text != "")
                    DPI = Convert.ToInt32(textBox1.Text);
                else
                    DPI = 300;

                if (textBox2.Text != "")
                    contrast = Convert.ToInt32(textBox2.Text);
                else
                    contrast = 0;

                if (textBox3.Text != "")
                    brightness = Convert.ToInt32(textBox3.Text);
                else
                    brightness = 0; 


                if (radioButton1.Checked)
                    colormode = 1;
                else
                    colormode = 2;

                Console.Write(colormode);
                AdjustScannerSettings(item, DPI,  DPI, 0, 0, 2550, 3501, brightness, contrast, colormode);
                //item.Properties["3097"].set_Value(0);



            }
            catch
            {
                MessageBox.Show("Skaner nie jest gotowy lub nie obs?uguje tej funkcji.\r\n\r\n Przywrócono ustawienia domy?lne.", "Inicjalizacja",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        

        private void button1_Click(object sender, EventArgs e)
        {

            
            WIA.ImageFile Img = null;
            Scanner = null;
            try
            {
                if (Scanner == null)
                    if (chooseDevice())
                    {
                        InitializeITEM();//inicjuje ustawienia skanera      
                        Img = (ImageFile)Dialog1.ShowTransfer(Scanner.Items[1], wiaFormatBMP, true);
                        imageBytes = (byte[])Img.FileData.get_BinaryData(); // <– Converts the ImageFile to a byte array
                        MemoryStream ms = new MemoryStream(imageBytes);
                        Image image = Image.FromStream(ms);
                        pictureBox1.Image = image;
                    }
                    else
                    {
                        InitializeITEM();//inicjuje ustawienia skanera      
                        Img = (ImageFile)Dialog1.ShowTransfer(Scanner.Items[1], wiaFormatBMP, true);
                        imageBytes = (byte[])Img.FileData.get_BinaryData(); // <– Converts the ImageFile to a byte array
                        MemoryStream ms = new MemoryStream(imageBytes);
                        Image image = Image.FromStream(ms);

                        Image image2 = (Image)new Bitmap(image, new Size(1366, 768));                        
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox1.Image = image2;
                        return;
                    }
                else
                {
                    InitializeITEM();
                    Img = (ImageFile)Dialog1.ShowTransfer(Scanner.Items[1], wiaFormatBMP, true);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Skanuj...",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Img != null)
                    Marshal.ReleaseComObject(Img);
            }
        }
    }
}
