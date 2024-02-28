using System;

namespace Textadventure
{
    /// <summary>
    /// Constructor Player Class
    /// </summary>
    internal class Chapter1
    {
        Player _player;
        public Chapter1(Player player)
        {
            _player = player;
        }

        /// <summary>
        /// Intro Chapter 1
        /// </summary>
        public void Beginning()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Der Scheideweg");
            ConsoleText.Continue();
            Console.WriteLine("Du beschließt fürs Erste dem Weg zu folgen auf dem du erwacht bist.\n" +
                "Nach einer Weile bemerkst du vor dir, ein schwaches Leuchten. Als du dich näherst,\n" +
                "erkennst du die Lichtquelle. Erleichterung durchströmt deinen Körper.");
            ConsoleText.Continue();
            Console.WriteLine($"{_player.Name}:Ein Handy! Ich bin gerettet!");
            ConsoleText.Continue();
            Console.WriteLine("Du schaltest das Handy ein und deine Hoffnung verfliegt so schnell,\n" +
                "wie sie gekommen war.\n" +
                "Kein Empfang. Nicht einmal Notrufe sind verfügbar. Jedoch bemerkst du etwas merkwürdiges.\n" +
                "Es befindet sich nur eine einzige App auf dem Handy.\n");
            ConsoleText.Continue();
            Console.WriteLine($"{_player.Name}:MediServApp. Mh. Das ist doch diese großartige Bank für \n" +
                "medizinische Transaktionen.\n" +
                "Bekannt aus Funk und Fernsehen und dazu noch weltweit geschätzt und anerkannt. ");
            ConsoleText.Continue();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Hinweis: Gutes/Schlechtes Ende.\n" +                                     
                "Wenn du auf deiner Reise verletzt wirst, musst du am Ende medizinische\n" +           
                "Leistungen in Anspruch nehmen. Du willst schließlich nicht, dass sich deine\n" +       
                "Eltern noch mehr Sorgen machen. " +
                "Die Kosten der medizinischen Leistungen hängen von deinen Lebenspunkten am Ende\n" +   
                "des Abenteuers ab\n" +                                                             
                "Je weniger Lebenspunkte, desto kostspieliger die Leistungen, desto größer der Ärger,\n" +
                "der dich zu Hause erwartet.\n" +                                                    
                "Versuche gesund zu bleiben und sei vorsichtig.\n");                                 
            ConsoleText.Continue();
            Console.WriteLine("Nachdem du sich mit den Funktionen vertraut gemacht hast, setzt du deinen Weg nach Hause weiter fort.\n" +
                "Nach einer Weile gabelt sich der Weg in zwei Richtungen. Du leuchtest mit der Taschenlampe des Handys die Wege aus.\n");
            ConsoleText.Continue();
            Console.WriteLine("Der linke Weg scheint deutlich schlechter ausgebaut zu sein. Einige Dornenranken wuchern über den Weg\n" +
                "und Schlaglöcher bergen die Gefahr dich, bei einem falschen Schritt, zu verletzen.\n" +
                "Der rechte Weg sieht, im Vergleich, deutlich besser aus. Allerdings bemerkst du auf dem Boden Fußspuren.\n" +
                "Als du sie genauer untersuchst stellst du fest, dass diese Fußspuren definitiv nicht von Menschen stammen.\n" +
                "Du kannst sie keinem Tier zuordnen. Je länger du sie untersuchst desto unwohler fühlst du dich.\n");
            ConsoleText.Continue();
            Decision1();
        }

        /// <summary>
        /// Bool query decision
        /// </summary>
        internal void Decision1()
        {
            

            bool isCorrectInput = false;

                while (isCorrectInput == false)
            {
                Console.WriteLine($"{_player.Name}: Jeder der Wege hat seine Unsicherheiten. Aber ich muss weiter. Zurückgehen ist keine Option \n" +
                "Ich entscheide mich für...\n" +
                "1 = Linker Weg\n" +
                "2 = Rechter Weg\n");

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
                    Leftway();
                    ConsoleText.Continue();

                    isCorrectInput = true;
                }
                else if (convertedChoice == 2)
                {
                    Rightway();
                    ConsoleText.Continue();

                    isCorrectInput = true;
                }

                
            }
        }

        /// <summary>
        /// possible choices 1
        /// </summary>
        internal void Leftway()
        {
            Console.WriteLine($"{_player.Name}: Diese Tierspuren sind mir nicht geheuer.\n" +
                $"Ich lege mich lieber mit ein paar Dornen und Schlaglöchern an, als mit einer wilden Bestie.\n" +
                "Du setzt deine Reise auf dem linken Pfad fort.\n");
            ConsoleText.Continue();
            Console.WriteLine("Und es kam wie es kommen musste. Nach einem Moment der Unachtsamkeit trittst du\n" +
                "ins Leere und fällst mit dem Gesicht vorran in einen Dornenbusch.\n" +
                "Du spürst wie die Dornen sich in deine Haut arbeiten und kleine Kratzer hinterlassen.\n" +
                "Außerdem spürst du einen leichten Schmerz in deinem linken Knöchel.");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Du erleidest 10 Schaden\n");
            ConsoleText.Continue();

            _player.CalculateHealthpoints(-10);

            Console.WriteLine("Während du dich aufrichtest, schießen dir sämtliche Flüche die du kennst durch den Kopf.\n" +
                "Du klopfst dir den Schmutz vom Körper und schreitest weiter vorran.\n ");
            ConsoleText.Continue();
        }

        internal void Rightway()
        {
            Console.WriteLine($"{_player.Name}: Die Chance mich auf dem linken Weg zu verletzen scheint recht hoch... \n" +
                $"zwar jagt mir der Gedanke an das Tier Angst ein, jedoch komme ich auf dem rechten Pfad schneller vorwärts.\n" +
                "Du setzt deine Reise auf dem rechten Pfad fort\n");
            ConsoleText.Continue();
            Console.WriteLine("Während du den Weg beschreitest macht sich Paranoia in dir breit.\n" +
                "Jedes Geräusch lässt dich zusammenzucken.\n" +
                "Du spürst wie dich jemand oder etwas beobachtet. Plötzlich springt etwas vor dir aus dem Gebüsch.\n");
            ConsoleText.Continue();
            Console.WriteLine("Panisch reißt du die Taschenlampe deines Handys hoch und richtest sie auf das Biest.\n" +
                "Du starst direkt in die Augen eines Ziegenbocks. \n" +
                "Einerseits bist du erleichtert darüber, dass es nur eine Ziege ist.\n" +
                "Andererseits schwingt auch ein wenig Ärger mit,\n" +
                "da es eine Ziege geschafft hat dir Todesangst einzujagen \n");
            ConsoleText.Continue();
            Decision2();

        }
        internal void Decision2()
        {
            bool isCorrectInput = false;

            while (isCorrectInput == false)
            {
                Console.WriteLine("Du entscheidest dich den Ziegenbock zu...\n" +
                "1 = Streicheln\n" +
                "2 = Verjagen\n");

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
                    Pet();
                    Console.ReadLine();

                    isCorrectInput = true;
                }
                else if (convertedChoice == 2)
                {
                    Scare();
                    Console.ReadLine();

                    isCorrectInput = true;
                }

            }
        }    
                
            
        

        /// <summary>
        /// follow up choices
        /// </summary>
        internal void Pet()
        {
            Console.WriteLine("Du kniest dich hin und streckst deinen Arm aus.\n" +
                "Vorsichtig aber neugierig nähert sich der Ziegenbock bis er deine Hand erreicht. \n" +
                "Du streichselst ihm über den Kopf, was er mit einem fröhlichen Määääh quittiert.\n" +
                "Als du dich aufrichtest und weitergehen willst scheint \n" +
                "es als würde der Ziegenbock dir folgen.\n");
            ConsoleText.Continue();
            Console.WriteLine($"{_player.Name}: Scheinst wohl auch von hier weg zu wollen. Mir solls Recht sein.\n" +
                $"Ein bisschen Gesellschaft tut uns beiden gut.\n");

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Achievement unlocked: Goatmaster");
            

            _player.IsGoatMaster = true;
        }

        internal void Scare()
        {
            Console.WriteLine("Du bäumst dich auf und stößt einen ,deiner Meinung nach, markerschütternden Schrei aus.\n" +
                "Der Ziegenbock zeigt sich davon allerdings nur wenig beeindruckt, nimmt Anlauf und\n" +
                "rammt dich mit seinen Hörnern zu Boden. Seinen Sieg über dich quittiert er mit einem Määäh\n" +
                "und entschwindet in die Dunkelheit.");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Du erleidest 10 Schaden\n");
            ConsoleText.Continue();

            _player.CalculateHealthpoints(-10);

            
            Console.WriteLine("Nachdem der Schmerz etwas nachlässt und du die Tatsache verarbeitet hast,\n" +
                "dass dich eine Ziege besiegt hat setzt du deinen Weg mit gekränktem Ego fort.");
            
        }
    }
}


