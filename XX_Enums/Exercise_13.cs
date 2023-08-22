using System;
using System.IO;

namespace Exercises_C_Sharp.XX_Enumns
{
    class Exercise_13
    {
        //Hier ist das Enum definiert, in denen die Spielelemente drinnen stehen
        enum GameObjects { Schere, Stein, Papier }

        public static void Start()
        {
            int playerPoints = 0;
            int computerPoints = 0;

            Console.WriteLine("Hallo und Herzlich Willkommen zu Schere, Stein Papier!");
            string message = string.Empty;
            while(TestGameEnding(playerPoints, computerPoints))
            {
                bool? winner = FindWinner(UserInput(), ComputerInput());
                if(winner == true)
                {
                    playerPoints++;
                    message = "Glückwunsch! Ein Punkt für Sie!";
                }
                else if(winner == false)
                {
                    computerPoints++;
                    message = "Schade... Ein Punkt für den Computer...";
                }
                else
                    message = "UNENTSCHIEDEN.....";

                Console.Clear();
                Console.WriteLine("Spieler: {0}  Computer: {1}\n{2}", playerPoints,     computerPoints, message);
            }

            Console.Clear();
            Console.WriteLine("Das Spiel ist aus. Hier ist Ihr Ergebnis:");
            Console.WriteLine("Punkte des Spielers: {0}\nPunkte der Computers: {1}", playerPoints, computerPoints);
            if(playerPoints > computerPoints)
                Console.WriteLine("SIE HABEN GEWONNEN! SIE SIND DER MEISTER IN DIESEM SPIEL!");
            else if (playerPoints < computerPoints)
                Console.WriteLine("Sie haben verloren. Sie sind leider sehr schlecht in dem Spiel. Bitte hören Sie auf, es zu spielen...");
            else
                Console.WriteLine("!!!Unentschieden!!!");
            
        }

        //Diese Methode frägt den Nutzer nach seiner Eingabe und gibt diese zurück
        static GameObjects UserInput()
        {
            Console.WriteLine("Hier sind Ihre Auswahlelemente:");
            //Geben Sie hier die Elemente in GameObjects aus, mit jeweils einer Zahl zur Auswahl da davor.

            //Code START

            //Code ENDE

            Console.WriteLine("Bitte geben Sie die Nummer zu der Eingabe ein:");
            //Nehmen Sie hier eine Eingabe vom Nutzer entgegen. Überprüfen Sie, ob dieser eine valide Zahl eingegeben hat. Wandeln Sie die Zahl dann in ein GameObjects-Objekt um und geben Sie es zurück.

            //Code START

            return GameObjects.Papier;
            //Code ENDE
        }

        //Diese Methode gibt einen zufällig erstellten Wert zurück
        static Random rand = new Random();
        static GameObjects ComputerInput()
        {
            //Erstellen Sie hier eine valide Zufallszahl und wandeln Sie diese in ein GameObjects um. Geben Sie dann diesen Wert zurück.

            //Code START

            return GameObjects.Papier;
            //Code ENDE
        }

        //Diese Methode gibt true zurück, wenn der Erste gewonnen hat und false, wenn der Zweite (B) 
        static bool? FindWinner(GameObjects A, GameObjects B)
        {
            //Code START
            return false;
            //Code ENDE
        }
        //Diese Methode überprüft, ob das Spiel zu Ende ist.
        static bool TestGameEnding(int A, int B)
        {
            //Überlegen Sie sich selbst, wann das Spiel enden soll.
            //Code START
            return true;
            //Code ENDE
        }
    }
}