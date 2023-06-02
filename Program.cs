using System;
using System.Collections.Generic;

namespace MX_Check
{
    internal class Program
    {
        static void Main()
        {
            string fileName = "";
            string domainName = "";
            string domainMX;
            string option;
            string optionVar;
            List<string> mxRecords = new();
            
            Menu.Splash();
            Menu.Options();

            (option, optionVar) = Menu.Choice();

            Menu.Splash();
            Console.WriteLine("Pracuję...");
            switch(option)
            {
                case "default":
                    fileName = "domeny.csv"; break;
                case "path":
                    fileName = optionVar; break;
                case "domain":
                    domainName = optionVar; break;
            }
                
            if (fileName != "")
            {
                DomainFile file = new(fileName);

                foreach (string domain in file.Domains)
                {
                    domainMX = domain + "," + string.Join(" ", RecordCheck.GetMXRecords(domain));
                    mxRecords.Add(domainMX);
                }
            }
            else
                mxRecords.Add(domainName + "," + string.Join(" ", RecordCheck.GetMXRecords(domainName)));

            Menu.Splash();
            DomainFile.SaveFile(mxRecords);
            Console.ReadKey();
        }
    }
}
