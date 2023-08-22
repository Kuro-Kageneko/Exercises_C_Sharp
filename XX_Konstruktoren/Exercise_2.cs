using System;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Konstruktoren
{
    class Exercise_2
    {
        public static void Start()
        {
            //Im Kontruktor von der Klasse List ist es möglich, eine andere Liste zu übergeben, damit diese übernommen wird. Erstellen Sie eine neue Liste newList und übergeben Sie direkt im Konstruktor die stringList.
            List<string> stringList = new List<string>() { "Hallo", "Hi", "Hey" };
            
            //Code Start
            dynamic newList = 1;
            //Code ENDE

            foreach(var element in newList)
                Console.WriteLine(element);
        }
    }
}