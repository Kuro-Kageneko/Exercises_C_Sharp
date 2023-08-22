using System;
using System.IO;

namespace Exercises_C_Sharp.XX_Dateizugriffe
{
    class Exercise_4
    {
        public static void Start()
        {
            //Sorgen Sie dafür, dass die stringList bei jedem Ausführen der Aufgabe geladen wird. Achten Sie darauf zu überprüfen, ob die Datei überhaupt schon existiert.
            List<string> stringList = new List<string>();
            //Code Start


            //Code ENDE
            Console.WriteLine("Bitte geben Sie den nächsten String ein:");
            stringList.Add(Console.ReadLine() ?? "");
            Console.Clear();
            Console.WriteLine("Hier sind alle Elemente:");
            foreach(var element in stringList)
                Console.WriteLine(element);
            
            //Implementieren Sie die Speicherung der Liste
            //Code Start


            //Code ENDE
        }
    }
}