using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Items.Items.CommonItems.CommonArmor.Plate
{
    //REDUNDANT
    public class PlateNames
    {
        public static string[] CommonPlateNames { get; protected set; } = { "Plate" };

        public static string CommonName()
        {
            string Name = CommonPlateNames[Randomer.Randomizer(0, CommonPlateNames.Length)];
            return Name;
        }


    }

}
