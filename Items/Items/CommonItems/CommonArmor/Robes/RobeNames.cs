using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Items.Items.CommonItems.CommonArmor.Robes
{
    //REDUNDANT
    public class RobeNames
    {
        public static string[] CommonRobesNames { get; protected set; } = { "Plate" };

        public static string CommonName()
        {
            string Name = CommonRobesNames[Randomer.Randomizer(0, CommonRobesNames.Length)];
            return Name;
        }


    }

}
