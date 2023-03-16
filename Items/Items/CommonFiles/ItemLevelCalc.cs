using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace New_Game.Items.CommonFiles
{
    public class ItemLevelCalc
    {
        public static int Calc(int level, string rarity)
        {
            if (rarity == "Common")
            {
                return level * Randomer.Randomizer(5, 8);
            }
            else if (rarity == "Rare")
            {
                return level * Randomer.Randomizer(8, 10);
            }
            else if (rarity == "Epic")
            {
                return level * Randomer.Randomizer(10, 12);
            }
            else if (rarity == "Legendary")
            {
                return level * Randomer.Randomizer(12, 15);
            }

            return 0;
        }
    }
}
