using DnsClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MX_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string domain = "betterit.pl";
            File file = new("C:\\Users\\klang\\OneDrive - MH-info sp. z o.o\\Visual Studio\\MX-Check\\domeny.csv");


            List<string> mxRecords = RecordCheck.GetMXRecords(domain);

            while (true) { continue; }

        }
    }
}
