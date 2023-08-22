using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Mehrdimensionale_Arrays
{
    class Exercise_5
    {
        
        public static void Start()
        {
            int[,] intArray1 = new int[,]{{ 45,12,18,89,685 },{ 1,258,333,95,667},{ 685,19,5,1,0 },{ 4888,555,222,336,96 }};
            int[,] intArray2 = new int[,]{{ 45,12,18,89,685 },{ 1,258,333,95,667},{ 685,19,5,1,0 },{ 4888,555,222,336,96 }};
            
            //Überprüfung:
            foreach(var element in RemoveEven(intArray1))
                Console.Write(element + " - ");
            Console.WriteLine("\n");
            foreach(var element in RemoveOdd(intArray2))
                Console.Write(element + " - ");
            

        }
        //Schreiben Sie eine Methode, die alle geraden Zahlen aus einem 2-dimensionalen Array durch -1 ersetzt:
        static int[,] RemoveEven(int[,] arr)
        {
            //Code START
            return new int[0,0];
            //Code ENDE
        }

        //Schreiben Sie eine Methode, die alle ungeraden Zahlen aus einem 2-dimensionalen Array durch -1 ersetzt:
        static int[,] RemoveOdd(int[,] arr)
        {
            //Code START
            return new int[0,0];
            //Code ENDE
        }
    }
}