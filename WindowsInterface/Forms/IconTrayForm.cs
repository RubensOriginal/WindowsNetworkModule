using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsInterface
{
    public partial class IconTrayForm : Form
    {
        public IconTrayForm()
        {
            InitializeComponent();

            notifyIcon.Visible = true;
            
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            Program.menuTrayForm.Show();
            Program.menuTrayForm.Location = new Point(Cursor.Position.X - 257, Cursor.Position.Y - 85);
            Program.menuTrayForm.TopMost = true;
        }
    }
}