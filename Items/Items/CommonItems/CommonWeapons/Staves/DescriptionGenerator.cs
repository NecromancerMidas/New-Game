using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Items.Items.CommonItems.CommonWeapons.Staves;

namespace New_Game.Items.CommonItems.Staves
{
    public class DescriptionGenerator
    {
        public static string[] CommonStaveDescription { get; protected set; } =  { "A knobby staff, makes you more caveman than wizard", // index 0 description for common sword
            "A straight staff, a most exquisite stick.", //index 1 description for common saber
        "A staff, basically a big wand right?", //index 2 description for common rapier
        "A staff, this one has some leaves on it, WOW!" //index 3 description for common saber
        };


        public static string Generator(string name)
        {
            var description = CommonStaveDescription;
            
            return description[Randomer.Randomizer(0,4)];
        }

    }
}
