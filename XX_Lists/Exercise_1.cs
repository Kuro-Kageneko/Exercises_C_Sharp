using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Lists
{
    class Exercise_1
    {
        public static void Start()
        {
            //Sorgen Sie dafür, dass in der Liste alle Zahlen von 1 bis 10 stehen:
            List<int> intList = new List<int>();
            for(int i = 0; i <= 10; i++)
            {
                /*Code START*/
                intList.Add(i+1);

                Console.WriteLine(intList[i]);
                /*Code ENDE*/
            }

            //Kontrolle:
            foreach(var element in intList)
            {
                Console.WriteLine(element);
            }
        }
    }
}