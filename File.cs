using DnsClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MX_Check
{
    internal class File
    {
        private List<string> domains = new List<string>();

        public List<string> Domains { get => domains; set => domains = value; }

        public static void ReadDomains(string file)
        {
            
        }
    }
}
