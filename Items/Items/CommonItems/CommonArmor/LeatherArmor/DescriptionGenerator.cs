using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Items.Items.CommonItems.CommonArmor.LeatherArmor
{
    public class DescriptionGenerator
    {
        public static string[] CommonLeatherDescription { get; protected set; } =  { "Common bandit, or dashing scoundrel?", // index 0 description for common sword
            "Couldn't look anymore average than this.", //index 1 description for common saber
        "Protective but not too heavy.", //index 2 description for common rapier
        "Made of many tanned hides, make it count." //index 3 description for common saber
        };


        public static string Generator(string name)
        {
            var description = CommonLeatherDescription;

            return description[Randomer.Randomizer(0, 4)];
        }

    }
}
