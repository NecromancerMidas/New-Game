﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Items.Items.CommonItems.CommonWeapons.Swords
{
    public class SwordNames
    {
        public static string[] CommonSwordNames { get; protected set; } = { "Sword", "Scimitar", "Rapier", "Saber" };

        public static string CommonName()
        {
            string Name = CommonSwordNames[Randomer.Randomizer(0, CommonSwordNames.Length)];
            return Name;
        }


    }

}
