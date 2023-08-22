using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Enumns
{
    class Exercise_11
    {
        //Zeigen Sie im ersten Bereich zuerst alle möglichen Städte (die im Enum City) an. Sorgen Sie dann dafür, dass die Auswahl des Nutzers in die Liste gespeichert wird.
        enum City { München, Berlin, Köln, Regensburg, Hamburg }

        public static void Start()
        {
            List<City> CityList = new List<City>();

            while(true)
            {
                Console.WriteLine("Hier ist Ihre Auswahl:");
                //Code START

                //Code ENDE
                Console.WriteLine("Bitte geben Sie eine valide Nummer ein:");
                int index = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Clear();
                //Code START

                //Code ENDE
                Console.WriteLine("Ihre Werte:");
                foreach(var element in CityList)
                    Console.WriteLine(element.ToString());
                Console.WriteLine();
            }
        }
    }
}