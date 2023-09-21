using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Lists
{
    class Exercise_9
    {
        public static void Start()
        {

            List<int> intList = new List<int>() {46,45,2,3,-8,15,14,16,35,86,-84,25,78,6,32,-15,99,87, -38, 64, -42};

            //Kontrolle:
            Meth(intList);
            
        }

        //Schreiben Sie eine Methode, die alle Werte einer Integerliste als String ausgibt. So soll er beispielsweise bei der 1 -> "Eins" ausgeben und bei der 34 -> "Vierunddreißig". Es reicht aus, wenn es für ein und zweistellige Zahlen funktioniert. Schauen Sie auch, dass auch negative Zahlen ausgegeben werden:
        static void Meth(List<int> intList)
        {
            /*Code START*/
            List<string> einerList = new List<string>()
                { "", "ein", "zwei", "drei", "vier", "fünf", "sechs", "sieben", "acht", "neun"};
            List<string> zehnerList = new List<string>()
                { "", "zehn", "zwanzig", "dreißig", "vierzig", "fünfzig", "sechzig", "siebzig", "achtzig", "neunzig"};

            foreach(var element in intList) 
            {
                int element = element;
                if(element < 0) 
                {
                    Console.Write("Minus");
                    element *= -1;
                }

                int einer = element % 10;
                int zehner = element / 10;

                if(element == 0)
                    Console.WriteLine("Null");
                else if(element == 1)
                    Console.WriteLine("Eins");
                else if(element <= 9)
                    Console.WriteLine(einerList[einer]);
                else if(einer == 0)
                    Console.WriteLine(zehnerList[zehner]);
                else if (element == 11)
                    Console.WriteLine("Elf");
                else if (element == 12)
                    Console.WriteLine("Zwölf");
                else if (element == 19)
                    Console.WriteLine(einerList[einer].Substring(0,4) + zehnerList[zehner]);
                else
                Console.WriteLine(einerList[einer] + "und" + zehnerList[zehner]);
            }


            /*Code ENDE*/
        }
    }
}