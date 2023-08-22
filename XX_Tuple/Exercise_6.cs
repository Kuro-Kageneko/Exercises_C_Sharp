using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Tuple
{
    class Exercise_6
    {
        //Sorgen Sie dafür, dass 7 und 345 ausgegeben wird:

        //Code START
        static dynamic tupList = -1;
        //Code ENDE
        public static void Start()
        {
            int counter = 0;
            int sum = 0;
            foreach(var element in tupList)
            {
                sum += element.Item1;
                sum += element.Item2;
                sum += element.Item3;
                counter++;
            }
            Console.WriteLine("Die beiden Werte sind {0} und {1}!", counter, sum);
        }

    }
}