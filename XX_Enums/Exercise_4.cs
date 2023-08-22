using System;
using System.IO;

namespace Exercises_C_Sharp.XX_Enumns
{
    class Exercise_4
    {
        //Sorgen Sie dafür, dass "Hihi", "Hi" und "Haidiho" in dieser Reihenfolge unten ausgegeben wird. 
        enum Greetings {Hello, Hi, Hey, Heyho, Hihi, Haha, Haidiho}

        public static void Start()
        {
            int i1 = -1;
            int i2 = -1;
            int i3 = -1;

            //Code Start
            i1 = -1;
            i2 = -1;
            i3 = -1;
            //Code Ende
            
            Greetings g1 = (Greetings)i1;
            Greetings g2 = (Greetings)i2;
            Greetings g3 = (Greetings)i3;


            Console.WriteLine(g1.ToString());
            Console.WriteLine(g2.ToString());
            Console.WriteLine(g3.ToString());
        }
    }
}