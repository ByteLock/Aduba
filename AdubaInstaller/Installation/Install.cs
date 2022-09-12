using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdubaInstaller.Installation
{
    class Install
    {
        public static ProgressBar progressBar;

        public static void InstallNetFramework(ProgressBar progressBar)
        {
            Install.progressBar = progressBar;
            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChangedEvent);
            client.DownloadFile(new Uri("https://github.com/ByteLock/Aduba/raw/main/AdubaService/bin/x64/Release/ADUBAService.exe"), "AdubaService.exe");
            
        }

        public static void DownloadProgressChangedEvent(object sender, DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine(e.BytesReceived);
        }


    }
}
