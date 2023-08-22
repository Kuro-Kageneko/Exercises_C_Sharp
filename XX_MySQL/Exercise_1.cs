using System;
using System.IO;

namespace Exercises_C_Sharp.XX_MySQL
{
    //+---------+----------------+
    //|   ID    |   StringValue  |
    //+---------+----------------+
    class Exercise_1
    {
        public static void Start()
        {
            var connection = CreateDatabase();
            //4. Erstellen Sie ein kleines Menü, in welchem der Anwender Auswählen kann, ob er die Daten angezeigt haben will, ein Datum hinzufügen will, oder ein Datum löschen will. Außerdem soll der Anwender noch nach einem (Sub-)String suchen können. Rufen Sie dann die dafür vorgesehene Methode auf.
            //Code Start

            //Code ENDE

        }

        static dynamic CreateDatabase()
        {
            //1. Stellen Sie im ersten Schritt eine Verbindung zu Ihrer Datenbank her.
            //Code Start

            //Code ENDE

            //2. Erstellen Sie dann die Table "Exercise_MySQL_1", sollte sie nicht vorhanden sein.
            //Code Start

            //Code ENDE

            //3. Geben Sie dann das MySqlConnection-Objekt zurück.
            //Code Start
            return -1;
            //Code ENDE
        }
    
        //Hier soll der Anwender einen neuen String eingeben. Dieser soll dann in die Datenbank gespeichert werden.
        static void AddNewString(dynamic connection)
        {
            //Code Start

            //Code ENDE
        }

        //Hier sollen alle Werte der Datenbank ausgegeben werden.
        static void ShowAllString(dynamic connection)
        {
            //Code Start

            //Code ENDE
        }

        //Hier sollen alle Werte ausgegeben werden, auf die der zu suchende Substring passt.
        static void SearchForStrings(dynamic connection)
        {
            //Code Start

            //Code ENDE
        }
        //Hier soll ein Wert aus der Datenbank gelöscht werden können.
        static void DeleteString(dynamic connection)
        {
            //Code Start

            //Code ENDE
        }
    }
}