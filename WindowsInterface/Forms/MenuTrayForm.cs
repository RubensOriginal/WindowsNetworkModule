using System;
using System.Windows.Forms;

namespace WindowsInterface
{
    public partial class MenuTrayForm : Form
    {
        public MenuTrayForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}