using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.E05_Arrays
{
    class Exercise_6
    {
        public static void Start()
        {
            //Erstellen Sie ein Array, sodass unten eine wahre Aussage steht:
            //Code START
            dynamic arr = -1;
            //Code ENDE

            arr[2] = 12;
            arr[0] = 32;

            int i = arr[0] + arr[1] + arr[2];

            Console.WriteLine("Teilt man Zahl {0} durch 57 kommt 1 heraus.", i);
            
        }
    }
}