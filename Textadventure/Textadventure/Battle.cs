using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    internal class Battle
    {
        Player _player;
        public Battle(Player player)
        {
            _player = player;
        }
        public void battleDialogue1()
        {
            Console.WriteLine("Wilderer: Du bist wohl Lebensmüde?!");

            bool isCorrectInput = false;


            while (isCorrectInput == false)
            {
                string choice = Console.ReadLine();
                int convertedChoice = 0;

                if (!int.TryParse(choice, out convertedChoice))
                {
                    Console.WriteLine("Bitte nutzen sie die vorgegebenen Eingabetasten.");
                    Console.ReadLine();
                    Console.Clear();

                    continue;
                }

                if (convertedChoice == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Jetzt, wo ich dich sehe, fällt mir ein, dass ich noch den Müll rausbringen muss.");
                    _player.CalculateHealthpoints(-5);
                    Console.ResetColor();
                    
                    isCorrectInput = true;
                }
                else if (convertedChoice == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Wenn ich mich umbringen wollte, würde ich dein Ego erklimmen und zu deinem IQ springen.");
                    Console.ResetColor();
                    isCorrectInput = true;
                }
                else if (convertedChoice == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ganz unbrauchbar bist du nicht, man kann dich immer noch als schlechtes Beispiel benutzen.");
                    _player.CalculateHealthpoints(-5);
                    Console.ResetColor();
                    isCorrectInput = true;
                }
            }
        }

        public void battleDialogue2()
        {
            Console.WriteLine("Wilderer: Wir schützen die Menschen vor den bösartigen Tieren des Waldes.");

            bool isCorrectInput = false;


            while (isCorrectInput == false)
            {
                string choice = Console.ReadLine();
                int convertedChoice = 0;

                if (!int.TryParse(choice, out convertedChoice))
                {
                    Console.WriteLine("Bitte nutzen sie die vorgegebenen Eingabetasten.");
                    Console.ReadLine();
                    Console.Clear();

                    continue;
                }

                if (convertedChoice == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du bist wie eine Wolke. Wenn du verschwindest, wird es ein schöner Tag.");
                    _player.CalculateHealthpoints(-5);
                    Console.ResetColor();

                    isCorrectInput = true;
                }
                else if (convertedChoice == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du bist so enttäuschend wie eine ungesalzene Brezel.");
                    _player.CalculateHealthpoints(-5);
                    Console.ResetColor();
                    isCorrectInput = true;
                }
                else if (convertedChoice == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Die wahren Helden sind die Menschen, die dich jeden Tag tolerieren müssen.");
                    Console.ResetColor();
                    isCorrectInput = true;
                }
            }

            Console.Clear();
        }

        public void battleDialogue3()
        {
            Console.WriteLine("Wilderer:Meiner Meinung nach sind Tiere nur dazu da um Geld zu verdienen.");

            bool isCorrectInput = false;


            while (isCorrectInput == false)
            {
                string choice = Console.ReadLine();
                int convertedChoice = 0;

                if (!int.TryParse(choice, out convertedChoice))
                {
                    Console.WriteLine("Bitte nutzen sie die vorgegebenen Eingabetasten.");
                    Console.ReadLine();
                    Console.Clear();

                    continue;
                }

                if (convertedChoice == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du solltest eine Pflanze mit dir herumtragen, um den Sauerstoff zu ersetzen, den du verschwendest.");
                    _player.CalculateHealthpoints(-5);
                    Console.ResetColor();

                    isCorrectInput = true;
                }
                else if (convertedChoice == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Das ist aber ganz schön viel Meinung für so wenig Ahnung.");
                    Console.ResetColor();
                    isCorrectInput = true;
                }
                else if (convertedChoice == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wenn Genialität eine Generation überspringt, dann werden deine Kinder brillant.");
                    _player.CalculateHealthpoints(-5);
                    Console.ResetColor();
                    isCorrectInput = true;
                }
            }

            Console.Clear();
        }

        public void battleDialogue4()
        {
            Console.WriteLine("Du wirst gleich herausfinden wie mein Stiefel schmeckt.");

            bool isCorrectInput = false;


            while (isCorrectInput == false)
            {
                string choice = Console.ReadLine();
                int convertedChoice = 0;

                if (!int.TryParse(choice, out convertedChoice))
                {
                    Console.WriteLine("Bitte nutzen sie die vorgegebenen Eingabetasten.");
                    Console.ReadLine();
                    Console.Clear();

                    continue;
                }

                if (convertedChoice == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Zwei IQ-Punkte weniger und du bräuchtest Schuhe mit Klettverschluss.");
                    Console.ResetColor();

                    isCorrectInput = true;
                }
                else if (convertedChoice == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ist es nicht gefährlich, wenn du dein ganzes Vokabular in einem Satz benutzt?");
                    _player.CalculateHealthpoints(-5);
                    Console.ResetColor();
                    isCorrectInput = true;
                }
                else if (convertedChoice == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du bist der Beweis, dass die Evolution auch rückwärts funktioniert.");
                    _player.CalculateHealthpoints(-5);
                    Console.ResetColor();
                    isCorrectInput = true;
                }
            }

            Console.Clear();

        }
    }
}
