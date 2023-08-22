using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Lists
{
    class Exercise_10
    {
        public static void Start()
        {
            //Kontrolle:
            foreach (var element in Meth())
                Console.WriteLine(element);
            
        }

        //Schreiben Sie eine Methode, die eine beliebige Anzahl von String-Eingaben vom Nutzer entgegen nimmt. Die Methode soll dann eine Liste dieser Eingaben zurück geben.
        static List<string> Meth()
        {
            /*Code START*/

            return new List<string>();
            /*Code ENDE*/
        }
    }
}