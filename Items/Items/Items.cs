using Common;
using System;

namespace New_Game.Items
{


    public class Items
    {
        public string Type { get; protected set; }
        public int level { get; protected set; }
        public string Rarity { get; protected set; }
        public int ItemLevel { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public int WeaponStrength { get; protected set; }
        public int Strength { get; protected set; }
        public int Agility { get; protected set; }
        public int Intelligence { get; protected set; }

        public int Armor { get; protected set; }

        public static int ItemLevelCalc(int level, string rarity)
        {
            if (rarity == "Common")
            {
                return level * Randomer.Randomizer(5, 8);
            }
            else if (rarity == "Rare")
            {
                return level * Randomer.Randomizer(8, 10);
            }
            else if (rarity == "Epic")
            {
                return level * Randomer.Randomizer(10, 12);
            }
            else if (rarity == "Legendary")
            {
                return level * Randomer.Randomizer(12, 15);
            }

            return 0;
        }

        public static int WeaponStrengthCalc(int level)
        {

            return level * Randomer.Randomizer(1, 4);
        }

        public string DrawArmorStats()
        {
            string stats = $@"
Name: {Name}
Itemlevel: {ItemLevel} 
Rarity: {Rarity} 
Armor:  {Armor} 
Description: '{Description}'{(Intelligence == 0 ? null : $@"Intelligence: {Intelligence}
")}{(Strength == 0 ? null : $@"Strength: {Strength}
")}{(Agility == 0 ? null : $@"Agility: {Agility}")}
";

            return stats;
        }
        public string DrawWeaponStats()
        {
            string stats = $@"
Name: {Name}
Itemlevel: {ItemLevel} 
Rarity: {Rarity} 
Weaponstrength:  {WeaponStrength} 
Description: '{Description}'{(Intelligence == 0 ? null : $@"Intelligence: {Intelligence}
")}{(Strength == 0 ? null : $@"Strength: {Strength}
")}{(Agility == 0 ? null : $@"Agility: {Agility}")}
";

            return stats;
        }
        public Items()
        {


        
    }
    }
}


