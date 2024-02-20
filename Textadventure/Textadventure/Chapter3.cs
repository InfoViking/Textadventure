using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    internal class Chapter3
    {
        Player _player;
        public Chapter3(Player player)
        {
            _player = player;
        }
        internal void Beginning()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Das Lager");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Nach dieser nervenaufreibenden Erfahrung fühlst du, wie sich Erschöpfung in dir breit macht." +
                "Du beschließt eine kurze Rast einzulegen. Du erinnerst dich an den Energydrink in deiner Tasche." +
                $"{_player.Name}: Sollte ich ihn trinken oder ihn für später aufbewahren?");

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Hinweis:Du legst eine Rast ein. Diese stellt 5 Healthpoints wieder her. " +
                "Der Energydrink stellt zusätzlich 10 Healthpoints wieder her. Ob du ihn jetzt oder zu einem späteren Zeitpunkt nutzt bleibt dir überlassen" +
                "1 = Rasten (5HP)" +
                "2 = Energydrink trinken (15HP)");

        }

        internal void RestOrDrink(Player player)
        {
            bool isCorrectInput = false;

            while (isCorrectInput == false)
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    player.Rest();
                    isCorrectInput = true;
                }
                else if (choice == 2)
                {
                    player.DrinkEnergy();
                    isCorrectInput = true;
                }
                else
                {
                    Console.WriteLine("Bitte nutzen sie die vorgegebenen Eingabetasten.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        internal void Camp()
        {   //implement Textscroll class
            Console.WriteLine(@"Nachdem du dich ein wenig erholt hast setzt du deinen Weg weiter fort. Nach einer Weile entdeckst du den Schein eines Lagerfeuers in weiter Ferne.
                                Im ersten Moment freust du dich über ein Zeichen von Zivilisation. Jedoch schwebt auch der Hintergedanke über die Wilderer in deinem Kopf herum.
                                ");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(@$"{_player.Name}: Das Feuer scheint mein einziger Anhaltspunkt zu sein. Selbst wenn ich dort einen dieser Wilderer finden sollte, werde ich ihm ordentlich die Meinung geigen.
                                Ich hätte schließlich sterben können wegen diesen verantwortungslosen Fallen");

            Console.ReadLine(); 
            Console.Clear();

            Console.WriteLine(@"Du läufst dem Licht des Lagerfeuers entgegen. Als du dich näherst siehst du tatsächlich wie sich jemand am Lagerfeuer ein Stück Fleisch brät. 
                                An einer Leine hängen einige Tierkörper leblos herab. Manche davon wurden bereits gehäutet. Mit einer Mischung aus Furcht und Wut gibst du dich der Person zu erkennen.
                                Mit einem lauten ``Hey!!`` verschaffst du dir Gehör. ");

            Console.ReadLine(); 
            Console.Clear();

            Console.WriteLine(@"Der Mann scheint, von deiner Anwesenheit nicht überrascht zu sein. Vermutlich haben seine geschäften Sinne dich längst erspäht. Er schaut dich für ein paar Sekunden reglos an und beginnt danach sich aufzurichten.
                                Dein Selbstvertrauen sinkt ins Bodenlose als du bemerkst,dass dieser Kerl mindestens 2 Meter groß und ebenso breit gebaut ist. Du kommst zu dem Entschluss, dass Gewalt als Lösung ungeeignet zu sein scheint
                                Du entscheidest dich ihn verbal zu konfrontieren.");

            Console.ReadLine(); 
            Console.Clear();

            Console.WriteLine(@$"{_player.Name}: Sind sie verantwortlich für das Massaker auf dem Hain?
                                 Wilderer: Ja das bin ich. Hast du ein Problem damit, Knirps? 
                                {_player.Name}: Welchen Minderwertigkeitskomplex versuchst du damit zu kompensieren?
                                Und damit beginnt das Wortgefecht.");

            Console.ReadLine();
            Console.Clear();






        }


    }

    
    
}
