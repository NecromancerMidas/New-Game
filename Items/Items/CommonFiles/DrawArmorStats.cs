using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items.Items.CommonFiles
{
    public class DrawArmorStats
    { 
        public static string DrawStats(New_Game.Items.Items Armor)
            {
                string stats = $@"
Name: {Armor.Name}
Itemlevel: {Armor.ItemLevel} 
Rarity: {Armor.Rarity} 
Armor:  {Armor.Armor} 
Description: '{Armor.Description}'{(Armor.Intelligence == 0 ? null : $@"Intelligence: {Armor.Intelligence}
")}{(Armor.Strength == 0 ? null : $@"Strength: {Armor.Strength}
")}{(Armor.Agility == 0 ? null : $@"Agility: {Armor.Agility}")}
";

                return stats;
            }
        }
    }

