using System;
using System.IO;
using System.Net.Http;

namespace Exercises_C_Sharp.XX_Exceptions
{
    class Exercise_8
    {
        public static void Start()
        {
            //Rufen Sie die Methode Meth auf und fangen Sie alle Fehler mit einem catch-Block auf. Geben Sie dann die Exception und deren Nachricht auf der Konsole aus.
            
            //Code START

            //Code ENDE
        }

        static void Meth()
        {
            Random rand = new Random();
            switch(rand.Next(0,6))
            {
                case 0:
                    throw new FormatException("Schlechtes Format...");
                case 1:
                    throw new FileNotFoundException("Datei ist leider nicht vorhanden...");
                case 2:
                    throw new Exception("Keine Ahnung was hier passiert sein könnte...");
                case 3:
                    throw new HttpRequestException("Bei dem Protokoll ist leider ein Fehler aufgetreten. Es tut uns Leid :/", new Exception());
                case 4:
                    throw new IndexOutOfRangeException("Leider befand sich der Index außerhalb der Größe des Arrays.");
                case 5:
                    throw new UriFormatException("Leider ist das Format des Pfades falsch...");
            }
        }
        
    }
}