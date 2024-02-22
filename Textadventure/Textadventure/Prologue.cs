namespace Textadventure
{
    internal class Prologue
    {
        Player _player;
        public Prologue(Player player)
        {
            _player = player;
        }
        /// <summary>
        /// Character informations.
        /// </summary>
        internal static Player Character()
        {
            Player player = new Player();
            Console.WriteLine("Bitte geben sie einen Namen für ihren Charakter ein");
            string name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Fehlermeldung 418: Es muss ein Name eingetragen werden.");
                Console.WriteLine("Geben sie einen Namen für ihren Charakter ein.");
                name = Console.ReadLine();
            }

            player.Name = name;
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine("Alter: 18.");
            Console.WriteLine("Größe: 1,74m.");
            Console.WriteLine("Beruf: Schüler.");
            Textscroll.TextScroll();

            return player;

        }

        /// <summary>
        /// Prologue text
        /// </summary>
        internal void Intro()
        {
            Console.WriteLine("Du erwachst auf einem Waldweg. Es scheint tiefste Nacht zu sein.\n" +
                $"{_player.Name}: Wo bin ich? Was ist passiert?\n");
            Textscroll.TextScroll();
            Console.WriteLine("Deine Erinnerung kehrt langsam zu dir zurück... \n" +
                 "Du wurdest nach der Schule von den (coolen) Kids abgefangen.\n" +
                 "Sie wollten dich in ihre Clique aufnehmen. Du solltest dich einer\n" +
                 "Prüfung im Wald stellen.\n");
            Textscroll.TextScroll();
            Console.WriteLine("Sie verbanden dir die Augen. Das letzte an das du dich erinnern kannst\n" +
                 "war ein Schlag auf deinen Hinterkopf. Danach wurde alles schwarz.\n");
            Textscroll.TextScroll();
            Console.WriteLine("Du prüfst deine Taschen und deinen Rucksack.\n" +
                $"{_player.Name}: Diese miesen,verlogenen...\n" +
                 "Selbst deine Schulbücher waren weg. Nur der Energydrink in der Seitentasche war noch da.\n" +
                $"{_player.Name}: Ich muss nach Hause. Meine Eltern sind bestimmt krank vor Sorge.\n" +
                 "Und so begann dein außergewöhnlicher Weg nach Hause.\n");
            Textscroll.TextScroll();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("The Other Way Home");
            Textscroll.TextScroll(); 
        }
    }
}
