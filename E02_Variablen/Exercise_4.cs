using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.E02_Variablen
{
    class Exercise_4
    {
        public static void Start()
        {
            string val1 = "Das ";
            string val2 = " cool!";
            string val3 = "ist ";

            //Geben Sie den Satz "Das ist cool!" auf der Konsole aus. Verwenden Sie ausschließlich Variablen:
            //Code Start
            val2 = val1;
            val3 = val2;
            val1 = val3;
            //Code Ende


        }
    }
}