namespace Exercises_C_Sharp.XX_Methods
{
    class Exercise_5
    {
        public static void Start()
        {
            //2. Fragen Sie den Nutzer mit Hilfe der unten erstellten Methode nach einer Primzahl. Fragen Sie diesen dann, ob er noch eine weitere Primzahl eingeben möchte. Wiederholen Sie den Vorgang, bis der Nutzer keine Zahl mehr eingeben möchte. Multiplizieren Sie dann alle Eingaben miteinander und geben das Ergebnis aus.
            //Code START
            int res = 1;    
            while (true) 
            {
                Console.WriteLine("Bitte Primzahl eingeben:");
                //res *= primzahl();
            }
            //Code ENDE
        }
        //Schreiben Sie eine Methode, bei der der Nutzer eine Primzahl (Zahl, die nur durch 1 und sich selbst teilbar ist) eingeben soll. Geben Sie diese Zahl zurück. Wenn der Nutzer eine falsche Eingabe tätigt, dann soll der Nutzer darüber informiert und die Abfrage wiederholt werden.
        //Code START
        static void primzahl() 
        {
            while (true)
            {
                int ui = Convert.ToInt32(Console.ReadLine());

                bool b = true;
                for (int i = 2; i < ui; i++)
                {
                    if (ui % 1 == 0)
                    {
                        //KEINE PRIMZAHL!
                        b = false;
                        break;
                    }
                }
                //if (b) return ui;
                Console.WriteLine("Die eingegebene Zahl ist keine Primzahl. Please try again:");
            }
        }
        //Code ENDE

    }
}