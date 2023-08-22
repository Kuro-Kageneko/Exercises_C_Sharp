using System;
using System.IO;

namespace Exercises_C_Sharp.XX_Enumns
{
    class Exercise_9
    {
        //Sie sollen eine Methode ergänzen, die die Eingabe eines Nutzers analysiert und überprüft, ob sich das Element im Enum "Music" befindet. Sollte dem so sein, gibt sie true zurück, ansonsten false. Sorgen Sie dafür, dass Groß- und Kleinschreibung keine Rolle spielen.
        enum Music { Rock, Blues, Rap, Hiphop, Volksmusik }

        public static void Start()
        {
            while(true)
            {
                Console.WriteLine("Bitte geben Sie eine Musikrichtung ein:");
                if(TestValue(Console.ReadLine() ?? ""))
                    Console.WriteLine("Ja, wir kennen diese Richtung.");
                else
                    Console.WriteLine("Nein, leider kennen wir diese Richtung nicht.");
            }

        }
        static bool TestValue(string userinput)
        {
            //Code Start
            return false;
            //Code Ende
        }
    }
}