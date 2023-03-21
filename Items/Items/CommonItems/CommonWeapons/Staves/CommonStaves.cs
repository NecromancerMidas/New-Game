using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using New_Game.Items.CommonFiles;
using New_Game.Items.CommonItems.Staves;

namespace Items.Items.CommonItems.CommonWeapons.Staves
{
    public class CommonStaves : New_Game.Items.Items
    {
        public CommonStaves(int Charlevel)
        {
            Type = "Staff";
            Name = "Staff";
            Rarity = "Common";
            Description = DescriptionGenerator.Generator(Name);
            ItemLevel = ItemLevelCalc(Charlevel, Rarity);
            WeaponStrength = WeaponStrengthCalc(ItemLevel);

        }

    }

}





