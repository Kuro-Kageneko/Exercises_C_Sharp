using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Tuple
{
    class Exercise_3
    {
        //Erstellen Sie ein Tuple, welches dafür sorgt, dass unten die Daten für den Mt. Everest richtig ausgibt.

        public static void Start()
        {
            //Code START
            dynamic tup = -1;
            //Code ENDE


            //Konstrolle:
            Console.WriteLine("Der Berg {0} ist {1} Meter hoch und liegt in {2}.", tup.Item1, tup.Item2, tup.Item3);
        }

    }
}