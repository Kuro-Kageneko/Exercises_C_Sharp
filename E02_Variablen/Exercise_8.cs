using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.E02_Variablen
{
    class Exercise_8
    {
        public static void Start()
        {

            //Erstellen Sie unten die drei Variablen richtig:
            //Code START
            dynamic firstValue;
            dynamic secondValue;
            dynamic thirdValue;
            //Code ENDE

            firstValue = "Hier kommen die Zahlen:";
            secondValue = 456;
            thirdValue = 789.4585;

            Console.WriteLine(firstValue);
            Console.WriteLine(secondValue);
            Console.WriteLine(thirdValue);

        }
    }
}