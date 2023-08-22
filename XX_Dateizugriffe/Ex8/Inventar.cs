using System;
using System.IO;

namespace Exercises_C_Sharp.XX_Dateizugriffe
{
    class Inventar
    {
        public Inventar(string companyName)
        {
            if(string.IsNullOrWhiteSpace(companyName))
                throw new ArgumentNullException("Der übergeben Name für die Fima ist NULL oder leer. Dies ist nicht erlaubt.");
            CompanyName = companyName;
        }

        public string CompanyName;

        public List<string> Notes = new List<string>();

        List<(Thing obj, int amount)> objectList = new List<(Thing obj, int amount)>();

        //Diese Methode soll den Gesamtpreis aller Elemente zurück geben.
        public decimal ReturnPriceSum()
        {
            //Code START
            return decimal.Zero;
            //Code ENDE
        }
    }
}