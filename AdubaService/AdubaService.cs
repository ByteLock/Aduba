using System;
using System.ServiceProcess;
using System.Timers;

namespace AdubaSerivce
{
    public partial class AdubaService : ServiceBase
    {
        // This timer will read the event log, then send the event log to the server after sanitizing it
        Timer heart = new Timer();

        public AdubaService()
        {
            InitializeComponent();
        }


        /**
         * On start, we are looking to check and start these systems (in order):
         *  1. Read and apply configuration to the service (replace config file and apply defaults if missing)
         *  2. Connect to mySql database
         *  3. Begin reading event log and sending to AdubaServer 
         *  4. (maybe) apply configuration for multi-server use
         */
        protected override void OnStart(string[] args)
        {
            heart.Elapsed += new ElapsedEventHandler(OnHeartbeat);
            heart.Interval = 1000;
            heart.Enabled = true;
            Initialization.PreemptiveChecks.verifyConfiguration();
        }

        /**
         * Actions:
         * 1. Read event log
         * 2. Sanitize event
         * 3. Create an event object
         * 4. Convert to bytes
         * 5. Convert "<EOF></EOF>" to end of file and append bytes
         * 6. Send the information to the AdubaServer
         */

        private void OnHeartbeat(object source, ElapsedEventArgs e)
        {
            Initialization.PreemptiveChecks.verifyConfiguration();
        }

        protected override void OnStop()
        {

        }
    }
}
