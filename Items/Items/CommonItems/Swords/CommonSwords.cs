using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using New_Game.Items.CommonFiles;

namespace New_Game.Items.CommonItems.Swords
{
    public class CommonSwords : Items
    {
        public CommonSwords(int Charlevel)
        {
            Type = "Sword";
            Name = SwordNames.CommonName();
            Rarity = "Common";
            Description = DescriptionGenerator.Generator(Name);
            ItemLevel = ItemLevelCalc.Calc(Charlevel, Rarity);
            WeaponStrength = WeaponsStrengthCalc.Calc(ItemLevel);
        }

        }

}


    


