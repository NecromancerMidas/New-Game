using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using New_Game.Classes;

namespace New_Game.Items.CommonItems.Swords
{
    public class CommonSwords : Items
    {
        public CommonSwords(BaseCharacter Class)
        {
            Type = "Sword";
            Description = "A common ass sword";
            WeaponStrength = Class.Level;

        }

}
}

    


