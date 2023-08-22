using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Überladung
{
    class Exercise_3
    {
        //Sorgen Sie dafür, dass die unteren Elemente auf der Konsole ausgegeben werden.

        public static void Start()
        {
            Output(12);
            Output("Hallo", 12.5);
            Output(15.15, "Heyho");
            Output(123, "Element", 'G');
        }

        //Code START
        static void Output(dynamic d)
        {
            
        }
        static void Output(dynamic d, dynamic d2)
        {
            
        }
        static void Output(dynamic d, dynamic d2, dynamic d3)
        {
            
        }
        //Code ENDE
    }
}