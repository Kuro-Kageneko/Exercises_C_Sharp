using System;
using System.IO;

namespace Exercises_C_Sharp.XX_Enumns
{
    class Exercise_8
    {
        //Sorgen Sie dafür, dass die Methode GiveAValue immer ein zufälliges Element des Typs Things zurück gibt. Es soll dann zum Schluss 20 mal ein zufälliges Things-Element ausgegeben werden.
        enum Things { Haus, Garten, Dach, Fenster, Schaukel, Terasse, Balkon, Türe }

        public static void Start()
        {
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine(GiveAValue().ToString());
            }
        }
        static Things GiveAValue()
        {
            Random rand = new Random();

            //Code Start
            return Things.Balkon;
            //Code Ende
        }
    }
}