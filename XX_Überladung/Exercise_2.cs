using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Überladung
{
    class Exercise_2
    {
        //Schreiben Sie den unteren Code so um, dass die Felder Number und DoubleNumber entfernt werden können. Nutzen Sie dafür die Möglichkeit der Überladung.

        //Code START
        static int Number = 0;
        static double DoubleNumber = 0.0;

        public static void Start()
        {
            Number = 13;
            Output();
            DoubleNumber = 34.23;
            Output();
        }


        static void Output()
        {
            if(Number != 0)
                Console.WriteLine("Der Integer {0} wurde gesetzt.", Number);
            else if(DoubleNumber != 0.0)
                Console.WriteLine("Der Double {0} wurde gesetzt.", DoubleNumber);
        }
        //Code ENDE
    }
}