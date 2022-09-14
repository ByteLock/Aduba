using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace AdubaInstaller
{
    public partial class Installer : Form
    {

        private String currentInstallPath = "";

        public Installer()
        {
            InitializeComponent();
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            // Create a new web client
            WebClient client = new WebClient();
            
            // Set download progress changed event and completed
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChangedEvent);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFinished);

            // Env vars
            currentInstallPath = Directory.GetCurrentDirectory();

            // Install the framework
            Installation.Install.InstallNetFramework(client, currentInstallPath);
        }


        private void DownloadProgressChangedEvent(object sender, DownloadProgressChangedEventArgs e)
        {
            filePathBox.Enabled = false;
            filePathBox.Text = currentInstallPath;
            fileInstallProgress.Value = e.ProgressPercentage;
        }

        private void DownloadFinished(object sender, AsyncCompletedEventArgs e)
        {
            var res = MessageBox.Show("The donwload has finished!", "File Installer", MessageBoxButtons.OK);
            if(res == DialogResult.OK)
            {
                fileInstallProgress.Value = 0;
            }
        }


    }
}
