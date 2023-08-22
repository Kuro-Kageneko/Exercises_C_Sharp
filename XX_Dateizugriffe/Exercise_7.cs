using System;
using System.IO;

namespace Exercises_C_Sharp.XX_Dateizugriffe
{
    class Exercise_7
    {
        public static void Start()
        {
            //Schreiben Sie ein Menü, in welchem der Anwender auswählen kann, ob er
            // - Die Ordner im Ordner FileSystem anzeigen lassen möchte
            // - Einen Ordner davon löschen möchte
            // - Einen Ordner hinzufügen möchte
            // - Einen Ordner umbenennen möchte
            //Code Start


            //Code ENDE
        }

        //Diese Methode soll alle Ordner mit Unterordner aus FileSystem anzeigen. Achten Sie darauf, das sich die Ordnerstrukturen (auch in der Tiefe) ändern können.
        static void ShowDirectories()
        {
            //Code Start

            //Code ENDE
        }
        //In dieser Methode soll der Anwender die Möglichkeit haben, einen Ordner auszuwählen. Dabei soll der Pfad des Ordners zurück gegeben werden. Als Übergabewert kann man selbst, was bei dem jeweiligen Aufruf angezeigt werden soll.
        static string ChooseDirectory(string command = "Bitte wählen Sie einen Ordner:")
        {
            Console.WriteLine(command);
            //Code Start
            return string.Empty;
            //Code ENDE
        }
        //In dieser Methode soll ein Ordner gelöscht werden. Dieser Methode soll ein Pfad zu dem zu löschenden Ordner übergeben werden.
        static void DeleteDirectory(string path)
        {
            //Code Start

            //Code ENDE
        }
        //In dieser Methode soll ein Ordner umbenannt werden. Dabei soll wieder ein Pfad zu dem umbenennenden Ordner übergeben werden.
        static void RenameDirectory(string path)
        {
            //Code Start

            //Code ENDE
        }

        //In dieser Methode soll der Anwender einen neuen Ordner erstellen können. Dabei wird der Pfad zu dem Ordner, in dem der neue Ordner erstellt werden soll, übergeben werden.
        static void CreateNewDirectory(string path)
        {
            //Code Start

            //Code ENDE
        }
    }
}