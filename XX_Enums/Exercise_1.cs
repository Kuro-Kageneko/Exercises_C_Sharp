using System;
using System.IO;

namespace Exercises_C_Sharp.XX_Enumns
{
    class Exercise_1
    {
        //Ändern Sie die Hintergrundfarbe der Konsole auf weiß und die Farbe der Schrift auf lila. Nutzen Sie dafür die unten definierte Methode.
        public static void Start()
        {
            //Code Start
            PrintAnimal(ConsoleColor.White, ConsoleColor.Magenta);

            //Code ENDE
        }
        static void PrintAnimal(ConsoleColor back, ConsoleColor front)
        {
            Console.BackgroundColor = back;
            Console.ForegroundColor = front;
            Console.WriteLine("Farbe geändert!!!");
        }
    }
}