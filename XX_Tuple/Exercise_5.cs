using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Tuple
{
    class Exercise_5
    {
        //Erstellen Sie eine Liste von Tupeln. Sorgen Sie dafür, dass die Liste mit der unteren Methode gefüllt wird. Geben Sie zum Schluss die Elemente aus.

        //Code START
        static dynamic tupleList = -1;
        //Code ENDE
        public static void Start()
        {
            while(true)
            {
                tupleList.Add(GetStringAndIntFromUser());
                Console.WriteLine("Weiter? Dann Enter...");
                var key = Console.ReadKey();
                if(key.Key != ConsoleKey.Enter)
                    break;
            }

            Console.Clear();

            foreach(var element in tupleList)
            {
                //Code START

                //Code ENDE
            }
        }

        //Diese Methode soll den Nutzer nach einen String und einen int fragen und diese kombination dann in einem Tuple zurück geben. Sorgen Sie dafür, dass der Nutzer valide Werte eingibt.
        static /*Code START*/ dynamic /*Code ENDE*/ GetStringAndIntFromUser()
        {
            //Code START
            return -1;
            //Code ENDE
        }

    }
}