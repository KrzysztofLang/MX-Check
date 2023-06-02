using DnsClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MX_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string domain = "betterit.pl";

            List<string> mxRecords = new List<string>();

            mxRecords = RecordCheck.GetMXRecords(domain);

            while (true) { continue; }

        }
    }
}
