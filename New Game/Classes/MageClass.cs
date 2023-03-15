using System;
using New_Game.Classes;

namespace New_Game.Classes
{

    /*Mage Class Template*/
    public class MageClass : BaseCharacter
    {
        public MageClass() 
        {
            Class = "Mage";
            Health = 1000; 
            Mana = 500; 
            Strength = 20; 
            Agility = 10; 
            Intelligence = 40;

    }
    }
}
