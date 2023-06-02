using System;
using System.Collections.Generic;
using System.IO;

namespace MX_Check
{
    internal class DomainFile
    {
        private List<string> domains = new List<string>();
        private const string fileDir = "domenyMX.csv";

        public List<string> Domains { get => domains; set => domains = value; }

        public DomainFile(string fileName)
        {
            if (fileName != "")
            {
                ReadDomains(fileName);
            }
        }

        private void ReadDomains(string file)
        {
            var reader = new StreamReader(file);
            bool firstRow = true;

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                if (!firstRow)
                    domains.Add(values[0]);
                else
                    firstRow = false;
            }

        }

        public static void SaveFile(List<string> mxRecords)
        {
            mxRecords.Insert(0, "domena,MX");
            File.WriteAllLines(fileDir, mxRecords);
        }
    }
}
