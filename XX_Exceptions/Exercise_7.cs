using System;

namespace Exercises_C_Sharp.XX_Exceptions
{
    class Exercise_7
    {
        //Sie sollen diese Methode umschreiben, sodass keine Exceptions mehr benötigt werden. Die Funktionalität soll aber nicht abgeändert werden.
        public static void Start()
        {
            //Code START
            int i;
            string s;
            char c;
            while(true)
            {
                try
                {
                    Console.WriteLine("Bitte Zahl eingeben:");
                    i = Convert.ToInt32(Console.ReadLine() ?? "");
                }
                catch
                {
                    Console.WriteLine("Falsche Zahl :(");
                    continue;
                }
                break;
            }
            while(true)
            {
                try
                {
                    Console.WriteLine("Bitte String eingeben:");
                    s = Console.ReadLine() ?? "";
                    c = s[i];
                }
                catch
                {
                    Console.WriteLine("Leider ein Fehler. Bitte String nochmal eingeben...");
                    continue;
                }
                break;
            }

            Console.WriteLine("Der extrahierte Char ist " + c);
            //Code ENDE
        }
        
    }
}