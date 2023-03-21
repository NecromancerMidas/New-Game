using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Items.Items.CommonItems.CommonArmor.LeatherArmor
{
    //REDUNDANT
    public class LeatherNames
    {
        public static string[] CommonLeatherNames { get; protected set; } = { "Plate" };

        public static string CommonName()
        {
            string Name = CommonLeatherNames[Randomer.Randomizer(0, CommonLeatherNames.Length)];
            return Name;
        }


    }

}
