using System;

namespace Exercises_C_Sharp.XX_Exceptions
{
    class Exercise_4
    {
        public static void Start()
        {
            //Welche Exceptions könnten in der Methode possible fliegen? Fangen Sie alle möglichen Exceptions ab!
            try
            {
                possible();
            }
            //Code START
            catch
            {

            }
            //Code ENDE
        }
        #pragma warning disable CS8602, CS8600
        static void possible()
        {
            Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            int i =  Convert.ToInt32(Console.ReadLine());
            double d = Math.PI / i;
            Console.WriteLine("Ihr Ergebnis ist: {0}", d);
            Console.WriteLine("Bitte geben Sie nun einen String ein:");
            string s = Console.ReadLine();
            Console.WriteLine("Der dritte Wert ist {0}", s[2]);
            Console.WriteLine("Das Wort groß geschrieben lautet {0}", s.ToUpper());

        }
        #pragma warning restore CS8602, CS8600
        
    }
}