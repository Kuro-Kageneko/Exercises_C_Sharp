using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Mehrdimensionale_Arrays
{
    class Exercise_2
    {
        public static void Start()
        {
            //Sorgen Sie dafür, dass auf der Konsole die Zahl 2565 ausgegeben wird.

            //Code START
            dynamic array = -1;
            //Code ENDE

            MakeSomething(array);
        }

        static void MakeSomething(int[,] intArray)
        {
            int i = intArray[1,4] + intArray[0,3] + intArray[5, 1];
            Console.WriteLine(i);
        }
    }
}