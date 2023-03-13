using System;
using System.Net.Security;
using System.Security.Claims;


namespace Classes {
    
    
    public class WarriorClass
    
    {
        public int Level = 1;
        public int Exp = 0;
        public string Class = "Warrior";
        public int Health = 2000;
        public int Mana = 250;
        public int Strength = 40;
        public int Agility = 15;
        public int Intelligence = 10;

}
    public class MageClass

    {
       public int Level = 1;
        public string Class = "Mage";
        public int Health = 1000;
       public int Mana = 500;
       public int Strength = 20;
       public int Agility = 10;
        public int Intelligence = 40;

    }
    public class RogueClass

    {
        public int Level = 1;
        public string Class = "Rogue";
        public int Health = 1250;
        public int Mana = 300;
        public int Strength = 25;
        public int Agility = 40;
        public int Intelligence = 20;

    }
    public class CurrentClass
    {
        public string? Name;
        public string? Class;
        public int Level;
        public int Health;
        public int Mana;
        public int Strength;
        public int Agility;
        public int Intelligence;
        public List<string> Traits = new List<string>();

    }
    public class ClassChooser
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

    }
      public class Stats {
      public static string DrawStats(CurrentClass Class) {
            string stats = $@"
Name: {Class.Name}
Level: {Class.Level} 
Health: {Class.Health} 
Mana:  {Class.Mana} 
Strength: {Class.Strength} 
Agility:  {Class.Agility}
Intelligence: {Class.Intelligence}
";

            return stats;
      }
    }
}
