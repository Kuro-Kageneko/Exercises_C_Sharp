using System;

namespace Exercises_C_Sharp.XX_Konstruktoren
{
    class Exercise_5
    {
        public static void Start()
        {
            //Erzeugen Sie drei Tiere und lassen Sie sie Lärm machen....
            //Code Start

            //Code ENDE
        }
    }

    class Animalclass
    {
        public readonly string Name;
        public readonly Animals Kind;
        public Animalclass(string name, Animals kind)
        {
            this.Name = name;
            this.Kind = kind;
        }
        public void MakeNoise()
        {
            Console.Write("{0} is a {1} and make ", Name, Kind.ToString());
            if(Kind == Animals.Dog)
                Console.WriteLine("\"Wuff\"");
            else if(Kind == Animals.Cat)
                Console.WriteLine("\"Miau\"");
            else if(Kind == Animals.Cow)
                Console.WriteLine("\"Muh\"");
            else if(Kind == Animals.Sheep)
                Console.WriteLine("\"Mäh\"");
            else if(Kind == Animals.Horse)
                Console.WriteLine("\"Wieha\"");
        }
    }

    enum Animals  {Dog, Cat, Cow, Sheep, Horse}
}