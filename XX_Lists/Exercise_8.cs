using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Lists
{
    class Exercise_8
    {
        public static void Start()
        {

            List<double> doubleList = new List<double>() {12.2, 34.2,434,2.5,23.134, 54.684, 23.43, 34.683, 23.43, 11.53, 11.5444, 34.2345,  23.3534223};

            //Kontrolle:
            foreach(var element in Meth(doubleList, 4))
                Console.WriteLine(element);
            
        }

        //Schreiben Sie eine Methode, die eine Liste von Doubles bekommt. Zusätzlich soll noch ein Wert übergeben werden, der die neue Größe der Liste angibt. Nehmen Sie solange Werte aus der Liste, bis diese übergebene Anzahl erreicht ist. Streichen Sie dabei immer die kleinsten Werte heraus. Änder Sie nicht die Ordnung der übergebenen Liste:
        static List<double> Meth(List<double> doubleList, int i)
        {
            /*Code START*/

            return doubleList;
            /*Code ENDE*/
        }
    }
}