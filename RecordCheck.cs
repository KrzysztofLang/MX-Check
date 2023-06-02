using DnsClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MX_Check
{
    internal class RecordCheck
    {
        public static List<string> GetMXRecords(string domain)
        {
            List<string> mxRecords = new();

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
