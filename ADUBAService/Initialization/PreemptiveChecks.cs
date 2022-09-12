using ADUBAService.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUBAService.Initialization
{
    class PreemptiveChecks
    {
        public static void verifyConfiguration()
        {
            ServiceConfiguration sc = new ServiceConfiguration();
            string rJson = File.ReadAllText("C:\\Users\\dy0x8\\Desktop\\Aduba\\config.json");
            DateTime dt = DateTime.Now;
            File.WriteAllText("C:\\Users\\dy0x8\\Desktop\\Aduba\\dump.txt", dt.ToString());
            // File.AppendAllText("C:\\Users\\dy0x8\\Desktop\\Aduba\\dump.txt", dt.ToString());
        }

    }
}
