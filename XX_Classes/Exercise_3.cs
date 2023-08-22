using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Classes
{
    class Exercise_3
    {
        public static void Start()
        {
            //Erstellen Sie eine Liste von Ausweisen (IDs)
            //Code START

            //Code ENDE

            //Der Nutzer soll nun beliebig viele Ausweise erstellen können. Achten Sie darauf, dass der Nutzer mindestens 5 Ausweise erstellen muss. Verwenden Sie die Methode UserCreateID(). Speichern Sie die Ausweise in die oben erstellte Liste, nach dem Geburtsdatum sortiert.
            //Code START

            //Code ENDE

            //Geben Sie zum Schluss alle Ausweise aus. Nutzen Sie dafür die Methode ShowIDs().
            //Code Start
            //ShowIDs();
            //Code ENDE
        }

        //Geben Sie in diser Methode alle Ausweise optisch ansprechend auf der Konsole aus.
        static void ShowIDs(List<ID> idList)
        {

        }

        //Sorgen Sie dafür, dass der Anwender hier einen validen Ausweis erstellen kann. Setzen Sie die IDNumber selber. Achten Sie darauf, dass eine IDNumber mindesten 5 Zahlen beinhaltet und eindeutig sein muss.
        static ID UserCreateID()
        {
            //Code START
            return new ID();
            //Code ENDE
        }


    }

    class ID
    {
        public int IDNumber = -1;
        public string? Prename = null;
        public string? Givenname = null;
        public DateTime Birth = DateTime.MinValue;
    }
}