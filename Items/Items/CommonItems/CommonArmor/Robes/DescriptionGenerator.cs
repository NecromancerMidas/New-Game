using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Items.Items.CommonItems.CommonArmor.Robes
{
    public class DescriptionGenerator
    {
        public static string[] CommonRobesDescription { get; protected set; } =  { "Hobo or wizard?", // index 0 description for common sword
            "Makes you look like a poor peasant.", //index 1 description for common saber
        "This one is covered in stains.", //index 2 description for common rapier
        "A common robe, unremarkable. Perfect for a real wizard or a pretender." //index 3 description for common saber
        };


        public static string Generator(string name)
        {
            var description = CommonRobesDescription;

            return description[Randomer.Randomizer(0, 4)];
        }

    }
}
