using System;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exercises_C_Sharp
{
    class OpenLinkToVideo
    {
        static List<VideoElement> VideoLectionLinks = new List<VideoElement>()
        {
            new VideoElement(){ ID = 4, Name = "Mathematische Operationen"},
            new VideoElement(){ ID = 5, Name = "Bool'sche Operationen"},
            new VideoElement(){ ID = 6, Name = "Variablen"},
            new VideoElement(){ ID = 7, Name = "Arbeiten mit Strings"},
            new VideoElement(){ ID = 8, Name = "Debuggen"},
            new VideoElement(){ ID = 9, Name = "Ein- und Ausgabe mit der Konsole"},
            new VideoElement(){ ID = 10, Name = "Arrays"},
            new VideoElement(){ ID = 11, Name = "Kurzschreibweise Mathematische Operationen"},
            new VideoElement(){ ID = 12, Name = "Kontrollstruktur IF"},
            new VideoElement(){ ID = 13, Name = "Überprüfen von Eingaben (TryParse)"},
            new VideoElement(){ ID = 14, Name = "Short IFs"},
            new VideoElement(){ ID = 15, Name = "Switch Case"},
            new VideoElement(){ ID = 16, Name = "Flowcharts / PAP (Programm Ablauf Plan)"},
            new VideoElement(){ ID = 17, Name = "FOR-Schleife"},
            new VideoElement(){ ID = 18, Name = "Arrays variabler machen"},
            new VideoElement(){ ID = 19, Name = "FOREACH-Schleife"}
        };


        public static void ShowVideoMenu(ExerciseGroup eg, ExerciseElement ee)
        {
            Console.Clear();
            var loginData = LoadAccount();
            if(loginData == null)
            {
                Console.WriteLine("Um Videos zu den einzelnen Übungen und Lektionen anzusehen, benötigt man einen Alumnee-Account. Bitte geben Sie Ihren vollen Namen (Vor- und Nachname) ein:");

                string name;
                do{
                    name = Console.ReadLine() ?? "";
                    name = name.Trim();
                } while(string.IsNullOrEmpty(name) || !name.Contains(" ") || name.Length < 7);
                Console.WriteLine();
                Console.WriteLine("Bitte geben Sie jetzt Ihre Wibizu-E-Mailadresse ein:");
                string mail;
                do{
                    mail = Console.ReadLine() ?? "";
                    mail = mail.Trim();
                } while(string.IsNullOrEmpty(mail) || mail.Contains(" ") || mail.Length < 16);
                Console.WriteLine();
                Console.WriteLine("Die Anmeldedaten werden nun gesetzt und gespeichert!");
                loginData = new Tuple<string, string>(name, mail);
                SaveAccount(loginData);
            }
            
            int num = 0;
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Welches Video soll gezeigt werden?");
                Console.WriteLine("[{0}] Video zu dieser Lektion bzw. zu der Unterrichtsstunde, wo das    aktuelle Kapitel nochmal erläutert wird.", num == 0 ? "X" : " ");
                Console.WriteLine("[{0}] Video zu der Lösung dieser Aufgabe", num == 0 ? "X" : " ");
                var el = Console.ReadKey();
                if(el.Key == ConsoleKey.DownArrow || el.Key == ConsoleKey.UpArrow)
                {
                    if(num == 0) num = 1;
                    else num = 0;
                }
                if(el.Key == ConsoleKey.Enter)
                {
                    if(num == 0)
                        Open(loginData.Item1, loginData.Item2, eg.VideoID, "lection");
                    else if(num == 1)
                        Open(loginData.Item1, loginData.Item2, ee.VideoID, "exercise");
                    return;
                }

            }

        }
        static Tuple<string, string>? LoadAccount()
        {
            if(!File.Exists("saveFolder/accountData"))
                return null;
            var lines = File.ReadAllLines("saveFolder/accountData");
            if(lines.Length < 2)
                return null;
            
            return new Tuple<string, string>(lines[0], lines[1]);
        }
        static void SaveAccount(Tuple<string, string> values)
        {
            if(File.Exists("saveFolder/accountData"))
                File.Delete("saveFolder/accountData");
            
            List<string> stringList = new List<string>(){values.Item1, values.Item2};
            File.WriteAllLines("saveFolder/accountData", stringList);
        }
        
        static void Open(string name, string mail, int videoID, string videoKind)
        {
            string tempHTMLLocation = "saveFolder/temp.html";
            string url = @"https://alumnee.de/videoapi.php";

            // create the temporary html file
            using (FileStream fs = new FileStream(tempHTMLLocation, FileMode.Create)) { 
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8)) { 
                    w.WriteLine("<body onload=\"goToLink()\">");
                    w.WriteLine("<form id=\"form\" method=\"POST\" action=\"" + url + "\">");
                    w.WriteLine("<input type=\"hidden\" name=\"username\" value=\"" + name + "\">");
                    w.WriteLine("<input type=\"hidden\" name=\"mail\" value=\"" + mail + "\">");
                    w.WriteLine("<input type=\"hidden\" name=\"videoKind\" value=\"" + videoKind + "\">");
                    w.WriteLine("<input type=\"hidden\" name=\"videoID\" value=\"" + videoID + "\">");
                    w.WriteLine("</form>");
                    w.WriteLine("<script> function goToLink() { document.getElementById(\"form\").submit(); } </script>");
                    w.WriteLine("</body>");
                } 
            }

            // launch the temp html file
            var launchProcess = new ProcessStartInfo {
                FileName = tempHTMLLocation,
                UseShellExecute = true
            };
            Process.Start(launchProcess);

            // delete temp file but add delay so that Process has time to open file
            Task.Delay(1500).ContinueWith(t=> File.Delete(tempHTMLLocation));
        }
    }
}