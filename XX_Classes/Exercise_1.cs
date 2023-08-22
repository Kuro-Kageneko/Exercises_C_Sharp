using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Classes
{
    class Exercise_1
    {
        public static void Start()
        {
            //Erstellen Sie die Klasse Funny, sodass "Hallo, das ist super!" auf der Konsole ausgegeben wird.
            //Code START
            dynamic funnyClass = -1;
            //Code ENDE

            Console.WriteLine(funnyClass.Value1 + funnyClass.Value2 + funnyClass.Value3 + funnyClass.Value4);
        }
        class Funny
        {
            public string Value1 = "Hallo";
            public string Value2 = ", das";
            public string Value3 = " ist";
            public string Value4 = " super!";

        }
    }
}