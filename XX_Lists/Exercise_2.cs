using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Lists
{
    class Exercise_2
    {
        public static void Start()
        {
            //Erstellen Sie eine Liste, in die unten die drei Werte reingeschrieben werden:

            /*Code START*/
            List<dynamic> superList = new List<dynamic>();

            /*Code ENDE*/

            superList.Add("Hallo");
            superList.Add("Hi");
            superList.Insert(0, "Hey");

            //Kontrolle:
            foreach(var element in superList)
                Console.WriteLine(element);
            
        }
    }
}