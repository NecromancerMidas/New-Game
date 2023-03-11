// See https://aka.ms/new-console-template for more information




using System;
using System.Data;
using Classes;

namespace Rpg
{

    class MainGame
    {


        static void Main()
        {
            Console.SetWindowSize(200, 40);
            Console.Title = "My Game";
            Console.ForegroundColor = ConsoleColor.Magenta;
            var Class = new CurrentClass();
            Console.WriteLine(@"
 __       __  __        __                      __               ______         __                                 __                                        
/  \     /  |/  |      /  |                    /  |             /      \       /  |                               /  |                                       
$$  \   /$$ |$$/   ____$$ |  ______    _______ $$/______       /$$$$$$  |  ____$$ | __     __ ______   _______   _$$ |_    __    __   ______   ______        
$$$  \ /$$$ |/  | /    $$ | /      \  /       |$/       |      $$ |__$$ | /    $$ |/  \   /  /      \ /       \ / $$   |  /  |  /  | /      \ /      \       
$$$$  /$$$$ |$$ |/$$$$$$$ | $$$$$$  |/$$$$$$$/ /$$$$$$$/       $$    $$ |/$$$$$$$ |$$  \ /$$/$$$$$$  |$$$$$$$  |$$$$$$/   $$ |  $$ |/$$$$$$  /$$$$$$  |      
$$ $$ $$/$$ |$$ |$$ |  $$ | /    $$ |$$      \ $$      \       $$$$$$$$ |$$ |  $$ | $$  /$$/$$    $$ |$$ |  $$ |  $$ | __ $$ |  $$ |$$ |  $$/$$    $$ |      
$$ |$$$/ $$ |$$ |$$ \__$$ |/$$$$$$$ | $$$$$$  | $$$$$$  |      $$ |  $$ |$$ \__$$ |  $$ $$/ $$$$$$$$/ $$ |  $$ |  $$ |/  |$$ \__$$ |$$ |     $$$$$$$$/       
$$ | $/  $$ |$$ |$$    $$ |$$    $$ |/     $$/ /     $$/       $$ |  $$ |$$    $$ |   $$$/  $$       |$$ |  $$ |  $$  $$/ $$    $$/ $$ |     $$       |      
$$/      $$/ $$/  $$$$$$$/  $$$$$$$/ $$$$$$$/  $$$$$$$/        $$/   $$/  $$$$$$$/     $/    $$$$$$$/ $$/   $$/    $$$$/   $$$$$$/  $$/       $$$$$$$/ ");
            Console.WriteLine(@"
Welcome to Midas's Adventure, a small rpg game I created for fun. 
Please press your Enter key to start");
            ConsoleKeyInfo ifEnter = Console.ReadKey(true);
            if (ifEnter.Key == ConsoleKey.Enter)
            {
                Console.WriteLine(@"
Please choose a class. Your options 
W: Warrior
M: Mage
R: Rogue
Choose Wisely
");
                ChooseClass(Class);
                Console.WriteLine(Class.Health + " " + Class.Mana + " " + Class.Strength);
            }
            else {
                Console.Clear();
                Main();
            }



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
                var mag = new MageClass();
                Console.WriteLine("You have chosen Mage");
                ChosenClass.Health = mag.Health;
                ChosenClass.Mana = mag.Mana;
                ChosenClass.Strength = mag.Strength;

            }
            else if (Class.Key == ConsoleKey.R)
            {
                var rog = new RogueClass();
                Console.WriteLine("You have chosen Rogue");
                ChosenClass.Health = rog.Health;
                ChosenClass.Mana = rog.Mana;
                ChosenClass.Strength = rog.Strength;
            }
            else
            {
                Console.WriteLine("You have to choose a class. W: Warrior, M: Mage, R: Rogue.");
                ChooseClass(ChosenClass);
            }

        }

    }
}
