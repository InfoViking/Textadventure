namespace Textadventure
{
    /// <summary>
    /// Helper class Textscroll
    /// </summary>
    internal  class ConsoleText
    {
        internal static void Continue()
        {
            Console.WriteLine("\nDrücke Enter zum Fortfahren");
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
        }
    }
}
