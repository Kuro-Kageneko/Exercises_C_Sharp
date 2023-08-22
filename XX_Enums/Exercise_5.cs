using System;
using System.IO;

namespace Exercises_C_Sharp.XX_Enumns
{
    class Exercise_5
    {
        //Sorgen Sie dafür, dass die Zahl 325 ausgegeben wird.

        //Code START
        enum Something{ Dies, ist, ein, Enum, mit, einem, Wert }
        //Code ENDE
        
        public static void Start()
        {
            int val = (int)Something.einem + (int)Something.Wert + (int)Something.ist + (int)Something.ein;
            Console.WriteLine(val);
        }
    }
}