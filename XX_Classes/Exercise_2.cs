using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Classes
{
    class Exercise_2
    {
        public static void Start()
        {
            List<Lists> listList = new List<Lists>();
            //Erstellen Sie fünf neue Instanzen der Klasse Lists und fügen Sie diese der oberen Liste hinzu.
            //Code START
            
            //Code ENDE
            
            foreach(var element in listList)
                fillListsWithRandomValues(element);

            //Lassen Sie nun den Anwender Eingaben machen. Diese sollen Strings, Chars, Ints oder Decimal sein. Überprüfen Sie, um welchen Typ es sich handelt und überprüfen Sie, ob sich dieser Wert in einer Liste in einen der Klassen befindet oder nicht. 
            //Sollte sich das Element in einer Liste befinden, dann geben Sie den Wert davor und den Wert danach aus. Sollte es keinen Wert davor bzw. danach geben, nehmen Sie den letzten oder den ersten Wert.
            while(true)
            {

            }
        }
        static void fillListsWithRandomValues(Lists lis)
        {
            Random rand = new Random();
            //Fill Integer
            for(int i = 0; i < rand.Next(5, 21); i++)
                lis.IntegerList.Add(rand.Next());
            //Fill Strings
            for(int i = 0; i < rand.Next(5,21); i++)
            {
                string temp = "";
                for(int j = 0; j < rand.Next(5,21); j++)
                    temp += (char)rand.Next(65,123);
                lis.StringList.Add(temp);
            }
            //Fill Chars
            for(int i = 0; i < rand.Next(5,21); i++)
            {
                lis.CharList.Add((char)rand.Next(65,123));
            }
            //Fill Decimal
            for(int i = 0; i < rand.Next(5,21); i++)
            {
                lis.DecimalList.Add(((decimal)rand.Next()) / (decimal)Math.Pow(10, rand.Next(1,9)));
            }

        }
    }
    class Lists
    {
        public List<int> IntegerList = new List<int>();
        public List<string> StringList = new List<string>();
        public List<char> CharList = new List<char>();
        public List<decimal> DecimalList = new List<decimal>();
    }
}