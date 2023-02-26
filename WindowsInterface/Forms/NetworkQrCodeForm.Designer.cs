using System.ComponentModel;

namespace WindowsInterface
{
    partial class NetworkQrCodeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.qrCodebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodebox)).BeginInit();
            this.SuspendLayout();
            // 
            // qrCodebox
            // 
            this.qrCodebox.Location = new System.Drawing.Point(12, 12);
            this.qrCodebox.Name = "qrCodebox";
            this.qrCodebox.Size = new System.Drawing.Size(217, 194);
            this.qrCodebox.TabIndex = 0;
            this.qrCodebox.TabStop = false;
            // 
            // NetworkQrCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(241, 218);
            this.Controls.Add(this.qrCodebox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NetworkQrCodeForm";
            this.ShowInTaskbar = false;
            this.Text = "NetworkQrCodeForm";
            ((System.ComponentModel.ISupportInitialize)(this.qrCodebox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox qrCodebox;

        #endregion
    }
}