using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Enumns
{
    class Exercise_10
    {
        //Sorgen Sie dafür, dass auf der Konsole "Hallo wie geht es Ihnen " ausgegeben wird.
        enum Things { wie, es, Ihnen, Hallo, geht }

        public static void Start()
        {
            List<Things> ThingList = new List<Things>();
            //Code START

            //Code ENDE

            foreach(var element in ThingList)
                Console.Write(element.ToString() + " ");


        }
    }
}