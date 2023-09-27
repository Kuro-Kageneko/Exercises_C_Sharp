using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Exercises_C_Sharp.XX_Lists
{
    class Exercise_13
    {
        public static void Start()
        {
            List<int> intList = new List<int>(){736,452,372,493,482,803,392,473,293,493,462,583,192,483,201,939,483,192,472,493};
           
            //Kontrolle:
            foreach (var element in Meth(intList))
                Console.WriteLine(element);
            
        }

        //Schreiben Sie eine Methode, die die Integerwerte einer übergebenen Liste nach ihren Kehrwert sortiert. Somit würde 432 (Kehrwert: 234) vor der 123 (Kehrwert: 321) kommen.
        static List<int> Meth(List<int> lis)
        {
            /*Code START*/
            ////Selection Sort
            //List<int> sortedList = new();

            ////while (lis.Count > 0) 
            //{ 
            //    int min = lis.Min();
            //    for (int i = 0; i < lis.Count; i++) 
            //    { 
            //        if (TurnValue(lis[i]) < TurnValue(min)) 
            //            Min = lis[i];
            //    }
            //    sortedList.Add(min);
            //        lis.Remove(min);
            //}

            return new List<int>();
            /*Code ENDE*/
        }
    }
}