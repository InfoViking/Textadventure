namespace Textadventure
{
    internal static class Titlescreen
    {
        internal static void StartingScreen()
        {
            Console.WriteLine("The Way Home");
            Console.WriteLine("Press Enter to Start");
            Console.WriteLine("Press anything to Exit");

            ConsoleKeyInfo start = Console.ReadKey();
            if (start.Key != ConsoleKey.Enter)
            {
                Environment.Exit(0);
            }
        }
    }
}
