using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Items.Items.CommonItems.CommonWeapons.Staves
{
    //REDUNDANT
    public class StaveNames
    {
        public static string[] CommonStaveNames { get; protected set; } = { "Stave" };

        public static string CommonName()
        {
            string Name = CommonStaveNames[Randomer.Randomizer(0, CommonStaveNames.Length)];
            return Name;
        }


    }

}
