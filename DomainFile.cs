using System;
using System.Collections.Generic;
using System.IO;

namespace MX_Check
{
    internal class DomainFile
    {
        private List<string> domains = new();
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

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                domains.Add(values[0]);
            }

        }

        public static void SaveFile(List<string> mxRecords)
        {
            mxRecords.Insert(0, "domena,MX");
            File.WriteAllLines(fileDir, mxRecords);

            Console.WriteLine("╔═════════════════════════════════════╗");
            Console.WriteLine("║ Zapisano dane w pliku domenyMX.csv. ║");
            Console.WriteLine("║ Poniżej podgląd zawartości.         ║");
            Console.WriteLine("╚═════════════════════════════════════╝");
            Console.WriteLine("\n");

            foreach (string value in mxRecords)
            {
                Console.WriteLine(value);
            }
        }
    }
}
