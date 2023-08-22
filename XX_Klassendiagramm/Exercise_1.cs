using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Klassendiagramm
{
    //Übertragen Sie jede Klasse in ein Objekt eines Klassendiagramms
    class Messbecher
    {
        private int volume = 0;
        public string Material {get{return "plastic";}}
        public int Volume{get{return volume;}}

        public void Fill(int milliliter){ }
        public void Empty(){ }
        private bool isStill(){ return true; }
    }

    class Hammer
    {
        public string Material = "Stahl";
        private int verschleiß = 46;
        public void Schlagen(int stärke){ }
        public void Pflegen(){ }
        private int verschleißBerechnen(int schlagstärke){return verschleiß * schlagstärke;}
    }

    class Kaugummi
    {
        public List<string> Inhaltsstoffe = new List<string>();
        private List<string> giftigeStoffe = new List<string>();
        public string Geschmack = "Erdbeere";
        public double GrammZucker = 12.453;
        private double wirklicheGrammZucker = 72.82;
        private DateTime wirklichesAblaufdatum = new DateTime(1999, 02, 08);

        private decimal freigabeGiftstoffe(){return (decimal)(wirklicheGrammZucker * 3);}
        public bool Kauen(int kaustärke){ return true; }
        public DateTime Ablaufdatum(){ return DateTime.Now.AddYears(3);}
    }
}