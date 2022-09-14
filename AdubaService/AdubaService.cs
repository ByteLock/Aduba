using System;
using System.ServiceProcess;
using System.Timers;

namespace AdubaSerivce
{
    public partial class AdubaService : ServiceBase
    {
        Timer heart = new Timer();

        public AdubaService()
        {
            InitializeComponent();
        }


        /**
         * On start, we are looking to check and start these systems (in order):
         *  1. Read and apply configuration to the service (replace config file and apply defaults if missing)
         *  2. Connect to mySql database
         *  3. Start socket server and configured port and address (multi-threaded server instead of single)
         *  4. (maybe) apply configuration for multi-server use
         */
        protected override void OnStart(string[] args)
        {


            heart.Elapsed += new ElapsedEventHandler(OnHeartbeat);
            heart.Interval = 1000;
            heart.Enabled = true;
            Initialization.PreemptiveChecks.verifyConfiguration();
        }

        private void OnHeartbeat(object source, ElapsedEventArgs e)
        {
            Initialization.PreemptiveChecks.verifyConfiguration();
        }

        protected override void OnStop()
        {

        }
    }
}
