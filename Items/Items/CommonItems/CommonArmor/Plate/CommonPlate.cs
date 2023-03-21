using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using New_Game.Items.CommonFiles;

namespace Items.Items.CommonItems.CommonArmor.Plate
{
    public class CommonPlate : New_Game.Items.Items
    {
        public CommonPlate(int Charlevel)
        {
            Type = "Armor";
            Name = "Plate";
            Rarity = "Common";
            Description = DescriptionGenerator.Generator(Name);
            ItemLevel = ItemLevelCalc(Charlevel, Rarity);
            Armor = WeaponStrengthCalc(ItemLevel);

        }

    }

}





