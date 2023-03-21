using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using New_Game.Items.CommonFiles;
using New_Game.Items.CommonItems.Daggers;

namespace Items.Items.CommonItems.CommonWeapons.Daggers
{
    public class CommonDaggers : New_Game.Items.Items
    {
        public CommonDaggers(int Charlevel)
        {
            Type = "Dagger";
            Name = DaggerNames.CommonName();
            Rarity = "Common";
            Description = DescriptionGenerator.Generator(Name);
            ItemLevel = ItemLevelCalc(Charlevel, Rarity);
            WeaponStrength = WeaponStrengthCalc(ItemLevel / 2);
        }

    }

}





