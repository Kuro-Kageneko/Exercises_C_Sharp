using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Tuple
{
    class Exercise_1
    {
        //Übergeben Sie an Stelle zweier Übergabeparameter ein Tuple mit diesen Werten:

        public static void Start()
        {
            //Code START
            Meth("Hans", 35);
            //Code ENDE
        }

        static void Meth(/*CODE START*/string name, int age/*CODE ENDE*/)
        {
            Console.WriteLine("{0} ist {1} Jahre alt.", name, age);
        }
    }
}