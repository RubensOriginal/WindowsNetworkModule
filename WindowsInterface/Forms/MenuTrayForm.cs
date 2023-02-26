using System;
using System.Diagnostics;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using System.Threading;

namespace WindowsInterface
{
    public partial class MenuTrayForm : Form
    {
        private bool wasClicked = false;
        
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

        private void MenuTrayForm_MouseClick(object sender, MouseEventArgs e)
        {
            wasClicked = true;
        }
    }
}