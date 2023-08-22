using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Tuple
{
    class Exercise_4
    {
        //Die untere Methode soll eine Eingabe vom Nutzer entgegen nehmen und dann die Werte (Nutzereingabe, Anzahl des Buchstabens, der Buchstabe selbst) als ein Tuple zurückgeben.

        public static void Start()
        {
            var element = Meth();
            Console.WriteLine("Das Wort {0} hat {1} den Buchstaben {2} enthalten.", element.Item1, element.Item2, element.Item3);
        }

        static /*Code START*/dynamic/*Code ENDE*/ Meth()
        {
            string s = Console.ReadLine() ?? string.Empty;
            int res = 0;
            foreach(var element in s)
                if(element == 'a' || element == 'A')
                    res++;
            
            //Code START
            return s + res;
            //Code ENDE
        }

    }
}