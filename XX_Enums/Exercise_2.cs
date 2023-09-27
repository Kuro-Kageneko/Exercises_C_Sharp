using System;
using System.IO;

namespace Exercises_C_Sharp.XX_Enumns
{
    class Exercise_2
    {
        //Gehen Sie zur Stelle 3x5 und danach zur Stelle -2x1. Nutzen Sie dafür nur die Aufrufe der Going-Methode in der Start-Methode.
        enum Direction {North, South, West, East}

        public static void Start()
        {
            //Code Start
           

            //Code Ende
        }
        static int x = 1;
        static int y = 6;
        static void Going(Direction a)
        {
            if(a == Direction.North)
                x++;
            else if(a == Direction.South)
                x--;
            else if(a == Direction.West)
                y--;
            else if(a == Direction.East)
                y++;

            Console.WriteLine("Ihre aktuelle Position ist {0}x{1}", x, y);
        }
    }
}