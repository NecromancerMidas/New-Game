using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Items.Items.CommonItems.CommonArmor.Plate
{
    public class DescriptionGenerator
    {
        public static string[] CommonStaveDescription { get; protected set; } =  { "Very heavy but durable", // index 0 description for common sword
            "This sheet of metal makes you feel powerful.", //index 1 description for common saber
        "A common piece of plate, heavy and durable.", //index 2 description for common rapier
        "The smith who made this is just like this plate, common." //index 3 description for common saber
        };


        public static string Generator(string name)
        {
            var description = CommonStaveDescription;

            return description[Randomer.Randomizer(0, 4)];
        }

    }
}
