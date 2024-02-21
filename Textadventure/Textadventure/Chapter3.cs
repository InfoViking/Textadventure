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

            Console.WriteLine("Nach dieser nervenaufreibenden Erfahrung fühlst du, wie sich Erschöpfung in dir breit macht.\n" +
                "Du beschließt eine kurze Rast einzulegen. Du erinnerst dich an den Energydrink in deiner Tasche.\n" +
                $"{_player.Name}: Sollte ich ihn trinken oder ihn für später aufbewahren?\n");

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Hinweis:Du legst eine Rast ein. Diese stellt 5 Healthpoints wieder her. \n" +
                "Der Energydrink stellt 10 Healthpoints wieder her. Ob du ihn jetzt oder zu einem späteren Zeitpunkt nutzt bleibt dir überlassen\n" +
                "1 = Rasten (5HP)\n" +
                "2 = Energydrink trinken (10HP)\n");

            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();

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
                    player.UseEnergyDrink();
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
            Console.WriteLine("Nachdem du dich ein wenig erholt hast setzt du deinen Weg weiter fort. Nach einer Weile entdeckst du den Schein eines Lagerfeuers in weiter Ferne.\n" +
                              "Im ersten Moment freust du dich über ein Zeichen von Zivilisation. Jedoch schwebt auch der Hintergedanke über die Wilderer in deinem Kopf herum.\n");
                             

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"{_player.Name}: Das Feuer scheint mein einziger Anhaltspunkt zu sein. Selbst wenn ich dort einen dieser Wilderer finden sollte, werde ich ihm ordentlich die Meinung geigen.\n" +
                                                 "Ich hätte schließlich sterben können wegen diesen verantwortungslosen Fallen");

            Console.ReadLine(); 
            Console.Clear();

            Console.WriteLine("Du läufst dem Licht des Lagerfeuers entgegen. Als du dich näherst siehst du tatsächlich wie sich jemand am Lagerfeuer ein Stück Fleisch brät.\n" +
                                "An einer Leine hängen einige Tierkörper leblos herab. Manche davon wurden bereits gehäutet. Mit einer Mischung aus Furcht und Wut gibst du dich der Person zu erkennen.\n" +
                                "Mit einem lauten ``Hey!!`` verschaffst du dir Gehör. ");

            Console.ReadLine(); 
            Console.Clear();

            Console.WriteLine("Der Mann scheint, von deiner Anwesenheit nicht überrascht zu sein. Vermutlich haben seine geschäften Sinne dich längst erspäht. \n" +
                "              Er schaut dich für ein paar Sekunden reglos an und beginnt danach sich aufzurichten.\n" +
                                "Dein Selbstvertrauen sinkt ins Bodenlose als du bemerkst,dass dieser Kerl mindestens 2 Meter groß und ebenso breit gebaut ist. \n" +
                                "Du kommst zu dem Entschluss, dass Gewalt als Lösung ungeeignet zu sein scheint\n" +
                                "Du entscheidest dich ihn verbal zu konfrontieren.\n");

            Console.ReadLine(); 
            Console.Clear();

            Console.WriteLine($"{_player.Name}: Sind sie verantwortlich für das Massaker auf dem Hain?\n" +
                                "Wilderer: Ja das bin ich. Hast du ein Problem damit, Knirps?\n" +
                                $"{_player.Name}: Welchen Minderwertigkeitskomplex versuchst du damit zu kompensieren?\n" +
                                "Und damit beginnt das Wortgefecht.");

            Console.ReadLine();
            Console.Clear();
        }

        internal void BattleTalk()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Hinweis: Nun ist es an der Zeit dein lyrisches Talent abzurufen.\n " +
                "In folgendem Dialog gilt es die richtige Antwort auf die Kommentare des Wilderers zu finden.\n" +
                "Wenn du es schaffst mindestens 3 schlagfertige Antworten zu geben, wird er seine berufliche Karriere vielleicht überdenken..\n" +
                "Tipp: Die richtige Antwort passt inhaltlich zur Aussage des Wilderers.");

            Console.ReadLine();
            Console.Clear();
            Console.ResetColor();

            
        }

        
    }

}
