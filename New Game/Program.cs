// See https://aka.ms/new-console-template for more information




using System;
using System.Data;
using System.Runtime.CompilerServices;
using Common;
using Items.Items.CommonFiles;
using Items.Items.CommonItems.CommonArmor.LeatherArmor;
using Items.Items.CommonItems.CommonArmor.Plate;
using Items.Items.CommonItems.CommonWeapons.Daggers;
using Items.Items.CommonItems.CommonWeapons.Staves;
using Items.Items.CommonItems.CommonWeapons.Swords;
using New_Game.Classes;
using New_Game.Introduction;
using New_Game.Items.CommonFiles;
using New_Game.Items.CommonItems.Daggers;
using New_Game.Items.CommonItems.Swords;
using New_Game.Items.CommonItems.Staves;
using System.Security.Cryptography;

namespace New_Game
{
    // its the main program, pretty neat huh?
    class MainGame
    {


        public static void Main()
        {
            Console.SetWindowSize(200, 40);
            Console.Title = "Midas's Adventure";
            Console.ForegroundColor = ConsoleColor.Magenta;
            /*           var Rogue = new RogueClass();
                       //var currentClass = new CurrentClass("string name", "string @class", 1, 2, 4, 3, 6, 3);
                       var currentClass = new CurrentClass(Rogue);
                       
                       var Warrior = new CurrentClass("string name", "string @class", 1, 5, 2, 1, 6, 3);*/

            Introduction.Introduction.Intro();
            //var Class = (BaseCharacter)ClassChooser.ChooseClass();
            //var classChooser = new ClassChooser();
            var Class = ClassChooser.ChooseClass();
            var Sword = new CommonSwords(Class.Level);
            var Dagger = new CommonDaggers(Class.Level);
            var Staff = new CommonStaves(Class.Level);
            var Plate = new CommonPlate(Class.Level);
            var Leather = new CommonLeather(Class.Level);
            var Robe = new CommonRobes(Class.Level);
            Draw.Box(DrawWeaponStats.DrawStats(Staff));
            Draw.Box(DrawWeaponStats.DrawStats(Dagger));
            Draw.Box(DrawWeaponStats.DrawStats(Sword));
            Draw.Box(DrawArmorStats.DrawStats(Plate));
            Draw.Box(DrawArmorStats.DrawStats(Leather));
            Draw.Box(DrawArmorStats.DrawStats(Robe));
            Console.WriteLine("Please give yourself a name I recommend Midas its a good name.");
            Console.WriteLine();
            Class.ClassStringChanger(Console.ReadLine(), "name");
            Class.ClassStringChanger(Class.Class, "displayName");
            Draw.Box(Stats.DrawStats(Class));
            CharacterIntroduction.Choices(Class);
        }



    }

}