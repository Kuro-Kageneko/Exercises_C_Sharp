using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Tuple
{
    class Exercise_2
    {
        //Ändern Sie die Werte in dem Tuple 'tup', sodass die Werte "Breite2 und 12.9 darin stehen.

        public static void Start()
        {
            Tuple<string, double> tup = new Tuple<string, double>("Länge", 12.54);

            //Code START
            
            //Code ENDE


            //Konstrolle:
            Console.WriteLine("Die {0} beträgt {1} Meter.", tup.Item1, tup.Item2);
        }

    }
}