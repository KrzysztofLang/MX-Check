using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MX_Check
{
    internal class Menu
    {
        public static void Splash()
        {
            Console.Clear();
            Console.WriteLine("███╗   ███╗██╗  ██╗      ██████╗██╗  ██╗███████╗ ██████╗██╗  ██╗");
            Console.WriteLine("████╗ ████║╚██╗██╔╝     ██╔════╝██║  ██║██╔════╝██╔════╝██║ ██╔╝");
            Console.WriteLine("██╔████╔██║ ╚███╔╝█████╗██║     ███████║█████╗  ██║     █████╔╝ ");
            Console.WriteLine("██║╚██╔╝██║ ██╔██╗╚════╝██║     ██╔══██║██╔══╝  ██║     ██╔═██╗ ");
            Console.WriteLine("██║ ╚═╝ ██║██╔╝ ██╗     ╚██████╗██║  ██║███████╗╚██████╗██║  ██╗");
            Console.WriteLine("╚═╝     ╚═╝╚═╝  ╚═╝      ╚═════╝╚═╝  ╚═╝╚══════╝ ╚═════╝╚═╝  ╚═╝");
            Console.WriteLine("                                         by Krzysztof Lang, 2023");
            Console.WriteLine("\n\n");
        }

        public static void Options()
        {
            Console.WriteLine("╔═══════════════════════════════╗");
            Console.WriteLine("║ Wybierz opcję:                ║");
            Console.WriteLine("╠═══════════════════════════════╣");
            Console.WriteLine("║ 1) Plik domyślny (domeny.csv) ║");
            Console.WriteLine("║ 2) Własna ścieżka             ║");
            Console.WriteLine("║ 3) Pojedyncza domena          ║");
            Console.WriteLine("║ 4) Wyjście                    ║");
            Console.WriteLine("╚═══════════════════════════════╝");
            Console.WriteLine("\nTwój wybór:");
        }

        public static (string, string) Choice()
        {
            bool isCorrectInput = false;
            string choice = "";
            string choiceVar = "";

            do
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Splash();
                        isCorrectInput = true;
                        choice = "default";
                        break;
                    case "2":
                        isCorrectInput = true;
                        choice = "path";
                        do
                        {
                            Splash();
                            Console.WriteLine("Podaj pełną ścieżkę do pliku,\nlub jeśli znajduje się w folderze programu - tylko jego nazwę:\n");
                            choiceVar = Console.ReadLine();
                        }
                        while (!File.Exists(choiceVar));
                        break;
                    case "3":
                        Splash();
                        isCorrectInput = true;
                        Console.WriteLine("Podaj domenę do sprawdzenia:\n");
                        choice = "domain";
                        choiceVar = Console.ReadLine();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Splash();
                        Options();
                        break;
                }
            }
            while (!isCorrectInput);

            return (choice, choiceVar);
        }
    }
}
