using System;
using System.IO;
using System.Net.Http;

namespace Exercises_C_Sharp.XX_Exceptions
{
    class Exercise_3
    {
        public static void Start()
        {
            //Rufen Sie die Methode ThrowException so lange auf, bis alle Exceptions geflogen und auf der Konsole ausgegeben wurden:
            //Code Start

            //Code ENDE
        }

        static void ThrowException()
        {
            Random rand = new Random();
            switch(rand.Next(0,5))
            {
                case 0:
                    throw new FileNotFoundException("Die Datei konnte nicht gefunden werden!");
                case 1:
                    throw new EntryPointNotFoundException("Leider konnte der Beginn nicht identifiziert werden.");
                case 2:
                    throw new FieldAccessException("Es kann nicht auf die Resource zugegriffen werden.");
                case 3:
                    throw new HttpRequestException("Der Request konnte nicht verarbeitet werden.");
                case 4:
                    throw new Exception("Es ist ein unbekannter Fehler aufgetreten...");
            }
        }
        
    }
}