using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Überladung
{
    class Exercise_1
    {
        public static void Start()
        {
            //Sorgen Sie dafür, dass die Methode Output ausgibt, ob es sich um eine Zahl, oder um einen String handelt und diesen dann ausgibt. Nutzen Sie dafür Überladung der Methoden.
            Output(12);
            Output("Hallo");
        }
        //Code START
        static void Output(dynamic d)
        {
            
        }
        //Code ENDE
    }
}