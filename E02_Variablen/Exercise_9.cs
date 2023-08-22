using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.E02_Variablen
{
    class Exercise_9
    {
        public static void Start()
        {
            //Sorgen Sie dafür, dass die Zahl 2736.938 unten auf der Konsole ausgegeben wird.

            //Code START
            double d1 = 2634.37263;
            double d2 = 237384.2832;
            double d3 = 663782.39283;
            //Code ENDE

            d1 = d2 -d3;
            d2 = d3 / d1;
            d3 = d1 * d3;
            d1 = d3 / d2;
            d2 = d3 + d2;
            double d4 = d1 + d2 + d3;

            //Code Start
            double d5 = 0;
            //Code Ende
            Console.WriteLine(d5 + d4 + d3 + d2 + d1);
        }
    }
}