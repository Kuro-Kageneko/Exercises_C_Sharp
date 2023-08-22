using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Mehrdimensionale_Arrays
{
    class Exercise_4
    {
        
        public static void Start()
        {
            int[,] intArray = new int[,]{{ 1, 2, 3 },{ 3, 4, 5 },{ 5, 6, 6 },{ 7, 8, 9 }};
            int[,] intArray2 = new int[,]{{ 45,12,18,89,685 },{ 1,258,333,95,667},{ 685,19,5,1,0 },{ 4888,555,222,336,96 }};
            
            ShowArray(ReverseArray(intArray));
            ShowArray(ReverseArray(intArray2));

        }

        //Schreiben Sie eine Methode, die die Zeilen und die Spalten eines 2-dimensionalen Arrays vertauscht.
        static int[,] ReverseArray(int[,] arr)
        {
            //Code START
            return new int[0,0];
            //Code ENDE
        }

        //Schreiben Sie eine Methode, die ein 2-dimensionales Array ausgibt.
        static void ShowArray(int[,] arr)
        {
            //Code START
            
            //Code ENDE
        }

    }
}