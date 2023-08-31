using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.E01_Einleitung
{
    class Exercise_2
    {
        public static void Start()
        {
            //Geben Sie diese nacheinander die Lösungen folgender Gleichungen jeweils in eigener Zeile in der Konsole aus:
            //24 + 14 – 34 / 12 * 2 % 4
            //23847 + 3333 / 34 * 22 – 12 + 2343234 % 6
            //123.34 / 2344.3 – 12035.55 / 4.9 * 123.2
            //948475.23423 * 7 – 23433.833 % 22.66 + 34.3 * 4
            //2343 – 3434.2 * 333.33 – 3333.88 / 77777.1 + 12.33 % 0.3336

            //Code START
            Console.WriteLine(24 + 14 - 34 / 12 * 2 % 4);
            Console.WriteLine(23847 + 3333 / 34 * 22 - 12 + 2343234 % 6);
            Console.WriteLine(123.34 / 2344.3 - 12035.55 / 4.9 * 123.2);
            Console.WriteLine(948475.23423 * 7 - 23433.833 % 22.66 + 34.3 * 4);
            Console.WriteLine(2343 - 3434.2 * 333.33 - 3333.88 / 77777.1 + 12.33 % 0.3336);
            //Code ENDE
        }
    }
}