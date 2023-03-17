using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace New_Game.Items.CommonFiles
{
    public class WeaponsStrengthCalc
    {
        public static int Calc(int level)
        {

            return level * Randomer.Randomizer(1, 4);
        }


    }
}
