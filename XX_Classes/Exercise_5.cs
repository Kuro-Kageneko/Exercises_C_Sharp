using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Classes
{
    class Exercise_5
    {
        public static void Start()
        {
            //Erstellen Sie hier eine Instanz ihrer Klasse
            //Code START
            dynamic obj = 1;
            //Code ENDE

            obj.StringList = new List<string>{"Hallo", "Hi", "Hey", "Hohoho", "Ciao", "Byebye"};
            obj.Position = 1;

            Console.WriteLine(GetCharsFromPosition(obj));
        }
        static string GetCharsFromPosition(dynamic d)
        {
            string tempString = string.Empty;
            foreach(var element in d.StringList)
            {
                tempString += element.Length > d.Position ? element[d.Position] : "";
            }
            return tempString;
        }
    }
    //Schreiben Sie eine Klasse, die oben zu der Aufgabe passt. Ändern Sie dann auch alle dynamics oben ab.
    //Code START

    //Code ENDE
}