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

namespace cw12___Biernat_Bojzan
{
    //aberacja sferyczna
    //synchrnizacja klatek

    public partial class obsługaKameryUSB : Form
    {
        static Byte[] imageBytes;
        public obsługaKameryUSB()
        {
            InitializeComponent();
        }
        public class WIAScanner
        {

            const string wiaFormatBMP = "{B96B3CAB-0728-11D3-9D7B-0000F81EF32E}";
            class WIA_DPS_DOCUMENT_HANDLING_SELECT
            {
                public const uint FEEDER = 0x00000000;
                public const uint FLATBED = 0x00000000;
            }
            class WIA_DPS_DOCUMENT_HANDLING_STATUS
            {
                public const uint FEED_READY = 0x00000000;
            }
            class WIA_PROPERTIES
            {

                public const uint WIA_RESERVED_FOR_NEW_PROPS =300;
                public const uint WIA_DIP_FIRST=300;
                public const uint WIA_DPA_FIRST = WIA_DIP_FIRST + WIA_RESERVED_FOR_NEW_PROPS;
                public const uint WIA_DPC_FIRST = WIA_DPA_FIRST + WIA_RESERVED_FOR_NEW_PROPS;

                //// Scanner only device properties (DPS)
                ////
                public const uint WIA_DPS_FIRST = WIA_DPC_FIRST + WIA_RESERVED_FOR_NEW_PROPS;
                public const uint WIA_DPS_DOCUMENT_HANDLING_STATUS = WIA_DPS_FIRST +12;
                public const uint WIA_DPS_DOCUMENT_HANDLING_SELECT = WIA_DPS_FIRST+13 ;
            }
            /// <summary>
            /// Use scanner to scan an image (with user selecting the scanner from a dialog).
            /// </summary>
            /// <returns>Scanned images.</returns>
            public static List<Image> Scan(PictureBox obrazek)
            {
                WIA.CommonDialog dialog = new WIA.CommonDialog();
                WIA.Device device = dialog.ShowSelectDevice
                    (WIA.WiaDeviceType.UnspecifiedDeviceType, true, false);
                if (device != null)
                {
                    return Scan(device.DeviceID, obrazek);
                }
                else
                {
                    throw new Exception("You must select a device for scanning.");
                }
            }
            /// <summary>
            /// Use scanner to scan an image (scanner is selected by its unique id).
            /// </summary>
            /// <param name="scannerName"></param>
            /// <returns>Scanned images.</returns>
            static WIA.ImageFile image;
            public static List<Image> Scan(string scannerId, PictureBox obraz)
            {
                List<Image> images = new List<Image>();
                bool hasMorePages = true;
                while (hasMorePages)
                {
                    // select the correct scanner using the provided scannerId parameter
                    WIA.DeviceManager manager = new WIA.DeviceManager();
                    WIA.Device device = null;
                    foreach (WIA.DeviceInfo info in manager.DeviceInfos)
                    {
                        if (info.DeviceID == scannerId)
                        {
                            // connect to scanner
                            device = info.Connect();
                            break;
                        }
                    }
                    // device was not found
                    if (device == null)
                    {
                        // enumerate available devices
                        string availableDevices = "";
                        foreach (WIA.DeviceInfo info in manager.DeviceInfos)
                        {
                            availableDevices += info.DeviceID + "\n";
                        }
                        // show error with available devices
                        throw new Exception("The device with provided ID could not be found. Available Devices:\n" + availableDevices);
                    }
                    WIA.Item item = device.Items[1] as WIA.Item;
                    try
                    {
                        // scan image
                        WIA.ICommonDialog wiaCommonDialog = new WIA.CommonDialog();
                        image = (WIA.ImageFile)wiaCommonDialog.ShowTransfer(item, wiaFormatBMP, false);
                        // save to temp file


                        //  obraz.Image = img;
                        string fileName = "ala";
                        File.Delete(fileName);
                        image.SaveFile(fileName);

                        //image = null;
                        // add file to output list
                        images.Add(Image.FromFile(fileName));

                    }
                    catch (Exception exc)
                    {
                        throw exc;
                    }
                    finally
                    {
                        item = null;
                        //determine if there are any more pages waiting
                        WIA.Property documentHandlingSelect=null;
                        WIA.Property documentHandlingStatus=null;
                        foreach (WIA.Property prop in device.Properties)
                        {
                            if (prop.PropertyID == WIA_PROPERTIES.WIA_DPS_DOCUMENT_HANDLING_SELECT)
                                documentHandlingSelect = prop;
                            if (prop.PropertyID == WIA_PROPERTIES.WIA_DPS_DOCUMENT_HANDLING_STATUS)
                                documentHandlingStatus = prop;
                        }
                        // assume there are no more pages
                        hasMorePages = false;
                        // may not exist on flatbed scanner but required for feeder
                        if (documentHandlingSelect != null)
                        {
                            // check for document feeder
                            if ((Convert.ToUInt32(documentHandlingSelect.get_Value()) &
                            WIA_DPS_DOCUMENT_HANDLING_SELECT.FEEDER) != 0)
                            {
                                hasMorePages = ((Convert.ToUInt32(documentHandlingStatus.get_Value()) &
                                WIA_DPS_DOCUMENT_HANDLING_STATUS.FEED_READY) != 0);
                            }
                        }
                        imageBytes = (byte[])image.FileData.get_BinaryData(); // <– Converts the ImageFile to a byte array
                        MemoryStream ms = new MemoryStream(imageBytes);
                        Image img = Image.FromStream(ms);
                        obraz.Image = img;
                        image = null;
                    }
                }

                return images;
            }
            /// <summary>
            /// Gets the list of available WIA devices.
            /// </summary>
            /// <returns></returns>
            public static List<string> GetDevices()
            {
                List<string> devices = new List<string>();
                WIA.DeviceManager manager = new WIA.DeviceManager();
                foreach (WIA.DeviceInfo info in manager.DeviceInfos)
                {
                    devices.Add(info.DeviceID);
                }
                return devices;
            }
        }

        public static List<string> GetDevices()
        {
            List<string> devices = new List<string>();
            WIA.DeviceManager manager = new WIA.DeviceManager();
            foreach (WIA.DeviceInfo info in manager.DeviceInfos)
            {
                devices.Add(info.DeviceID);
            }
            return devices;
        }
        private void włączGórne_Click(object sender, EventArgs e)
        {
            WIA.CommonDialog dialog = new WIA.CommonDialog();
            WIA.Device device = dialog.ShowSelectDevice
                (WIA.WiaDeviceType.UnspecifiedDeviceType, true, false);
            if (device != null)
            {
                WIAScanner.Scan(device.DeviceID, obrazekLewy);

            }
            else
            {
                throw new Exception("You must select a device for scanning.");
            }
            //if (camera2.IsRunning)
            //    camera2.Stop();
            ////camera2 = new VideoCaptureDevice(usbCamera2[listaKamerDolna.SelectedIndex].MonikerString);
            ////camera2.NewFrame += new NewFrameEventHandler(cam_NewFrame2);
            //camera2.Start();
            //writer2 = new VideoFileWriter();
            //writer2.Open(@"C:\Users\magda\Desktop\Madzia\PWr\UP\cw12\film1.avi", 1280, 720, 30, VideoCodec.MPEG4);
        }
    }
}
