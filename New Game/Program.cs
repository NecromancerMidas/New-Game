// See https://aka.ms/new-console-template for more information




using System;
using Classes;

namespace Rpg
{

    class MainGame
    {


        static void Main(string[] args)
        {
            var Class = new CurrentClass();
            Console.WriteLine("Hello Midas");
            Console.WriteLine("hello again");
            Console.WriteLine();
            ChooseClass(Class);
            Console.WriteLine(Class.Health + " " + Class.Mana + " " + Class.Strength);


        }

        public static void ChooseClass(CurrentClass ChosenClass)
        {
            ConsoleKeyInfo Class = Console.ReadKey(true);

            if (Class.Key == ConsoleKey.W)
            {
                var war = new WarriorClass();
                Console.WriteLine("You have chosen Warrior");
                ChosenClass.Health = war.Health;
                ChosenClass.Mana = war.Mana;
                ChosenClass.Strength = war.Strength;
            }
            else if (Class.Key == ConsoleKey.M)
            {
                Console.WriteLine("You have chosen Mage");

            }
            else
            {
                Console.WriteLine("You have chosen Rogue");

            }

        }

    }
}
