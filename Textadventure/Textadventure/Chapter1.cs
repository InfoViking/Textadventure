using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    internal class Chapter1
    {
        public static void Beginning()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Der Scheideweg");

            Console.ResetColor();
            TextContinue.Textscroll();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Du beschließt fürs Erste dem Weg zu folgen auf dem du erwacht bist." +
                " Nach einer Weile bemerkst du vor dir ein schwaches Leuchten. Als du dich näherst," +
                " erkennst du die Lichtquelle. Erleichterung durchströmt deinen Körper");

            TextContinue.Textscroll();
            Console.ReadLine();

            Console.WriteLine("Hännschen: Ein Handy! Ich bin gerettet!");

            TextContinue.Textscroll();
            Console.ReadLine();

            Console.WriteLine("Du schaltest das Handy ein und deine Hoffnung verfliegt so schnell," +
                " wie sie gekommen war." +
                "Kein Empfang. Nicht einmal Notrufe sind verfügbar. Jedoch bemerkst du etwas merkwürdiges." +
                "Es befindet sich nur eine einzige App auf dem Handy.");

            TextContinue.Textscroll();
            Console.ReadLine();

            Console.WriteLine("Hännschen: MediServApp. Mh. Das ist doch diese großartige Bank für" +
                " medizinische Transaktionen." +
                "Bekannt aus Funk und Fernsehen und dazu noch weltweit geschätzt und anerkannt. ");

            TextContinue.Textscroll();
            Console.ReadLine();
            Console.Clear();
            
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Hinweis: Gutes/Schlechtes Ende." +
                " Wenn du auf deiner Reise verletzt wirst, musst du am Ende medizinische" +
                " Leistungen in Anspruch nehmen. Du willst schließlich nicht, dass sich deine" +
                " Eltern noch mehr Sorgen machen. " +
                "Die Kosten der medizinischen Leistungen hängen von deinen Lebenspunkten am Ende" +
                " des Abenteuers ab" +
                "Je weniger Lebenspunkte, desto kostspieliger die Leistungen, desto größer der Ärger," +
                " der dich zu Hause erwartet." +
                "Versuche gesund zu bleiben und sei vorsichtig");
            
            Console.ResetColor();
            TextContinue.Textscroll();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Nachdem du sich mit den Funktionen vertraut gemacht hast setzt du deinen Weg nach Hause weiter fort." +
                "Nach einer Weile gabelt sich der Weg in zwei Richtungen. Du leuchtest mit der Taschenlampe des Handys die Wege aus.");

            TextContinue.Textscroll();
            Console.ReadLine();

            Console.WriteLine("Der linke Weg scheint deutlich schlechter ausgebaut zu sein. Einige Dornenranken wuchern über den Weg" +
                " und Schlaglöcher bergen die Gefahr bei einem falschen Schritt deinen Knöchel zu verletzen." +
                "Der rechte Weg sieht, im Vergleich, deutlich besser aus. Allerdings bemerkst du auf dem Boden Fußspuren." +
                "Als du sie genauer untersuchst stellst du fest, dass diese Fußspuren definitiv nicht von Menschen stammen." +
                "Du kannst sie keinem Tier zuordnen. Je länger du sie untersuchst desto unwohler fühlst du dich.");

            Console.WriteLine("Hännschen: Jeder der Wege hat seine Unsicherheiten. Aber ich muss weiter. Zurückgehen ist keine Option" +
                "Ich entscheide mich für...");

            ///decision left/right way///
            




           





        }


    }
}
