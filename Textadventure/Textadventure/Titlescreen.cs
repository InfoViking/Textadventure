namespace Textadventure
{
    internal static class Titlescreen
    {
        internal static void StartingScreen()
        {
            Console.WriteLine("The Way Home");
            Console.WriteLine("Press Space to Start");
            Console.WriteLine("Press anything to Exit");

            ConsoleKeyInfo start = Console.ReadKey();
            if (start.Key == ConsoleKey.Enter)
            { 

            }
            else
            {
                Environment.Exit(0);

            } 
        }
    }
}
