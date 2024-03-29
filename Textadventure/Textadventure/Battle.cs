﻿namespace Textadventure
{
    /// <summary>
    /// Constructor player class
    /// </summary>
    internal class Battle
    {
        Player _player;
        public Battle(Player player)
        {
            _player = player;
        }

        /// <summary>
        /// Battledialogue query / 3 choices
        /// </summary>
        public void BattleDialogue1()
        {
            

            bool isCorrectInput = false;


            while (isCorrectInput == false)
            {
                Console.WriteLine("Wilderer: Du bist wohl Lebensmüde?!\n" +
                    "1 = Jetzt, wo ich dich sehe, fällt mir ein, dass ich noch den Müll rausbringen muss.\n" +
                    "2 = Wenn ich mich umbringen wollte, würde ich dein Ego erklimmen und zu deinem IQ springen. \n" +
                    "3 = Ganz unbrauchbar bist du nicht, man kann dich immer noch als schlechtes Beispiel benutzen \n");

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
                    Console.ReadLine();
                    Console.ResetColor();

                    isCorrectInput = true;
                }
                else if (convertedChoice == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Wenn ich mich umbringen wollte, würde ich dein Ego erklimmen und zu deinem IQ springen.");
                    _player.CalculateDialoguepoints(+5);
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
                    Console.ResetColor();
                    isCorrectInput = true;
                }
            }

            Console.Clear();
        }

        public void BattleDialogue2()
        {
            

            bool isCorrectInput = false;


            while (isCorrectInput == false)
            {
                Console.WriteLine("Wilderer: Wir schützen die Menschen vor den bösartigen Tieren des Waldes.\n" +
                    "1 = Du bist wie eine Wolke. Wenn du verschwindest, wird es ein schöner Tag.\n" +
                    "2 = Du bist so enttäuschend wie eine ungesalzene Brezel.\n" +
                    "3 = Die wahren Helden sind die Menschen, die dich jeden Tag tolerieren müssen.\n");

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
                    Console.ResetColor();

                    isCorrectInput = true;
                }
                else if (convertedChoice == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Du bist so enttäuschend wie eine ungesalzene Brezel.");
                    Console.ReadLine();
                    Console.ResetColor();
                    isCorrectInput = true;
                }
                else if (convertedChoice == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Die wahren Helden sind die Menschen, die dich jeden Tag tolerieren müssen.");
                    _player.CalculateDialoguepoints(+5);
                    Console.ReadLine();
                    Console.ResetColor();
                    isCorrectInput = true;
                }
            }
                    Console.Clear();
        }

        public void BattleDialogue3()
        {
            
            bool isCorrectInput = false;


            while (isCorrectInput == false)
            {
                Console.WriteLine("Wilderer:Meiner Meinung nach sind Tiere nur dazu da um Geld zu verdienen.\n" +
                     "1 = Du solltest eine Pflanze mit dir herumtragen, um den Sauerstoff zu ersetzen, den du verschwendest.\n" +
                     "2 = Das ist aber ganz schön viel Meinung für so wenig Ahnung.\n" +
                     "3 = Wenn Genialität eine Generation überspringt, dann werden deine Kinder brillant.\n");

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
                    Console.ResetColor();

                    isCorrectInput = true;
                }
                else if (convertedChoice == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Das ist aber ganz schön viel Meinung für so wenig Ahnung.");
                    _player.CalculateDialoguepoints(+5);
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
                    Console.ResetColor();
                    isCorrectInput = true;
                }
            }

                    Console.Clear();
        }

        public void BattleDialogue4()
        {
         
            bool isCorrectInput = false;


            while (isCorrectInput == false)
            {
                Console.WriteLine("Du wirst gleich herausfinden wie mein Stiefel schmeckt!\n" +
                    "1 = Zwei IQ-Punkte weniger und du bräuchtest Schuhe mit Klettverschluss.\n" +
                    "2 = Ist es nicht gefährlich, wenn du dein ganzes Vokabular in einem Satz benutzt?\n" +
                    "3 = Du bist der Beweis, dass die Evolution auch rückwärts funktioniert.\n");

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
                    _player.CalculateDialoguepoints(+5);
                    Console.ResetColor();

                    isCorrectInput = true;
                }
                else if (convertedChoice == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ist es nicht gefährlich, wenn du dein ganzes Vokabular in einem Satz benutzt?");
                    Console.ResetColor();
                    isCorrectInput = true;
                }
                else if (convertedChoice == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Du bist der Beweis, dass die Evolution auch rückwärts funktioniert.");
                    Console.ResetColor();
                    isCorrectInput = true;
                }
            }
                    Console.Clear();
        }

        /// <summary>
        /// Dialogue results/ Achievement´"Mindchanger" yes/no
        /// </summary>
        internal void Dialogueresult()
        {
            if (_player.DialoguePoints < 15)
            {
                Console.WriteLine("Wilderer: Jetzt reichts langsam, Kurzer.\n" +
                    "Entweder du verschwindest jetzt aus meinem Sichtfeld, oder du leistest meiner Beute Gesellschaft.\n" +
                    "Eingeschüchtert von seiner Drohung machst du auf der Stelle kehrt und verlässt das Lager.\n" +
                    "Die Schahm über deine Niederlage fügt dir körperliche Schmerzen zu\n");

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Du verlierst 10 Healthpoints");

                ConsoleText.Continue();

                _player.CalculateHealthpoints(-10);

                if (_player.HealthPoints <= 0)
                {
                    Gameover.GameOver("Die Schahm über deine Niederlage lässt dein Herz verkrampfen. Du stirbst noch an Ort und Stelle.");
                }
                    
            }
            else if (_player.DialoguePoints >= 15)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Wilderer: So hat noch niemand mit mir gesprochen. Aber vielleicht sollte ich meine Meinung noch einmal überdenken.\n" +
                    "Danke Kleiner. Manchmal brauchen auch die Erwachsenen einen Schups in die richtige Richtung. Denke ich werde mich nach einer \n" +
                    "anderen Arbeit umschauen.\n" +
                    "Du verabschiedest dich mit einem guten Gefühl im Bauch und wünschst ihm viel Glück bei der Jobsuche");

                ConsoleText.Continue();

                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Achievement unlocked: Mindchanger");
                Console.ReadLine();
                Console.ResetColor();
                Console.Clear();
            }
        }
    }
}
    
