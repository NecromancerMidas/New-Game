using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace New_Game.Introduction
{
    internal class Introduction
    {
        public static void Intro()
        {
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
            }
            else
            {
                Console.Clear();
                Intro();
            }

        }
    }
}
