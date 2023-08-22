using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.E03_Strings
{
    class Exercise_12
    {
        public static void Start()
        {
            //Sorgen Sie dafür, dass nach der Eingabe ausgegeben wird, ob der eingegebene String ein A bzw. a besitzt, oder nicht.
            string s = Console.ReadLine() ?? "Irgendwas";
            bool b = false;

            //CODE START

            //CODE ENDE

            if(b)
            {
                Console.WriteLine("Das Wort enthält den Buchstaben A.");
            }
            else
            {
                Console.WriteLine("Das Wort enthält nicht den Buchstaben A.");
            }
        }
    }
}