using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Lists
{
    class Exercise_7
    {
        public static void Start()
        {
            //Schreiben Sie zwei Methoden. Die erste soll alle geraden Zahlen aus der Liste entfernen, die zweite alle ungeraden Zahlen:

            List<int> intListOdd = new List<int>() {14,2,12,32,51,31,53,12,34,34,2,45,45,23,62,72,25,40};
            List<int> intListEven = new List<int>() {14,2,12,32,51,31,53,12,34,34,2,45,45,23,62,72,25,40};

            //Kontrolle:
            foreach(var element in RemoveOdds(intListEven))
                Console.Write(element + " - ");
            Console.WriteLine();
            foreach(var element in RemoveEvens(intListOdd))
                Console.Write(element + " - ");
            
        }
        static List<int> RemoveOdds(List<int> intList)
        {
            /*Code START*/

            return intList;
            /*Code ENDE*/
        }
        static List<int> RemoveEvens(List<int> intList)
        {
            /*Code START*/

            return intList;
            /*Code ENDE*/
        }
    }
}