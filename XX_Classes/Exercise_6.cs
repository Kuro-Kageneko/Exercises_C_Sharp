using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Classes
{
    class Exercise_6
    {
        public static void Start()
        {
            List<Animal> AnimalList = new List<Animal>();

            //Füllen Sie die AnimalList mit 20 verschiedenen Tieren unterschiedlichen Typs.
            //Code Start

            //Code Ende

            while(true)
            {
                //Geben Sie dem Anwender die Möglichkeit, nach den unten stehenden Enums zu filtern. Der Anwender soll auswählen, nach was er filtern möchte (z.B. Schuppen, Vogel, Insekt usw.). Rufen Sie dann die Methode FilterAnimnals() auf und übergeben Sie diesen Wert.
                //Code Start
                
                //Code Ende
            }

        }

        static void FilterAnimals<T> (List<Animal> animalList, T filterItem)
        {
            Console.Clear();
            if(filterItem == null || animalList == null)
                return;
            foreach(var element in animalList)
            {
                if(typeof(T) == typeof(SkinKind))
                {
                    if(element.Skin == (SkinKind)Convert.ChangeType(filterItem, typeof(SkinKind)))
                        PrintAnimalToConsole(element);
                }
                else if(typeof(T) == typeof(MealKind))
                {
                    if(element.Meal == (MealKind)Convert.ChangeType(filterItem, typeof(MealKind)))
                        PrintAnimalToConsole(element);
                }
                else if(typeof(T) == typeof(AnimalKind))
                {
                    if(element.Kind == (AnimalKind)Convert.ChangeType(filterItem, typeof(AnimalKind)))
                        PrintAnimalToConsole(element);
                }
            }
        }

        static void PrintAnimalToConsole(Animal a)
        {
            //Geben Sie hier das übergebene Tier mit allen Werten aus.
            //Code Start
            

            //Code Ende
        }


        enum SkinKind {Fell, Schuppen, Federn, Haut}
        enum MealKind {Pflanzenfresser, Fleischfresser, Allesfresser}
        enum AnimalKind {Säugetier, Vogel, Insekt, Reptil}

        class Animal
        {
            public string? Name = null;
            public SkinKind Skin = SkinKind.Federn;
            public MealKind Meal = MealKind.Allesfresser;
            public AnimalKind Kind = AnimalKind.Insekt;

            public int CurrentPopulation = -1;

        }
    }
}