using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.E03_Strings
{
    class Exercise_10
    {
        public static void Start()
        {
            //Sorgen Sie dafür, dass auf der Konsole
            //"Das Erste kommt zuerst...
            //...und das Zweite kommt zuletzt."
            //ausgegeben wird


            //Code START
            string s1 = "";
            string s2 = "";
            string s3 = "";
            string s4 = "";
            //Code ENDE
            string s = string.Format("{0} Erste kommt zu{1}{2}das Zweite{3}zuletzt.", s2, s1, s4, s3);

            Console.WriteLine(s);
        }
    }
}