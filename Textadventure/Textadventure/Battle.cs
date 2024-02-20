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
            Console.WriteLine("1 = Jetzt, wo ich dich sehe, fällt mir ein, dass ich noch den Müll rausbringen muss." +
                              "2 = Wenn ich mich umbringen wollte, würde ich dein Ego erklimmen und zu deinem IQ springen." +
                              "3 = Ganz unbrauchbar bist du nicht, man kann dich immer noch als schlechtes Beispiel benutzen");

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
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Jetzt, wo ich dich sehe, fällt mir ein, dass ich noch den Müll rausbringen muss.");
                    _player.CalculateHealthpoints(-5);
                    Console.ReadLine();
                    Console.ResetColor();
                    
                    isCorrectInput = true;
                }
                else if (convertedChoice == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Wenn ich mich umbringen wollte, würde ich dein Ego erklimmen und zu deinem IQ springen.");
                    Console.ReadLine();
                    Console.ResetColor();
                    isCorrectInput = true;
                }
                else if (convertedChoice == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ganz unbrauchbar bist du nicht, man kann dich immer noch als schlechtes Beispiel benutzen.");
                    Console.ReadLine();
                    _player.CalculateHealthpoints(-5);
                    Console.ResetColor();
                    isCorrectInput = true;
                }
            }

            Console.Clear();
        }

        public void battleDialogue2()
        {
            Console.WriteLine("Wilderer: Wir schützen die Menschen vor den bösartigen Tieren des Waldes."); 
            Console.WriteLine("1 = Du bist wie eine Wolke. Wenn du verschwindest, wird es ein schöner Tag." +
                              "2 = Du bist so enttäuschend wie eine ungesalzene Brezel." +
                              "3 = Die wahren Helden sind die Menschen, die dich jeden Tag tolerieren müssen.");

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
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Du bist wie eine Wolke. Wenn du verschwindest, wird es ein schöner Tag.");
                    Console.ReadLine();
                    _player.CalculateHealthpoints(-5);
                    Console.ResetColor();

                    isCorrectInput = true;
                }
                else if (convertedChoice == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Du bist so enttäuschend wie eine ungesalzene Brezel.");
                    Console.ReadLine();
                    _player.CalculateHealthpoints(-5);
                    Console.ResetColor();
                    isCorrectInput = true;
                }
                else if (convertedChoice == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Die wahren Helden sind die Menschen, die dich jeden Tag tolerieren müssen.");
                    Console.ReadLine();
                    Console.ResetColor();
                    isCorrectInput = true;
                }
            }

            Console.Clear();
        }

        public void battleDialogue3()
        {
            Console.WriteLine("Wilderer:Meiner Meinung nach sind Tiere nur dazu da um Geld zu verdienen.");
            Console.WriteLine("1 = Du solltest eine Pflanze mit dir herumtragen, um den Sauerstoff zu ersetzen, den du verschwendest." +
                              "2 = Das ist aber ganz schön viel Meinung für so wenig Ahnung." +
                              "3 = Wenn Genialität eine Generation überspringt, dann werden deine Kinder brillant.");
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
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Du solltest eine Pflanze mit dir herumtragen, um den Sauerstoff zu ersetzen, den du verschwendest.");
                    Console.ReadLine();
                    _player.CalculateHealthpoints(-5);
                    Console.ResetColor();

                    isCorrectInput = true;
                }
                else if (convertedChoice == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Das ist aber ganz schön viel Meinung für so wenig Ahnung.");
                    Console.ReadLine();
                    Console.ResetColor();
                    isCorrectInput = true;
                }
                else if (convertedChoice == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Wenn Genialität eine Generation überspringt, dann werden deine Kinder brillant.");
                    Console.ReadLine();
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
            Console.WriteLine("1 = Zwei IQ-Punkte weniger und du bräuchtest Schuhe mit Klettverschluss." +
                              "2 = Ist es nicht gefährlich, wenn du dein ganzes Vokabular in einem Satz benutzt?" +
                              "3 = Du bist der Beweis, dass die Evolution auch rückwärts funktioniert.");
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
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Zwei IQ-Punkte weniger und du bräuchtest Schuhe mit Klettverschluss.");
                    Console.ResetColor();

                    isCorrectInput = true;
                }
                else if (convertedChoice == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ist es nicht gefährlich, wenn du dein ganzes Vokabular in einem Satz benutzt?");
                    _player.CalculateHealthpoints(-5);
                    Console.ResetColor();
                    isCorrectInput = true;
                }
                else if (convertedChoice == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
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
