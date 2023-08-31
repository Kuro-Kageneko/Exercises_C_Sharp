namespace Exercises_C_Sharp.XX_Methods
{
    class Exercise_4
    {
        public static void Start()
        {
            //2. Rufen Sie die unten erstellte Methode auf und geben Sie den Inhalt auf der Konsole aus.
            //Code START
            Console.WriteLine(Begrüßung());
            //Code ENDE
        }
        //Erstellen Sie eine Methode, die bei jedem Aufruf zufällig eine von 10 Begrüßungen zurück gibt.
        //Code START
        static string Begrüßung()
        {
            Random rand = new Random();
            string[] beg = new string[] {"Hi!", "Hey!", "Guten Tag!", "Herzlich Willkommen!", "Willkommen!", "Guten Morgen!", "Hallo!", "Huhu!", "Servus!", "NÖ"};
            return beg[rand.Next(0, beg.Length)];
        }
        //Code ENDE

    }
}