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
            for(int i = 0; i < 10; i++)
            {
                /*Code START*/
                intList.Add(1);
                intList.Add(2);
                intList.Add(3);
                intList.Add(4);
                intList.Add(5);
                intList.Add(6);
                intList.Add(7);
                intList.Add(8);
                intList.Add(9);
                intList.Add(10);
                intList.Add(11);
                intList.Add(12);
                intList.Add(13);
                intList.Add(14);
                intList.Add(15);
                intList.Add(16);
                intList.Add(17);
                intList.Add(18);
                intList.Add(19);

                Console.WriteLine(intList);
                /*Code ENDE*/
            }

            //Kontrolle:
            foreach (var element in intList)
            {
                Console.WriteLine(element);
            }
        }
    }
}