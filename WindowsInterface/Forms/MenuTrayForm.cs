using Gma.System.MouseKeyHook;
using System.Windows.Forms;
using System;
using System.Drawing;
using QrCodeModule;
using WifiModule;

namespace WindowsInterface
{
    public partial class MenuTrayForm : Form
    {
        
        public MenuTrayForm()
        {
            InitializeComponent();

            Hook.GlobalEvents().MouseClick += hide_Click;
        }

        private void hide_Click(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X ||
                e.X > this.Location.X + Width ||
                e.Y < this.Location.Y || 
                 e.Y > this.Location.Y + Height)
                Hide();
        }
        
        private void exit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void generateQRCode_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = null;
            
            try
            {
                NetworkDataFinder finder = new NetworkDataFinder();
                QrCodeManager qrCodeManager = new QrCodeManager();

                bitmap = qrCodeManager.GenerateQrCodeWithBMP(
                    finder.GetNetworkData(finder
                            .GetCurrentNetworkName())
                        .NetworkDataToWifiStringPattern());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            NetworkQrCodeForm qrCodeForm = new NetworkQrCodeForm(bitmap);
            qrCodeForm.Show();

            qrCodeForm.Location = new Point(Location.X - qrCodeForm.Width + Width, Location.Y - qrCodeForm.Height + Height);
            qrCodeForm.TopMost = true;
            
            Hide();
        }
    }
}