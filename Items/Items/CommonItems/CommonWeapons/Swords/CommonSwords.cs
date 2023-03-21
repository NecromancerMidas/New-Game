using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using New_Game.Items.CommonFiles;
using New_Game.Items.CommonItems.Swords;

namespace Items.Items.CommonItems.CommonWeapons.Swords
{
    public class CommonSwords : New_Game.Items.Items
    {
        public CommonSwords(int Charlevel)
        {
            Type = "Sword";
            Name = SwordNames.CommonName();
            Rarity = "Common";
            Description = DescriptionGenerator.Generator(Name);
            ItemLevel = ItemLevelCalc(Charlevel, Rarity);
            WeaponStrength = WeaponStrengthCalc(ItemLevel);
        }

    }

}





