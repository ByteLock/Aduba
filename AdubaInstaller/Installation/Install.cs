using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public static void InstallNetFramework(WebClient wc)
        {
            wc.DownloadFileAsync(new Uri("https://github.com/ByteLock/Aduba/raw/main/AdubaService/bin/x64/Release/ADUBAService.exe"), "AdubaService.exe");
            
        }

        


    }
}
