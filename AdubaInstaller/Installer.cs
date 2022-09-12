using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ProgressBar f = fileInstallProgress;
            Installation.Install.InstallNetFramework(f);
        }
    }
}
