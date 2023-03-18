using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace New_Game.Items.CommonItems.Daggers
{
    public class DaggerNames
    {
        public static string[] CommonDaggerNames { get; protected set; } = { "Dagger", "Dirk", "Stiletto", "Pugio" };

        public static string CommonName()
        {
            string Name = CommonDaggerNames[Randomer.Randomizer(0,CommonDaggerNames.Length)];
          return Name;
        }


    }
    
}
