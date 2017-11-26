using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using WIA;
using System.IO;
using static System.Resources.ResXFileRef;
using WiaDotNet;

namespace cw12___Biernat_Bojzan
{
    //aberacja sferyczna
    //synchrnizacja klatek

    public partial class FormScanner : Form
    {
        static Byte[] imageBytes;
        static WIA.CommonDialog dialog = new WIA.CommonDialog();
        static WIA.Device device;// = dialog.ShowSelectDevice(WIA.WiaDeviceType.UnspecifiedDeviceType, true, false);
        const string wiaFormatBMP = "{B96B3CAB-0728-11D3-9D7B-0000F81EF32E}";

        public FormScanner()
        {
            InitializeComponent();
        }

        private static void AdjustScannerSettings(IItem scannnerItem, int scanResolutionDPIHorizontal, int scanResolutionDPIVertical, int scanStartLeftPixel, int scanStartTopPixel,
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
        }

        private static void SetWIAProperty(IProperties properties, object propName, object propValue)
        {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }
        public void Skanuj()
        {
            WIA.ImageFile image = null;
            if (device != null)
            {
                InicjalizacjaUstawien(); //funkcja inicjująca ustawienia skanera
                image = (ImageFile)dialog.ShowTransfer(device.Items[1], wiaFormatBMP, true);
                imageBytes = (byte[])image.FileData.get_BinaryData();
                MemoryStream ms = new MemoryStream(imageBytes);
                Image img = Image.FromStream(ms);
                pictueBoxPicture.Image = img;
            }
            else
            {
                InicjalizacjaUstawien();
                image = (ImageFile)dialog.ShowTransfer(device.Items[1], wiaFormatBMP, true);
                imageBytes = (byte[])image.FileData.get_BinaryData();
                MemoryStream ms = new MemoryStream(imageBytes);
                Image img = Image.FromStream(ms);
            }
        }
        public void InicjalizacjaUstawien()
        {
            try
            {
                WIA.Item item = device.Items[1] as WIA.Item;

                Int32 DPI = 300;// Convert.ToInt32(textBox1.Text);
                Int32 contrast;//= Convert.ToInt32(textBoxKontrast.Text);
                Int32 brightness;// = Convert.ToInt32(textBoxJasnosc.Text);
                Int32 colormode;// = 0;

                if (textBoxDPI.Text != "")
                    DPI = Convert.ToInt32(textBoxDPI.Text);
                else
                    DPI = 300;

                if (textBoxKontrast.Text != "")
                    contrast = Convert.ToInt32(textBoxKontrast.Text);
                else
                    contrast = 0;

                if (textBoxJasnosc.Text != "")
                    brightness = Convert.ToInt32(textBoxJasnosc.Text);
                else
                    brightness = 0;


                if (radioButtonColor.Checked)
                    colormode = 1;
                else
                    colormode = 2;

                Console.Write(colormode);
                AdjustScannerSettings(item, DPI, DPI, 0, 0, 2550, 3501, brightness, contrast, colormode);
                //item.Properties["3097"].set_Value(0);
            }
            catch
            {
                MessageBox.Show("Skaner nie jest gotowy lub nie obsługuje tej funkcji.\r\n\r\n Przywrócono ustawienia domyślne.", "Inicjalizacja",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void włączGórne_Click(object sender, EventArgs e)
        {

            WIA.ImageFile img = null;
            device = null;
            try
            {
                device = dialog.ShowSelectDevice(WIA.WiaDeviceType.ScannerDeviceType, true, true);

                if (device != null)
                {
                    Skanuj();
                }
                else
                {
                    InicjalizacjaUstawien();
                    img = (ImageFile)dialog.ShowTransfer(device.Items[1], wiaFormatBMP, true);
                }
            }
            catch
            {
                throw new Exception("You must select a device for scanning.");
            }
        }
    }
}
 
