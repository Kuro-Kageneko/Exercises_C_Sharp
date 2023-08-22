using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Enumns
{
    class Exercise_12
    {
        //Hierbei handelt es sich um ein Spiel, welches der Spieler erraten muss, welchen Wert der Computer wählt. Dabei muss der Anwender eine Zahl auswählen, die eine Richtung (Direction) repräsentiert. Schreiben Sie die Methode, die beide Eingaben (die des Anwenders und die des Computers) miteinander vergleicht und die Anzahl der Treffer zurück gibt.
        enum Direction { Vorne, Hinten, Links, Rechts, Oben, Unten }

        public static void Start()
        {
            List<Direction> PlayerList = new List<Direction>();
            List<Direction> ComputerList = new List<Direction>();
            Random rand = new Random();
            int k = 0;
            foreach(var element in Enum.GetValues(typeof(Direction)))
            {
                Console.WriteLine(k + ".) " + element.ToString());
                k++;
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Bitte geben Sie eine Zahl zwischen 0 und 5 ein:");
                PlayerList.Add((Direction)Convert.ToInt32(Console.ReadLine()));
                ComputerList.Add((Direction)(rand.Next() % 6));
            }
            int res = TestListMatches(PlayerList, ComputerList);
            if(res < 5)
                Console.WriteLine("Leider haben Sie nur schäbige {0} von 10 erraten :(", res);
            else
                Console.WriteLine("Herzlichen Glückwunsch! Sie konnten fantastische {0} von 10 erraten!", res);
        }

        static int TestListMatches(List<Direction> FirstList, List<Direction> SecondList)
        {
            //Code START
            return -1;
            //Code ENDE
        }
    }
}