using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AdubaInstaller
{
    public partial class Installer : Form
    {
        public Installer()
        {
            InitializeComponent();
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChangedEvent);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(AsyncDownloadFinished);
            Installation.Install.InstallNetFramework(client);
        }

        private void DownloadProgressChangedEvent(object sender, DownloadProgressChangedEventArgs e)
        {
            fileInstallProgress.Value = e.ProgressPercentage;
        }

        private void AsyncDownloadFinished(object sender, AsyncCompletedEventArgs e)
        {
            var res = MessageBox.Show("The donwload has finished!", "File Installer", MessageBoxButtons.OK);
            if(res == DialogResult.OK)
            {
                fileInstallProgress.Value = 0;
            }
        }


    }
}
