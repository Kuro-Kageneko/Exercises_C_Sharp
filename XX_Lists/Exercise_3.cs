using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Lists
{
    class Exercise_3
    {
        public static void Start()
        {
            //Sorgen Sie dafür, dass unten aus der Liste "Hallo, wie geht's?" ausgegeben wird:

            List<string> stringList = new List<string>();
            stringList.Add(", wie");
            stringList.Add("'s?");
            
            /*Code START*/


            /*Code ENDE*/


            //Kontrolle:
            foreach(var element in stringList)
                Console.Write(element);
        }
    }
}