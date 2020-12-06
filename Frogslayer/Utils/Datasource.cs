using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogslayer.Utils
{
    public static class DataSource
    {
        // Ideally this would connect to an external data source that could be easily modified

        // login
        public static string userName = "larry.test@frogslayer.com";
        public static string password = "P@ssword1";

        // project
        public static string projectName = $"DemoProject-{DateTime.Now}";
        public static string surveyCost = "1337";
        public static string travelCost = "1234";
    }
}
