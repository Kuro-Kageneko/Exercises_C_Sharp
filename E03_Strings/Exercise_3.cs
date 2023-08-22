using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.E03_Strings
{
    class Exercise_3
    {
        public static void Start()
        {
            //Fügen Sie die Variable DasWarGemeint in den String ausgabeString anstatt der Stelle {0} ein:
            string DasWarGemeint = "Elefanten";
            string ausgabeString = "{0} sind die größten Landtiere.";

            //Code START
            DasWarGemeint = ausgabeString;
            //Code ENDE

            Console.WriteLine(ausgabeString);
        }
    }
}