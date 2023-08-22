using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Überladung
{
    class Exercise_5
    {
        //Beim Aufruf der Methode Analyze soll man einen String, einen Integer, einen Character oder einen Double übergeben können. Dabei soll die Methode jeweils den Typ der Variablen auf die Konsole schreiben. Zusätzlich soll zu einem String die Länge ausgegeben werden, zu einem Integer die Anzahl der Stellen, zu einem Character die dezimale Darstellung und zu einem Double die Anzahl der Nachkommastellen. Nutzen Sie dafür Überladungen der Mehtode Analyze.
        
        //Ausgabebeispiel:
        //Das übergebene Element ist ein Double. Dieser besitzt 3 Nachkommastellen.
        //Das übergebene Element ist ein Character mit der dezimalen Codierung 83.
        //Das übergebene Element ist ein String mit der Länge 10.
        //usw....

        public static void Start()
        {
            Analyze(44.343);
            Analyze('S');
            Analyze("Teststring");
            Analyze(390);
            Analyze(33.0);
            Analyze(1209);
            Analyze('c');
        }

        //Code START
        static void Analyze(dynamic d)
        {

        }
        //Code ENDE
    }
}