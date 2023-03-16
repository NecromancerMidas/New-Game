
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Game.Items.CommonItems.Swords;

namespace New_Game.Items.CommonFiles
{
    public class DrawWeaponStats
    {
        public static string DrawStats(Items Weapon)
        {
            string stats = $@"
Name: {Weapon.Name}
Itemlevel: {Weapon.ItemLevel} 
Rarity: {Weapon.Rarity} 
Weaponstrength:  {Weapon.WeaponStrength} 
Description: '{Weapon.Description}'{
    (Weapon.Intelligence == 0 ? null : $@"Intelligence: {Weapon.Intelligence}
")}{
    (Weapon.Strength == 0 ? null : $@"Strength: {Weapon.Strength}
")}{
    (Weapon.Agility == 0 ? null : $@"Agility: {Weapon.Agility}")}
";

            return stats;
        }
    }
}

