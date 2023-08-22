using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.E03_Strings
{
    class Exercise_6
    {
        public static void Start()
        {
            //Sorgen Sie dafür, dass das erste Wort in Großbuchen und in Kleinbuchstaben ausgegeben wird.
            string val = "hAllIHaLlo";
            string small;
            string big;


            //Code START
            small = val;
            big = val;
            //Code ENDE

            Console.WriteLine("Kleinbuchstaben:");
            Console.WriteLine(small);
            Console.WriteLine("Großbuchstaben:");
            Console.WriteLine(big);
        }
    }
}