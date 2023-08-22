using System;

namespace Exercises_C_Sharp.XX_Konstruktoren
{
    class Exercise_6
    {
        public static void Start()
        {
            //Es gibt einige Klassen, von denen Sie schon wissen, dass es Konstruktoren gibt. Hier zwei weitere Beispiele:

            //Erzeugen Sie ein Tuple aus double und decimal:
            //Code Start
            dynamic tup = -1;
            //Code ENDE
            Console.WriteLine("Der double: {0}  -  der decimal: {1}", tup.Item1, tup.Item2);

            //Erstellen Sie ein neues Random-Element, um Zufallszahlen zu erzeugen. Übergeben Sie einen dabei einen Seed, um die Zufallszahlen noch besser zu machen:
            //Code Start
            dynamic Random = -1;
            //Code ENDE
            Console.WriteLine(Random.Next());
        }
    }
}