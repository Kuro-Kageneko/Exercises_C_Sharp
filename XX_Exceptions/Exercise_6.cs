using System;

namespace Exercises_C_Sharp.XX_Exceptions
{
    class Exercise_6
    {
        public static void Start()
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("Das Ergebnis: " + Method(Console.ReadLine() ?? "", Console.ReadLine() ?? ""));
                }
                catch(ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Leider wurde ein falscher Wert eingegeben: " + ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Leider hatte die Eingabe das falsche Format: " + ex.Message);
                }
                catch(DivideByZeroException ex)
                {
                    Console.WriteLine("Die Eingabe führte zu einer Teilung durch 0: " + ex.Message);
                }
                Console.WriteLine("Bitte versuchen Sie es noch einmal...");
            }
        }
        static int Method(string input1, string input2)
        {
            //Sie bekommen von einer anderen Methode die Eingabe des Nutzers. Sie wollen zwei Zahlen durcheinander teilen. Dabei darf keine Zahl größer als 10.000 sein. Führen Sie die Berechnungen durch und schmeißen Sie jeweils eine Exception, wenn die Bedingungen nicht erfüllt sind. Erläutern Sie in den Exceptions auch das konkrete Problem.

            //Code START

            return -1;
            //CODE ENDE
        }
        
    }
}