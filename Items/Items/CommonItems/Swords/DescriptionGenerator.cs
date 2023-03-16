using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Game.Items.CommonItems.Swords
{
    public class DescriptionGenerator
    {
        public static string[] CommonSwordDescription { get; protected set; } =  { "A common ass sword", // index 0 description for common sword
            "A common scimitar, you arent sure how to pronounce it.", //index 1 description for common saber
        "An everyday rapier, stick them with the pointy end.", //index 2 description for common rapier
        "A saber, a cavalry man is missing his sword." //index 3 description for common saber
        };


        public static string Generator(string name)
        {
            var description = CommonSwordDescription;
            if (name == "Sword")
            {
                return description[0];
            }
            else if (name == "Scimitar")
            {
                return description[1];
            }
            else if (name == "Rapier")
            {
                return description[2];

            }
            else if (name == "Saber")
            {
                return description[3];
            }

            return "Nothing";
        }

    }
}
