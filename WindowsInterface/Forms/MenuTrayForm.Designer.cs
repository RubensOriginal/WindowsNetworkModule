using System.ComponentModel;

namespace WindowsInterface
{
    partial class MenuTrayForm
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
            this.generateQRCode = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generateQRCode
            // 
            this.generateQRCode.Location = new System.Drawing.Point(3, 3);
            this.generateQRCode.Name = "generateQRCode";
            this.generateQRCode.Size = new System.Drawing.Size(251, 36);
            this.generateQRCode.TabIndex = 0;
            this.generateQRCode.Text = "Generate QR Code";
            this.generateQRCode.UseVisualStyleBackColor = true;
            this.generateQRCode.Click += new System.EventHandler(this.generateQRCode_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(3, 45);
            this.exit.Name = "exit";
            this.exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exit.Size = new System.Drawing.Size(251, 36);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // MenuTrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(257, 85);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.generateQRCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuTrayForm";
            this.ShowInTaskbar = false;
            this.Text = "MenuTrayForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button exit;

        private System.Windows.Forms.Button generateQRCode;

        #endregion
    }
}