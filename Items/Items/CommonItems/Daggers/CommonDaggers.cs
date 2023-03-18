using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using New_Game.Items.CommonFiles;

namespace New_Game.Items.CommonItems.Daggers
{
    public class CommonDaggers : Items
    {
        public CommonDaggers(int Charlevel)
        {
            Type = "Dagger";
            Name = DaggerNames.CommonName();
            Rarity = "Common";
            Description = DescriptionGenerator.Generator(Name);
            ItemLevel = ItemLevelCalc.Calc(Charlevel, Rarity);
            WeaponStrength = WeaponsStrengthCalc.Calc(ItemLevel / 2);
        }

        }

}


    


