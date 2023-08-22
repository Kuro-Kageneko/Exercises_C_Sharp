using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.Sonderaufgaben
{
    class Exercise_2
    {
        //Schreiben Sie ein Programm, in dem man gegen den PC Schiffe versenken spielen kann. Dabei soll der Anwender immer eine Koordinate (z.B. A7) eingeben und dann wird überprüft, ob sich dort ein Treffer befindet. Dabei hat nur der Computer ein 10x10 Feld, auf dem er Zufällig die Schiffe (Schlachtschiff[5 Felder], Kreuzer [4 Felder], Fregatte [3 Felder], Schnellboot[2 Felder]) platziert. Überlegen Sie sich, wie man das Feld auf der Konsole anzeigen könnte.

        //Gedankengang zu dieser Aufgabe:
        //0 -> Wasser -> Ausgabe: O
        //1 -> Schiff -> Ausgabe: O  (Tipp: Kann auch zum Debuggen geändert werden)
        //2 -> Getroffenes Wasser -> Ausgabe: $
        //3 -> Getroffenes Schiff -> Ausgabe: X

        //Hierbei handelt es sich um das Spielfeld (Standardmäßig sind alle Werte 0)
        static int[,] GameField = new int[10,10];

        public static void Start()
        {
            
        }

        //Diese Methode setzt die Schiffe in das Spielfeld
        static void SetShips()
        {

        }

        //Diese Methode frägt, prüft und wandelt die Eingabe des Nutzers um. Dabei wird die konkrete Koordinate zurück gegeben.
        static Tuple<int,int> GetUserinput()
        {
            return new Tuple<int, int>(-1,-1);
        }

        //Diese Methode verarbeitet die Eingabe des Nutzers.
        static void HandleUserInput(Tuple<int,int> userinput)
        {

        }


        //Diese Methode zeigt das Spielfeld mit allen weiteren Anzeigeelementen an.
        static void ShowField()
        {

        }
    }
}