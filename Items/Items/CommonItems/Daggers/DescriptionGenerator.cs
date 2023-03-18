using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Game.Items.CommonItems.Daggers
{
    public class DescriptionGenerator
    {
        public static string[] CommonDaggerDescription { get; protected set; } =  { "A normal dagger, seems a bit small.", // index 0 description for common sword
            "A common dirk, that's it.", //index 1 description for common saber
        "A stiletto fancy! Too bad it's a utterly unremarkable.", //index 2 description for common rapier
        "A pugio, you don't know why but you feel cool wearing it." //index 3 description for common saber
        };


        public static string Generator(string name)
        {
            var description = CommonDaggerDescription;
            if (name == "Dagger")
            {
                return description[0];
            }
            else if (name == "Dirk")
            {
                return description[1];
            }
            else if (name == "Stiletto")
            {
                return description[2];

            }
            else if (name == "Pugio")
            {
                return description[3];
            }

            return "Nothing";
        }

    }
}
