using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Mehrdimensionale_Arrays
{
    class Exercise_6
    {
        static string[,] stringArray = new string[3,3];
        
        public static void Start()
        {
            //Lassen Sie den Nutzer das zweidimensionale Array 'stringArray' mit (9, jeweils eine pro Feld) Eingaben befüllen

            //Code START

            //Code ENDE

            //Überprüfung:
            foreach(var element in stringArray)
                Console.Write(element + " - ");
        }

    }
}