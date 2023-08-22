using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Mehrdimensionale_Arrays
{
    class Exercise_7
    {
        //Ein Wissenschaftler hat einen Versuchsaufbau, bei deren Durchführung dieser vier Werte bekommt. Er hat diesen Versuch dreimal gemacht und die Werte in das Array reingeschreiben lassen. 
        static double[,] scienceArray1 = new double[,]
        {
            {2.343, 65.235539, 534.239384, 4934.23534},
            {6.342, 64.231343, 345.645342, 3453.23345},
            {5.234, 56.203923, 432.859384, 3429.348504}
        };
        static double[,] scienceArray2 = new double[,]
        {
            {2.343, 65.235539, 534.239384},
            {6.342, 64.231343, 345.645342},
            {5.234, 56.203923, 432.859384}
        };static double[,] scienceArray3 = new double[,]
        {
            {2.343, 65.235539, 534.239384, 4934.23534, 74.2383},
            {6.342, 64.231343, 345.645342, 3453.23345, 764.239334},
            {5.234, 56.203923, 432.859384, 3429.348504, 532.28394483},
            {6.864, 86.12923, 122.2319384, 1229.34234, 322.28243}
        };
        
        public static void Start()
        {
            ShowValues(WorkArray(scienceArray1));
            ShowValues(WorkArray(scienceArray2));
            ShowValues(WorkArray(scienceArray3));
            
        }
        static void ShowValues(Tuple<double[], double, double> res)
        {
            Console.WriteLine("----------------------");
            for(int i = 0; i < res.Item1.Length; i++)
            {
                Console.WriteLine(i+1 + ". Reihe: " + res.Item1[i]);
            }
            Console.WriteLine("Durschnitte der Reihen: " + res.Item2);
            Console.WriteLine("Durschnitte aller Werte: " + res.Item3);
            Console.WriteLine("----------------------");
        }

        //Ihre Aufgabe ist nun, eine Methode zu schreiben, die beliebig große zweidimensionale Arrays verarbeitet. Die Methode soll folgende Werte zurück geben:
        // - Es soll von allen Reihen der Druchschnitt (arithmetisches Mittel) berechnet werden.
        // - Es soll von den oberen (Durchschnitts-)Werten der Druchschnitt (arithmetisches Mittel) berechnet werden.
        // - Es soll der Druchschnitt (arithmetisches Mittel) von allen Zahlen in dem Array berechnet werden.
        //Gebene Sie daher ein Array mit den Zeilendurchschnitten und die jeweiligen Zahlen zurück.
        static Tuple<double[], double, double> WorkArray(double[,] dArray)
        {
            //Code START
            dynamic d = -1;
            return d;
            //Code ENDE
        }

    }
}