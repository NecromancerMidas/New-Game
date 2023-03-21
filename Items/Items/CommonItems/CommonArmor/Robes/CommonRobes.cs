using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using New_Game.Items.CommonFiles;

namespace Items.Items.CommonItems.CommonArmor.LeatherArmor
{
    public class CommonRobes : New_Game.Items.Items
    {
        public CommonRobes(int Charlevel)
        {
            Type = "Armor";
            Name = "Robe";
            Rarity = "Common";
            Description = Robes.DescriptionGenerator.Generator(Name);
            ItemLevel = ItemLevelCalc(Charlevel, Rarity);
            Armor = WeaponStrengthCalc(ItemLevel);

        }

    }

}





