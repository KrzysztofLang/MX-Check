using DnsClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MX_Check
{
    internal class RecordCheck
    {
        public static List<string> GetMXRecords(string domain)
        {
            List<string> mxRecords = new List<string>();

            try
            {
                var lookupClient = new LookupClient();
                var result = lookupClient.Query(domain, QueryType.MX);
                foreach (var record in result.Answers.MxRecords())
                {
                    mxRecords.Add(record.Exchange.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return mxRecords;
        }
    }
}
