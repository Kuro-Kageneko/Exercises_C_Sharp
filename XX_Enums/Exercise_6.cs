using System;
using System.IO;

namespace Exercises_C_Sharp.XX_Enumns
{
    class Exercise_6
    {
        //Auf der Konsole soll "Cloe", "Flo" und "Adam" ausgegeben werden.
        enum GivenName { Adam = 25, Berta = 83, Cloe = 29, Dagmar = 16, Erik = 72, Flo = 57, Gerda = 73}

        public static void Start()
        {
            int res = (int)GivenName.Gerda;
            
            //Code START
            res += -1;
            //Code ENDE

            for(int i = 0; i < 4; i++)
                res += i;
            res -= 3;
            for(int i = 2; i > 0; i--)
                res -= i;
            
            Console.WriteLine(((GivenName)res).ToString());
            //Code START
            res += -1;
            //Code ENDE
            Console.WriteLine(((GivenName)res).ToString());
            //Code START
            res += -1;
            //Code ENDE
            Console.WriteLine(((GivenName)res).ToString());

        }
    }
}