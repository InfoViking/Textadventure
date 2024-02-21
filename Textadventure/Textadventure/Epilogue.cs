namespace Textadventure
{
    internal class Epilogue
    {
        Player _player;
        public Epilogue(Player player)
        {
            _player = player;
        }
        internal void Doctor()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Zivilisation");

            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();

            Console.WriteLine("Nach einer gefühlten Ewigkeit des Laufens und nachdem du schon mehrfach sämtliche Hoffnung verloren hast je wieder aus diesem Wald zu kommen, siehst du in der Ferne etwas aufleuchten." +
                "Als deine müden Augen erkennen um was es sich handelt trifft es dich wie ein Blitz");

            Console.ReadLine();

            Console.WriteLine($"{_player.Name}: Ich werd verrückt... das sind die Scheinwerfer eines Autos. Und das bedeutet... ");
            Console.WriteLine("Noch bevor du deinen Gedanken beendest läufst du so schnell dich deine müden Beine tragen in Richtung der Straße");
            Console.ReadLine();

            Console.WriteLine("Und tatsächlich. Du brichst durch die letzten Büsche und stehst auf einer Landstraße. Als du dich umsiehst erkennst du einige Gebäude wieder und weißt, seit einer Ewigkeit wieder, wo du dich befindest." +
                "Es ist eine der Landstraßen die sich um deine Heimatstadt ziehen. Du möchtest am liebsten schnellstmöglich nach Hause und deine Eltern umarmen. Jedoch hälst du es für vernünftiger zuerst einen Arzt aufzusuchen." +
                "Glücklicherweise weißt du, dass sich ein Arzt ganz in der Nähe befindet.");

            Console.ReadLine();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Hinweis: Du wirst gleich den Arzt erreichen. Dort wird sich herausstellen ob du achtsam genug warst und welches Ende dich erwartet. Du hast die Möglichkeit den Energydrink zu trinken, falls du ihn nicht schon getrunken hast, um 10HP zu regenerieren." +
                "1 = Energydrink trinken" +
                "2 = sofort zum Arzt gehen ");




                
        }
    }
}
