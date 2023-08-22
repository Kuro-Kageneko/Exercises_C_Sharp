using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Lists
{
    class Exercise_12
    {
        public static void Start()
        {
            List<string> stringList = new List<string>();
            stringList.Add(Console.ReadLine() ?? "");
            stringList.Add(Console.ReadLine() ?? "");
            stringList.Add(Console.ReadLine() ?? "");
            stringList.Add(Console.ReadLine() ?? "");
            stringList.Add(Console.ReadLine() ?? "");
            //Kontrolle:
            Console.WriteLine();
            foreach (var element in Meth(stringList, 'a'))
                Console.WriteLine(element);
            
        }

        //In der folgenden Methode bekommen Sie eine Liste von Strings und einen Character. Sie sollen nun aus der Liste alle Wörter entfernen, die diesen Character beinhalten.
        static List<string> Meth(List<string> lis, char c)
        {
            /*Code START*/

            return new List<string>();
            /*Code ENDE*/
        }
    }
}