using New_Game.Classes;
using System;
using System.Security.Claims;

namespace New_Game.Classes
{

    /*Chooses a class based on user input, recurs on failure. Returns and assigns class template */
    static class ClassChooser
    {
        
        public static BaseCharacter ChooseClass()
        {
            
            ConsoleKeyInfo Class = Console.ReadKey(true);
            
            if (Class.Key == ConsoleKey.W)
            {
                
                Console.WriteLine("You have chosen Warrior");
                return new WarriorClass();
            }
            else if (Class.Key == ConsoleKey.M)
            {
                ;
                Console.WriteLine("You have chosen Mage");
                return new MageClass();
            }
            else if (Class.Key == ConsoleKey.R)
            {
                
                Console.WriteLine("You have chosen Rogue");
                return new RogueClass();

            }
            else
            {
                Console.WriteLine("You have to choose a class. W: Warrior, M: Mage, R: Rogue.");
                ChooseClass();
                return new WarriorClass();

            }

        }

    }
}


/*public class ClassChooser
{
    public static void ChooseClass(CurrentClass ChosenClass)
    {
        ConsoleKeyInfo Class = Console.ReadKey(true);

        if (Class.Key == ConsoleKey.W)
        {
            var war = new WarriorClass();
            Console.WriteLine("You have chosen Warrior");
            ChosenClass.Level = war.Level;
            ChosenClass.Class = war.Class;
            ChosenClass.Health = war.Health;
            ChosenClass.Mana = war.Mana;
            ChosenClass.Strength = war.Strength;
            ChosenClass.Agility = war.Agility;
            ChosenClass.Intelligence = war.Intelligence;
        }
        else if (Class.Key == ConsoleKey.M)
        {
            var mag = new MageClass();
            Console.WriteLine("You have chosen Mage");
            ChosenClass.Level = mag.Level;
            ChosenClass.Class = mag.Class;
            ChosenClass.Health = mag.Health;
            ChosenClass.Mana = mag.Mana;
            ChosenClass.Strength = mag.Strength;
            ChosenClass.Agility = mag.Agility;
            ChosenClass.Intelligence = mag.Intelligence;
        }
        else if (Class.Key == ConsoleKey.R)
        {
            var rog = new RogueClass();
            Console.WriteLine("You have chosen Rogue");
            ChosenClass.Level = rog.Level;
            ChosenClass.Class = rog.Class;
            ChosenClass.Health = rog.Health;
            ChosenClass.Mana = rog.Mana;
            ChosenClass.Strength = rog.Strength;
            ChosenClass.Agility = rog.Agility;
            ChosenClass.Intelligence = rog.Intelligence;
        }
        else
        {
            Console.WriteLine("You have to choose a class. W: Warrior, M: Mage, R: Rogue.");
            ChooseClass(ChosenClass);
        }

    }

}*/