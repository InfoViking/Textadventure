﻿namespace Textadventure
{
    internal class Chapter2
    {
        Player _player;
        public Chapter2(Player player)
        {
            _player = player;
        }
        internal void Beginning()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Wandloses Labyrinth");
            Textscroll.TextScroll();
            Console.WriteLine("Der Wald lichtet sich und du betrittst einen Hain.\n" +
                "Als du genauer hinsiehst siehst du dutzende Pflöcke welche in den Boden getrieben wurden.\n" +
                "Während du versuchst zu verstehen was es damit auf sich hat, siehst du wie ein Reh den Hain betritt.\n" +
                "Als es dich bemerkt rennt es schnurstracks in Richtung der Pflöcke.\n" +
                "Kurz darauf hörst du ein metallisches Geräusch, gefolgt von einem schmerzerfüllten Schrei des Rehs.\n" +
                "Danach... Stille.\n");
            Console.ReadLine();
            Console.WriteLine("Dir wird schlagartig heiß und kalt. Du versuchst mit der Taschenlampe zu sehen was passiert ist.\n" +
                "Hättest du es doch besser gelassen.\n" +
                "Der gesamte Bereich ist übersäht mit Tierkadavern. Du versuchst nicht laut loszuschreien.\n" +
                "Nachdem du dich beruhigt hast erinnerst du dich daran, \n" +
                "dass eine Bande Wilderer in diesem Wald ihr Unwesen treibt.\n");
            Textscroll.TextScroll();
            Console.WriteLine($"{_player.Name}: Was für eine Barberei. Wenn ich versuche hier einfach durchzulaufen wird es mir nicht anders ergehen. ");
            Textscroll.TextScroll();


            if (_player.IsGoatMaster)
            {
                Console.WriteLine("Dein neuer Begleiter schreitet unbeirrt voran.\n " +
                    "Nach ein paar Metern dreht er sich zu dir um und scheint auf dich zu warten.\n" +
                    "Offenbar möchte die Ziege, dass du ihr folgst.\n" +
                   $"{_player.Name}: Ich lege mein Leben in die Hände einer Ziege. Vielleicht sollte ich meinen Kopf untersuchen lassen.\n" +
                    "Du folgst deinem Begleiter durch das Feld aus Fallen. Und tatsächlich scheint die Ziege zu wissen was sie tut.\n" +
                    "Du kommst unbeschadet auf der anderen Seite des Hains an.\n" +
                    "Die Ziege entdeckt einen Strauch mit Heidelbeeren und macht sich direkt darüber her.\n" +
                    "Sie macht keine Anstalten dir weiterhin folgen zu wollen\n" +
                    "Schweren Herzens setzt du deine Reise alleine fort\n");

                return;
            }


            Console.WriteLine("Nach langem grübeln fällt dir ein Pflock auf, der ein wenig abseits steht.\n" +
                "Es scheint etwas eingeritzt worden zu sein.\n");
            Textscroll.TextScroll();
            Console.WriteLine("Start 2xV, 1xR, 2xV, 2xL, 3xV \n");
            
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Hinweis: Diese" +
                " Nachricht wird dir nur einmal angezeigt.\n" +
                "Präge dir gut ein was dort steht. Falls nicht wird es schmerzhaft.\n" +
                "Steuerung: Pfeiltaste links = links \n" +
                           "Pfeiltaste rechts = rechts \n" +
                           "Pfeiltaste hoch = vorwärts \n");
            Textscroll.TextScroll();
            Console.WriteLine("Nachdem du dir die Nachricht ausgiebig eingeprägt hast setzt du deinen Weg fort. \n");
            Textscroll.TextScroll();

            List<ConsoleKey> pressedkeys = GetLabyrinthKeys();
            List<ConsoleKey> correctkeys = CorrectLabyrinthKeys();
            int multiplier = CountFailures(pressedkeys,correctkeys);
            int calculator = DamageCalculator(multiplier);
            _player.CalculateHealthpoints(-calculator);

            if (_player.HealthPoints <= 0 )
            {
                Gameover.GameOver("Dein Mangel an Orientierung wird dir zum Verhängis. Nach einem knacken gibt der Boden nach\n" +
                    "und du fällst in eine Fallgrube voller spitzer Pfähle.");
            }

            
            


            if (multiplier > 0)
            {
                Wrongchoices(multiplier, calculator);
            }
            else
            {
                Rightchoices();
            }

            
        }



        internal List<ConsoleKey> GetLabyrinthKeys()
        {
            List<ConsoleKey> pressedkeys = new List<ConsoleKey>();

            for (int i = 0; i < 10; i++)
            {//Schneidet einen String zurecht.
                ConsoleKeyInfo keypressed = Console.ReadKey();
                string keystring = keypressed.Key.ToString();
                string key = keystring.Substring(0, keystring.Length - 5);

                Console.WriteLine($"{key}");
                
                pressedkeys.Add(keypressed.Key);
            }
            return pressedkeys;
        }

       
        internal List<ConsoleKey> CorrectLabyrinthKeys()
        { //Correct Inputs: 2xV, 1xR, 2xV, 2xL, 3xV

            List<ConsoleKey> correctkeys = new List<ConsoleKey>();
            correctkeys.Add(ConsoleKey.UpArrow);
            correctkeys.Add(ConsoleKey.UpArrow);
            correctkeys.Add(ConsoleKey.RightArrow);
            correctkeys.Add(ConsoleKey.UpArrow);
            correctkeys.Add(ConsoleKey.UpArrow);
            correctkeys.Add(ConsoleKey.LeftArrow);
            correctkeys.Add(ConsoleKey.LeftArrow);
            correctkeys.Add(ConsoleKey.UpArrow);
            correctkeys.Add(ConsoleKey.UpArrow);
            correctkeys.Add(ConsoleKey.UpArrow);

            return correctkeys;
        }

        internal int CountFailures(List<ConsoleKey> userInput, List<ConsoleKey> correctInput)
        {
            int multiplier = 0;

            for (int i = 0; i < 10; i++)
            { 
                if (userInput[i] != correctInput[i])
                {
                    multiplier++;
                }
            }

            return multiplier;

        }

        internal int DamageCalculator(int multiplier, int damage = 2)
        {
            int damageMultiplier = multiplier * damage;
            return damageMultiplier;
        } 

        
        
        internal void Wrongchoices(int multiplier, int damage)
        {
            Console.WriteLine($@"Dein überragender Intellekt ließ dich {multiplier} mal im Stich.
                 Du erhälst {damage} Schaden. Angeschlagen setzt du deine Reise weiter fort.");

            

        }
        
        internal void Rightchoices()
        {
            Console.WriteLine("Dein überragender Intellekt sorgte dafür, dass du in der Lage warst, das Labyrinth unbeschadet zu durchqueren.\n " +
                "Du setzt deine Reise weiter fort.");
        }

        
    }
    
}
