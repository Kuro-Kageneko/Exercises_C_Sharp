using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Classes
{
    class Exercise_4
    {
        //Erstellen Sie eine statische Liste, wo man Elemente vom Typ Equipment reinspeichern kann
        //Code Start
        static dynamic EList = 1;
        //Code ENDE
        public static void Start()
        {
            string userinput;
            do
            {
                EList.Add(MakeEquipment());
                Console.WriteLine("Wollen Sie die weitere Eingabe abbrechen? (y -> JA, ABBRECHEN)");
                userinput = Console.ReadLine() ?? "";
            }
            while(userinput.Trim().ToUpper() != "Y");
            PrintEquipment();
        }

        //Lassen Sie hier einen Nutzer Ausrüstung erstellen (Eingabe einer ID, eines Namens und einer Anzahl) und gegen Sie diese zurück.
        static Equipment? MakeEquipment()
        {
            //Code Start
            return null;
            //Code ENDE
        }

        //Geben Sie hier die Liste mit Equipment optisch ansprechend aus.
        static void PrintEquipment()
        {
            //Code Start
            
            //Code ENDE
        }
    }

    class Equipment
    {
        public int ID = -1;
        public string? Name = null;
        public int Amount = -1;
    }
}