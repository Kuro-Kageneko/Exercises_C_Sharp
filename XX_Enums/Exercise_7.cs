using System;
using System.IO;

namespace Exercises_C_Sharp.XX_Enumns
{
    class Exercise_7
    {
        //Schreiben Sie die untere Methode und deren Aufruf um, sodass ein Enum als Übergabewert verwendet wird. Erstellen Sie dafür ein neues Enum 'Animals'.

        public static void Start()
        {
            PrintAnimal("Ente");
            PrintAnimal("Ente");
            PrintAnimal("Hund");
            PrintAnimal("Pferd");
        }
        static void PrintAnimal(string a)
        {
            if(a == "Ente")
                Console.WriteLine("Quark");
            else if(a == "Kuh")
                Console.WriteLine("Muh");
            else if(a == "Hund")
                Console.WriteLine("Wuff");
            else if(a == "Katze")
                Console.WriteLine("Miau");
            else if(a == "Pferd")
                Console.WriteLine("Wieha");
        }
    }
}