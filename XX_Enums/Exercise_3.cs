using System;
using System.IO;

namespace Exercises_C_Sharp.XX_Enumns
{
    class Exercise_3
    {
        //Malen Sie unten in der Methode ShowForm die übergebene Form mit Hilfe von Sternchen (*) auf die Konsole.

        enum SpecialForms {Dreieck, Quadrat, Rechteck, Kreis}

        public static void Start()
        {
            ShowForm(SpecialForms.Dreieck);
            ShowForm(SpecialForms.Kreis);
            ShowForm(SpecialForms.Quadrat);
            ShowForm(SpecialForms.Rechteck);
        }
        static void ShowForm(SpecialForms a)
        {
            //Code START

            //Code ENDE
        }
    }
}