using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    internal class Chapter2
    {
        public static void Beginning()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Wandloses Labyrinth");

            Console.ResetColor();
            TextContinue.Textscroll();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Der Wald lichtet sich und du betrittst einen Hain. Als du genauer hinsiehst siehst du dutzende Pflöcke welche in den Boden getrieben wurden. " +
                "Während du versuchst zu verstehen was es damit auf sich hat, siehst du wie ein Reh den Hain betritt. Als es dich bemerkt rennt es schnurstracks Richtung der Pflöcke." +
                "Kurz darauf hörst du ein metallisches Geräusch gefolgt von einem schmerzerfüllten Schrei des Rehs. Danach... Stille");

            TextContinue.Textscroll();
            Console.ReadLine();

            Console.WriteLine("Dir wird schlagartig heiß und kalt. Du versuchst mit der Taschenlampe zu sehen was passiert ist. Hättest du es doch besser gelassen." +
                "Der gesamte Bereich ist übersäht mit Tierkadavern. Du versuchst nicht laut loszuschreien. Nachdem du dich beruhigt hast erinnerst du dich daran, " +
                "dass eine Bande Wilderer in diesem Wald ihr Unwesen treibt.");

            TextContinue.Textscroll();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Hännschen: Was für eine Barberei. Wenn ich versuche hier einfach durchzulaufen wird es mir nicht anders ergehen. ");

            TextContinue.Textscroll();
            Console.ReadLine();

            Console.WriteLine("Nach langem grübeln fällt dir ein Pflock auf der ein wenig abseits steht. Es scheint etwas mit einem Messer eingeritzt zu sein.");

            TextContinue.Textscroll();
            Console.ReadLine();
            
            Console.BackgroundColor= ConsoleColor.Green;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.WriteLine("Hinweis: Die nächste Nachricht wird dir nur einmal angezeigt. Präge dir gut ein was dort steht. Falls nicht wird es schmerzhaft.");

            Console.ResetColor();
            TextContinue.Textscroll();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Start 2xV, 1xR, 2xV, 2xL, 3xV ");

            TextContinue.Textscroll();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Nachdem du dir die Nachricht ausgiebig eingeprägt hast setzt du deinen Weg fort. "); 

            TextContinue.Textscroll();
            Console.ReadLine();
            Console.Clear();
            


        }
    }
}
