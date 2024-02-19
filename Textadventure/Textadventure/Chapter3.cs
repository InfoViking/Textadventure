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
                "Hännschen: Sollte ich ihn trinken oder ihn für später aufbewahren?");

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Hinweis:Du legst eine Rast ein. Diese stellt 5 Healthpoints wieder her. " +
                "Der Energydrink stellt zusätzlich 10 Healthpoints wieder her. Ob du ihn jetzt oder zu einem späteren Zeitpunkt nutzt bleibt dir überlassen" +
                "1 = Rasten (5HP)" +
                "2 = Energydrink trinken (15)");

        }

        internal bool RestOrDrink(Player)
        {
            bool isCorrectInput = false;

            while (isCorrectInput == false)
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    
                    isCorrectInput = true;
                }
                else if (choice == 2)
                {
                    
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

        
    }

    
    
}
