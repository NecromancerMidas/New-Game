using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using New_Game.Items.CommonFiles;

namespace New_Game.Items.CommonItems.Staves
{
    public class CommonStaves : Items
    {
        public CommonStaves(int Charlevel)
        {
            Type = "Sword";
            Name = "Staff";
            Rarity = "Common";
            Description = DescriptionGenerator.Generator(Name);
            ItemLevel = ItemLevelCalc.Calc(Charlevel, Rarity);
            WeaponStrength = WeaponsStrengthCalc.Calc(ItemLevel);
        }

        }

}


    


