using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Überladung
{
    class Exercise_4
    {
        //Sie sollen die Methode ConvertToInt so schreiben, dass mit allen drei Aufrufen der richtige Integer-Wert zurück gegeben wird. Verwenden Sie dafür Überladung und kein dynamic.

        public static void Start()
        {
            Console.WriteLine(ConvertToInt('7'));
            Console.WriteLine(ConvertToInt("Drei"));
            Console.WriteLine(ConvertToInt("i"));
        }

        //Code START
        static int ConvertToInt(dynamic d)
        {
            return -1;
        }
        //Code ENDE
    }
}