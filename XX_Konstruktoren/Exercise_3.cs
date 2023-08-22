using System;

namespace Exercises_C_Sharp.XX_Konstruktoren
{
    class Exercise_3
    {
        public static void Start()
        {
            //Erstellen Sie ein Objekt der Klasse SomeThingElse. Sorgen Sie dafür, dass auf der Konsole die Zahl 343 ausgegeben wird.
            //Code Start
            dynamic obj = 1;
            //Code ENDE
            Console.WriteLine(obj.Number * obj.Number * obj.Number);
        }

        class SomeThingElse
        {
            public int Number;
            public SomeThingElse(int i)
            {
                Number = i;
            }
        }
    }
}