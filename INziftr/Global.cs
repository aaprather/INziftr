using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace INziftr
{
    static class Global
    {
        public static int coreCount = 0;
        
        public static bool hide = false;
        
        public static int hidecount = 0;

        public static string processorname;

        public static string location = System.Environment.CurrentDirectory + "\\temp_folder\\";
    }
}
