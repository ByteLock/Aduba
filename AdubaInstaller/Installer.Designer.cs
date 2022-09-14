namespace AdubaInstaller
{
    partial class Installer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.fileInstallProgress = new System.Windows.Forms.ProgressBar();
            this.installButton = new System.Windows.Forms.Button();
            this.filePathBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fileInstallProgress
            // 
            this.fileInstallProgress.Location = new System.Drawing.Point(24, 66);
            this.fileInstallProgress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fileInstallProgress.Name = "fileInstallProgress";
            this.fileInstallProgress.Size = new System.Drawing.Size(752, 44);
            this.fileInstallProgress.TabIndex = 0;
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(336, 122);
            this.installButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(150, 44);
            this.installButton.TabIndex = 2;
            this.installButton.Text = "Install";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // filePathBox
            // 
            this.filePathBox.Location = new System.Drawing.Point(24, 23);
            this.filePathBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.Size = new System.Drawing.Size(752, 31);
            this.filePathBox.TabIndex = 3;
            // 
            // Installer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 177);
            this.Controls.Add(this.filePathBox);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.fileInstallProgress);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Installer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar fileInstallProgress;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.TextBox filePathBox;
    }
}

