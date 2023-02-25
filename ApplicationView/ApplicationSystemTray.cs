using System;
using System.Windows.Forms;

namespace ApplicationView
{
    public class ApplicationSystemTray : ApplicationContext
    {
        private NotifyIcon trayIcon;

        public ApplicationSystemTray()
        {
            trayIcon = new NotifyIcon()
            {
                ContextMenuStrip = new ContextMenuStrip()
                {
                 Items   = { new ToolStripMenuItem("Exit", null, Exit) },
                 Visible = true
                }
            };
        }
        
        void Exit(object? sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Application.Exit();
        }
    }
}