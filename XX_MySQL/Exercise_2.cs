using System;
using System.IO;

namespace Exercises_C_Sharp.XX_MySQL
{
    // Tabelle 'Human'
    //+---------+--------------+-----------+-----------+
    //|   ID    |   GivenName  |  Surname  |  Birthday |
    //+---------+--------------+-----------+-----------+

    // Tabelle 'Disease'
    // +------+-----------+----------+-----------+---
    // |  ID  |  HumanID  | Disease  | Duration  | 
    // +------+-----------+----------+-----------+---
    //
    // ----+------------------+------------+-----------------+
    //     | FirstAppearance  | TotalCost  | DrHouseEpisode  |
    // ----+------------------+------------+-----------------+
    class Exercise_2
    {
        //Ihre Aufgabe ist es, eine Patientenverwaltung zu schreiben, in der man neue Patienten hinzufügen kann. Diesen Patienten kann man dann beliebig viele Krankheiten hinzufügen. Sie sollen folgende Dinge in die Software implementieren:
        // - Erstellen eines Patienten (natürlich mit der Abspeicherung in die Datenbank)
        // - Anzeigen aller Patienten
        // - Auswahl eines Patienten und hinzufügen einer Krankheit (diese besteht aus dem Namen der Krankheit, der Krankheitsdauer, das erste Auftreten, die Gesamtkosten und der Dr. Hose-Folge, in der diese auftritt)
        // - Suchen einer Krankheit und/oder eines Patienten mit der Eingabe eines Strings
        // - Ausgabe alles Krankheiten eines Patienten
        public static void Start()
        {
            //Code Start

            //Code ENDE

        }

        static dynamic CreateDatabase()
        {
            //1. Stellen Sie im ersten Schritt eine Verbindung zu Ihrer Datenbank her.
            //Code Start

            //Code ENDE

            //2. Erstellen Sie dann die beiden Tabellen, wie sie oben beschrieben sind, sollten sie nicht schon vorhanden sein.
            //Code Start

            //Code ENDE

            //3. Geben Sie dann das MySqlConnection-Objekt zurück.
            //Code Start
            return -1;
            //Code ENDE
        }
      

        //Code Start

        //Code ENDE
    }
}