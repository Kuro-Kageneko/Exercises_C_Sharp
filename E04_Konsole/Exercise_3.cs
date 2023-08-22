using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.E04_Konsole
{
    class Exercise_3
    {
        public static void Start()
        {
            //Auf der Konsole soll das ausgegeben werden, was der Anwender eingibt.
            
            Console.WriteLine("Bitte geben Sie was ein:");
            //Code START
            string s = "irgendwas?";
            //Code ENDE

            Console.WriteLine("Ihre Eingabe war:\n" + s);
        }
    }
}