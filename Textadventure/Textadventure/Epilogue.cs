namespace Textadventure
{
    /// <summary>
    /// Constructor Player class
    /// </summary>
    internal class Epilogue
    {
        Player _player;
        public Epilogue(Player player)
        {
            _player = player;
        }

        /// <summary>
        /// Intro Epilogue
        /// </summary>
        internal void Beginning()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Zivilisation");
            ConsoleText.Continue();
            Console.WriteLine("Nach einer gefühlten Ewigkeit des Laufens und nachdem du schon mehrfach sämtliche Hoffnung verloren hast\n" +
                "je wieder aus diesem Wald zu kommen, siehst du in der Ferne etwas aufleuchten.\n" +
                "Als deine müden Augen erkennen um was es sich handelt trifft es dich wie ein Blitz.\n");
            ConsoleText.Continue();
            Console.WriteLine($"{_player.Name}: Ich werd verrückt... das sind die Scheinwerfer eines Autos. Und das bedeutet...\n" +
            "Noch bevor du deinen Gedanken beendest, läufst du so schnell dich deine müden Beine tragen in Richtung der Straße\n");
            ConsoleText.Continue();
            Console.WriteLine("Und tatsächlich. Du brichst durch die letzten Büsche und stehst auf einer Landstraße.\n" +
                "Als du dich umsiehst erkennst du einige Gebäude wieder und weißt, seit einer Ewigkeit wieder, wo du dich befindest.\n" +
                "Es ist eine der Landstraßen die sich um deine Heimatstadt ziehen.\n" +
                "Du möchtest am liebsten schnellstmöglich nach Hause und deine Eltern umarmen.\n" +
                "Jedoch hällst du es für vernünftiger zuerst einen Arzt aufzusuchen.\n" +
                "Glücklicherweise weißt du, dass sich ein Arzt ganz in der Nähe befindet.\n");
            ConsoleText.Continue();

            

            //query Usedrink / go to Doctor
            bool isCorrectInput = false;


            while (isCorrectInput == false)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Hinweis: Du wirst gleich den Arzt erreichen.\n" +
                    "Dort wird sich herausstellen ob du achtsam genug warst und welches Ende dich erwartet.\n" +
                    "Du hast die Möglichkeit den Energydrink zu trinken, falls du ihn nicht schon getrunken hast,\n" +
                    "um 10HP zu regenerieren.\n" +
                    "1 = Energydrink trinken\n" +
                    "2 = sofort zum Arzt gehen");

                string choice = Console.ReadLine();
                int convertedChoice = 0;

                if (!int.TryParse(choice, out convertedChoice))
                {
                    Console.WriteLine("Bitte nutzen sie die vorgegebenen Eingabetasten.");
                    ConsoleText.Continue();

                    continue;
                }

                if (convertedChoice == 1)
                {
                    if (_player.HasEnergyDrink == false)
                    {
                        Console.WriteLine("Du hast deinen Energydrink bereits verwendet");
                        ConsoleText.Continue();

                        continue;
                    }
                    _player.UseEnergyDrink();
                    Console.ReadLine();
                    GoToDoctor();
                    isCorrectInput = true;
                }
                else if (convertedChoice == 2)
                {
                    GoToDoctor();
                    isCorrectInput = true;
                }
            }
        }

        /// <summary>
        /// Good/Bad Ending
        /// </summary>
        internal void GoToDoctor()
        {
            Console.WriteLine("Du machst dich auf den Weg zum Arzt.\n" +
                "Entgegen aller Erwartungen kommst du sofort dran.\n" +
                "Der Arzt beginnt seine Untersuchung.");
            ConsoleText.Continue();

            if ( _player.HealthPoints >= 10)
            {
                Console.WriteLine("Diagnose: Du scheinst dich einer guten Gesundheit zu erfreuen.\n" +
                    "Der Arzt empfiehlt dir, dich ein paar Tage zu schonen.\n" +
                    "Glücklich über die guten Nachrichten, verlässt du die Arztpraxis und läufst auf dem schnellsten Weg nach Hause. \n" +
                    "Dort angekommen öffnen dir deine Eltern die Tür.");
                ConsoleText.Continue();
                Console.WriteLine("In Tränen ausbrechend, schließen sie dich in ihre Arme.\n" +
                    "Nach einer Dusche und einem Klamottenwechsel erzählst du deinen Eltern von deinem Abenteuer.\n" +
                    "Du glaubst dabei eine Mischung aus Unglaube und Stolz in ihren Gesichtern zu erkennen.\n" +
                    "Zu guter Letzt wird dir ein wahres Festmahl zubereitet, damit du wieder zu Kräften kommst,");
            }
            else
            {
                Console.WriteLine("Diagnose: Der Arzt betet dir eine Liste an Verletzungen runter inklusive der Behandlungen die nötig sein werden,\n" +
                    "um dich wieder in Ordnung zu bringen. \n" +
                    "Du gibst parallel alle Behandlungen in die MediServApp ein.\n" +
                    "Bei einem Blick auf die Gesamtkosten wird dir fast Schwarz vor Augen.\n" +
                    "Angsterfüllt trottest du nach Hause.");
                ConsoleText.Continue();
                Console.WriteLine("Die Begrüßung zu Hause gestaltet sich herzlich aber als du deinen Eltern die Rechnung zeigst wird es schlagartig still.\n" +
                    "Glücklicherweise kann durch die hervorragenden\n" +
                    "Leistungen der MediServ eine angenehme und stämmbare Staffelung der Kosten erfolgen.\n" +
                    "Nichtsdestotrotz wirst du dazu verdonnert, für einen Teil der entstehenden Kosten\n" +
                    "aufzukommen. Du verbringst deine nächsten 3 Ferien mit Aushilfsjobs und Hausarbeiten zur Tilgung deiner Schulden.");
            }
        }
    }
}
