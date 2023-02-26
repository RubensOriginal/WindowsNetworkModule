using Gma.System.MouseKeyHook;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsInterface
{
    public partial class NetworkQrCodeForm : Form
    {
        public NetworkQrCodeForm(Bitmap bitmap)
        {
            InitializeComponent();
            Hook.GlobalEvents().MouseClick += hide_Click;

            if (bitmap != null)
            {
                qrCodebox.Image = new Bitmap(bitmap, qrCodebox.Width, qrCodebox.Height);
            }
            
        }
        
        private void hide_Click(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X ||
                e.X > this.Location.X + Width ||
                e.Y < this.Location.Y || 
                e.Y > this.Location.Y + Height)
                Hide();
        }
    }
}