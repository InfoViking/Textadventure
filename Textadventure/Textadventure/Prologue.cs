using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace Textadventure
{
    internal class Prologue
    {
        Player _player;
        public Prologue(Player player)
        {
            _player = player;
        }
        /// <summary>
        /// Character informations.
        /// </summary>
        internal static Player Character()
        {
            Player player = new Player();
            Console.WriteLine("Bitte geben sie einen Namen für ihren Charakter ein");
            string name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Fehlermeldung 418: Es muss ein Name eingetragen werden.");
                Console.WriteLine("Geben sie einen Namen für ihren Charakter ein.");
                name = Console.ReadLine();
            }

            player.Name = name;
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine("Alter: 18.");
            Console.WriteLine("Größe: 1,74m.");
            Console.WriteLine("Beruf: Schüler.");
            Console.ReadLine();

            return player;

        }

        /// <summary>
        /// Prologue text
        /// </summary>
        internal void Intro()
        {
            Console.WriteLine("Du erwachst auf einem Waldweg. Es scheint tiefste Nacht zu sein.");
            Console.WriteLine($"{_player.Name}: Wo bin ich? Was ist passiert?");
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
            Console.WriteLine($"{_player.Name}: Diese miesen,verlogenen...");
            Console.WriteLine("Selbst deine Schulbücher waren weg. Nur der Energydrink in der Seitentasche war noch da.");
            Console.WriteLine($"{_player.Name}: Ich muss nach Hause. Meine Eltern sind bestimmt krank vor Sorge ");
            Console.WriteLine("Und so begann dein außergewöhnlicher Weg nach Hause");
            Console.ReadLine();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("The Other Way Home");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
        }
    }
}
