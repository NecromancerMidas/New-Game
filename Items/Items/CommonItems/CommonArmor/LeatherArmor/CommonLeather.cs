using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using New_Game.Items.CommonFiles;

namespace Items.Items.CommonItems.CommonArmor.LeatherArmor
{
    public class CommonLeather : New_Game.Items.Items
    {
        public CommonLeather(int Charlevel)
        {
            Type = "Armor";
            Name = "Leather";
            Rarity = "Common";
            Description = DescriptionGenerator.Generator(Name);
            ItemLevel = ItemLevelCalc(Charlevel, Rarity);
            Armor = WeaponStrengthCalc(ItemLevel);

        }

    }

}





