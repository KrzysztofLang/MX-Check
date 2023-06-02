using System;
using System.Collections.Generic;
using System.IO;

namespace MX_Check
{
    internal class File
    {
        private List<string> domains = new List<string>();

        public List<string> Domains { get => domains; set => domains = value; }

        public File(string fileName)
        {
            ReadDomains(fileName);
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

            foreach (string value in domains)
                Console.WriteLine(value);
        }
    }
}
