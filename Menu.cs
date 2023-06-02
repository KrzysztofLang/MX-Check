using System;
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
            Console.WriteLine("╔══════════════════════╗");
            Console.WriteLine("║ Wybierz opcję:       ║");
            Console.WriteLine("╠══════════════════════╣");
            Console.WriteLine("║ 1) Plik domyślny     ║");
            Console.WriteLine("║ 2) Własna ścieżka    ║");
            Console.WriteLine("║ 3) Pojedyncza domena ║");
            Console.WriteLine("║ 4) Instrukcja        ║");
            Console.WriteLine("║ 5) Wyjście           ║");
            Console.WriteLine("╚══════════════════════╝");
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
                        Splash();
                        Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                        Console.WriteLine("║ INSTRUKCJA                                                                                                   ║");
                        Console.WriteLine("╠══════════════════════════════════════════════════════════════════════════════════════════════════════════════╣");
                        Console.WriteLine("║ a) Plik wejściowy                                                                                            ║");
                        Console.WriteLine("║    Poprawnie sformatowany plik wejściowy składa się wyłącznie z adresów domen,                               ║");
                        Console.WriteLine("║    każda w osobnej linii.                                                                                    ║");
                        Console.WriteLine("║                                                                                                              ║");
                        Console.WriteLine("║ b) Plik domyślny                                                                                             ║");
                        Console.WriteLine("║    Ta opcja zakłada, że plik nosi nazwę \"domeny.csv\"                                                       ║");
                        Console.WriteLine("║    i znajduje się w tej samej lokalizacji co program.                                                        ║");
                        Console.WriteLine("║                                                                                                              ║");
                        Console.WriteLine("║ c) Własna ścieżka                                                                                            ║");
                        Console.WriteLine("║    Jeśli plik wejściowy ma inną nazwę, ale znajduje się w tej samej lokaliacji co program,                   ║");
                        Console.WriteLine("║    wystarczy podać jego nazwę. Jeżeli znajduje się w innej lokalizacji, należy podać pełną ścieżkę.          ║");
                        Console.WriteLine("║                                                                                                              ║");
                        Console.WriteLine("║ d) Pojedyncza domena                                                                                         ║");
                        Console.WriteLine("║    Jeśli chcesz sprawdzić tylko jedną domenę, możesz wpisać jej adres.                                       ║");
                        Console.WriteLine("║                                                                                                              ║");
                        Console.WriteLine("║ e) Plik wyjściowy                                                                                            ║");
                        Console.WriteLine("║    Niezależnie od wybranej opcji, w lokalizacji programu generowany zostaje plik o nazwie \"domenyMX.csv\".  ║");
                        Console.WriteLine("║    Pierwszy wiersz to tytuły kolumn: \"domena, MX\".                                                         ║");
                        Console.WriteLine("║    Kolejne wiersze to najpierw sprawdzana domena, a po przecinku znalezione rekordy MX rozdzielone spacjami. ║");
                        Console.WriteLine("╠══════════════════════════════════════════════════════════════════════════════════════════════════════════════╣");
                        Console.WriteLine("║ Aby cofnąć, wciśnij ENTER                                                                                    ║");
                        Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                        Console.ReadKey();
                        Splash();
                        Options();
                        break;
                    case "5":
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
