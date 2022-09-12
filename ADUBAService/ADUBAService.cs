using System;
using System.ServiceProcess;
using System.Timers;

namespace ADUBAService
{
    public partial class ADUBAService : ServiceBase
    {
        Timer timer = new Timer();

        public ADUBAService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer.Elapsed += new System.Timers.ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 1000;
            timer.Enabled = true;
            Initialization.PreemptiveChecks.verifyConfiguration();
        }

        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            Initialization.PreemptiveChecks.verifyConfiguration();
        }

        protected override void OnStop()
        {

        }
    }
}
