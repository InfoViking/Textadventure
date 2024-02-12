using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    internal class Chapter1deci
    {
        public static void Leftway()
        {
            Console.WriteLine("Hännschen: Diese Tierspuren sind mir nicht geheuer. Ich lege mich lieber mit ein paar Dornen und Schlaglöchern an als mit einer wilden Bestie." +
                "Du setzt deine Reise auf dem linken Pfad fort.");
            
            TextContinue.Textscroll();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Und es kam wie es kommen musste. Nach einem Moment der Unachtsamkeit trittst du ins Leere und fällst mit dem Gesicht vorran in einen Dornenbusch." +
                "Du spürst wie die Dornen sich in deine Haut arbeiten und kleine Kratzer hinterlassen. Außerdem spürst du einen leichten Schmerz in deinem linken Knöchel." +
                "Du bekommst 5 Schaden");

            // -5 Healthpoints //
            

            Console.WriteLine("Während du dich aufrichtest schießen dir sämtliche Flüche die du kennst durch den Kopf. " +
                "Du klopfst dir den Schmutz vom Körper und schreitest weiter vorran.");

            TextContinue.Textscroll();
            Console.ReadLine();
            Console.Clear();

        }

        public static void Rightway()
        {
            Console.WriteLine("Hännschen: Die Chance mich auf dem linken Weg zu verletzen scheint recht hoch... zwar jagt mir der Gedanke an das Tier Angst ein, jedoch komme ich auf dem rechten Pfad schneller vorwärts." +
                "Du setzt deine Reise auf dem rechten Pfad fort");

            TextContinue.Textscroll();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Während du den Weg beschreitest macht sich Paranoia in dir breit. Jedes Geräusch lässt dich zusammen zucken. " +
                "Du spürst wie dich jemand oder etwas beobachtet. Plötzlich springt etwas vor dir aus dem Gebüsch.");

            TextContinue.Textscroll();
            Console.ReadLine();

            Console.WriteLine("Panisch reißt du die Taschenlampe deines Handys hoch und richtest sie auf das Biest. Du starst direkt in die Augen eines Ziegenbocks. " +
                "Einerseits bist du erleichtert darüber, dass es nur eine Ziege ist. Andererseits schwingt auch ein wenig Ärger mit da es eine Ziege geschafft hat dir Todesangst einzujagen");

            TextContinue.Textscroll();
            Console.ReadLine();
            Console.Clear();    

            Console.WriteLine("Du entscheidest dich den Ziegenbock zu...");

            //implement choice "streicheln/verjagen"

            static void pet()
            {
                Console.WriteLine("Du kniest dich hin und streckst deinen Arm aus. Vorsichtig aber neugierig nähert sich der Ziegenbock bis er deine Hand erreicht. " +
                    "Du streichselst ihm über den Kopf, was er mit einem fröhlichen Määääh quitiert. Als du dich aufrichtest und weiter gehen willst scheint " +
                    "es als würde der Ziegenbock dir folgen");

                TextContinue.Textscroll();
                Console.ReadLine();

                Console.WriteLine("Hännschen: Scheinst wohl auch von hier weg zu wollen. Mir solls Recht sein. Ein bisschen Gesellschaft tut uns beiden gut.");

                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Achievement unlocked: Goatmaster");

                
                TextContinue.Textscroll();
                Console.ReadLine();
                Console.ResetColor();
                Console.Clear();

            }

            static void scare()
            {
                Console.WriteLine("Du bäumst dich auf und stößt einen ,deiner Meinung nach, markerschütternden Schrei aus. Der Ziegenbock zeigt sich davon allerdings nur wenig beeindruckt, nimmt Anlauf und" +
                    "rammt dich mit seinen Hörnern zu Boden. Seinen Sieg über dich quitiert er mit einem Määäh und entschwindet in die Dunkelheit." +
                    "Du erhälst 10 Schaden. ");

                //-10 Healthpoints//

                TextContinue.Textscroll();
                Console.ReadLine();

                Console.WriteLine("Nachdem der Schmerz etwas nachlässt und du die Tatsache verarbeitet hast, dass dich eine Ziege besiegt hat setzt du deinen Weg mit gekränktem Ego fort");

                TextContinue.Textscroll();
                Console.ReadLine();
                Console.Clear();

            }
        }


    }
}
