// See https://aka.ms/new-console-template for more information




using System;
using System.Data;
using System.Runtime.CompilerServices;
using New_Game.Classes;
using New_Game.Introduction;
using New_Game.Items.CommonFiles;
using New_Game.Items.CommonItems.Swords;

namespace New_Game
{
    // its the main program, pretty neat huh?
    class MainGame
    {

        
        static void Main()
        {
            Console.SetWindowSize(200, 40);
            Console.Title = "Midas's Adventure";
            Console.ForegroundColor = ConsoleColor.Magenta;
 /*           var Rogue = new RogueClass();
            //var currentClass = new CurrentClass("string name", "string @class", 1, 2, 4, 3, 6, 3);
            var currentClass = new CurrentClass(Rogue);
            
            var Warrior = new CurrentClass("string name", "string @class", 1, 5, 2, 1, 6, 3);*/
            string intro = @"
 __       __  __        __                      __               ______         __                                 __                                        
/  \     /  |/  |      /  |                    /  |             /      \       /  |                               /  |                                       
$$  \   /$$ |$$/   ____$$ |  ______    _______ $$/______       /$$$$$$  |  ____$$ | __     __ ______   _______   _$$ |_    __    __   ______   ______        
$$$  \ /$$$ |/  | /    $$ | /      \  /       |$/       |      $$ |__$$ | /    $$ |/  \   /  /      \ /       \ / $$   |  /  |  /  | /      \ /      \       
$$$$  /$$$$ |$$ |/$$$$$$$ | $$$$$$  |/$$$$$$$/ /$$$$$$$/       $$    $$ |/$$$$$$$ |$$  \ /$$/$$$$$$  |$$$$$$$  |$$$$$$/   $$ |  $$ |/$$$$$$  /$$$$$$  |      
$$ $$ $$/$$ |$$ |$$ |  $$ | /    $$ |$$      \ $$      \       $$$$$$$$ |$$ |  $$ | $$  /$$/$$    $$ |$$ |  $$ |  $$ | __ $$ |  $$ |$$ |  $$/$$    $$ |      
$$ |$$$/ $$ |$$ |$$ \__$$ |/$$$$$$$ | $$$$$$  | $$$$$$  |      $$ |  $$ |$$ \__$$ |  $$ $$/ $$$$$$$$/ $$ |  $$ |  $$ |/  |$$ \__$$ |$$ |     $$$$$$$$/       
$$ | $/  $$ |$$ |$$    $$ |$$    $$ |/     $$/ /     $$/       $$ |  $$ |$$    $$ |   $$$/  $$       |$$ |  $$ |  $$  $$/ $$    $$/ $$ |     $$       |      
$$/      $$/ $$/  $$$$$$$/  $$$$$$$/ $$$$$$$/  $$$$$$$/        $$/   $$/  $$$$$$$/     $/    $$$$$$$/ $$/   $$/    $$$$/   $$$$$$/  $$/       $$$$$$$/ 

";
            Draw.Box(intro);

            Console.WriteLine($@"
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
                
               //var Class = (BaseCharacter)ClassChooser.ChooseClass();
               //var classChooser = new ClassChooser();
              var Class = ClassChooser.ChooseClass();
              var Sword = new CommonSwords(Class.Level);
              Draw.Box(DrawWeaponStats.DrawStats(Sword));
              Console.WriteLine("Please give yourself a name I recommend Midas its a good name.");
                Console.WriteLine();
                Class.ClassStringChanger(Console.ReadLine(),"name");
                Class.ClassStringChanger(Class.Class, "displayName");
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