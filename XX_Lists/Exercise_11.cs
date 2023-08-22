using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Lists
{
    class Exercise_11
    {
        public static void Start()
        {
            //Kontrolle:
            foreach (var element in Meth())
                Console.WriteLine(element);
            
        }

        //Schreiben Sie eine Methode, die eine beliebige Anzahl von Integer-Eingaben vom Nutzer entgegen nimmt. Die Methode soll dann eine Liste dieser Eingaben zurück geben. Falsche Eingaben (Strings, die nicht umgewandelt werden können) sollen ignoriert werden.
        static List<int> Meth()
        {
            /*Code START*/

            return new List<int>();
            /*Code ENDE*/
        }
    }
}