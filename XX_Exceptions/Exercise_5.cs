using System;

namespace Exercises_C_Sharp.XX_Exceptions
{
    class Exercise_5
    {
       public static void Start()
        {
            //Unten sehen Sie nun wieder die Methode possible wie in der vorherigen Aufgabe. Sorgen Sie nun dafür, dass unten keine Exception mehr fliegen kann. Der Funktionsumfang soll aber der selbe bleiben. Entfernen Sie dann auch die Preprocessordirectives.
            try
            {
                possible();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Aufgabe leider nicht geschafft :(");
                Console.WriteLine("Fehler: {0}", ex.ToString());
            }
        }
        #pragma warning disable CS8602, CS8600
        static void possible()
        {
            //Code START
            Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            int i =  Convert.ToInt32(Console.ReadLine());
            double d = Math.PI / i;
            Console.WriteLine("Ihr Ergebnis ist: {0}", d);
            Console.WriteLine("Bitte geben Sie nun einen String ein:");
            string s = Console.ReadLine();
            Console.WriteLine("Der dritte Wert ist {0}", s[2]);
            Console.WriteLine("Das Wort groß geschrieben lautet {0}", s.ToUpper());
            //Code ENDE
        }
        #pragma warning restore CS8602, CS8600
        
    }
}