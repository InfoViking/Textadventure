using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    
   
 
    internal static class Prologue
    {
        /// <summary>
        /// Character informations.
        /// </summary>
        public static void Character()
        {

            Player player = new Player();
            Console.WriteLine("Geben sie einen Namen für ihren Charakter ein.");
            


            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine("Alter: 18.");
            Console.WriteLine("Größe: 1,74m.");
            Console.WriteLine("Beruf: Schüler.");
            Console.WriteLine("Wesen: naiv,neugierig.");
            

            TextContinue.Textscroll();
            Console.ReadLine() ;
        }

        /// <summary>
        /// Prologue text
        /// </summary>
        public static void Intro()
        {
            Console.WriteLine("Du erwachst auf einem Waldweg. Es scheint tiefste Nacht zu sein.");
            Console.WriteLine("Hännschen: Wo bin ich? Was ist passiert?");
            Console.ReadLine();
            
            Console.WriteLine("Deine Erinnerung kehrt langsam zu dir zurück... ");
            Console.WriteLine("Du wurdest nach der Schule von den (coolen) Kids abgefangen." +
                              "Sie wollten dich in ihre Clique aufnehmen. Du solltest dich einer" +
                              "Prüfung im Wald stellen.");
            Console.ReadLine();

            Console.WriteLine("Sie verbanden dir die Augen. Das letzte an das du dich erinnern kannst " +
                "war ein Schlag auf deinen Hinterkopf. Danach wurde alles schwarz.");
            Console.ReadLine();

            Console.WriteLine("Du prüfst deine Taschen und deinen Rucksack.");
            Console.WriteLine("Hännschen: Diese miesen,verlogenen...");
            Console.WriteLine("Selbst deine Schulbücher waren weg. Nur der Energydrink in der Seitentasche war noch da.");
            Console.WriteLine("Hännschen: Ich muss nach Hause. Meine Eltern sind bestimmt krank vor Sorge ");
            Console.WriteLine("Und so begann dein außergewöhnlicher Weg nach Hause");
            Console.ReadLine();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("The Other Way Home");
            Console.ResetColor();

            TextContinue.Textscroll();
            Console.ReadLine();
            Console.Clear();

            




        }
       


      




        
     
    }
}
