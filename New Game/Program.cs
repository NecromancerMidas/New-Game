// See https://aka.ms/new-console-template for more information




using System;
using System.Data;
using Classes;

namespace New_Game
{

    class MainGame
    {


        static void Main()
        {
            Console.SetWindowSize(200, 40);
            Console.Title = "Midas's Adventure";
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
                string classChoice = @"
Please choose a class. Your options 
W: Warrior
M: Mage
R: Rogue
Choose Wisely
";

                Draw.Box(classChoice);
                ClassChooser.ChooseClass(Class);
                Console.WriteLine("Please give yourself a name I recommend Midas its a good name.");
                Console.WriteLine();
                Class.Name = Console.ReadLine() + " the " + Class.Class;
                Console.WriteLine(Stats.DrawStats(Class));
                Draw.Box(Stats.DrawStats(Class));
                CharacterIntroduction.Choices(Class);
            }
            else
            {
                Console.Clear();
                Main();
            }



        }

    }
}