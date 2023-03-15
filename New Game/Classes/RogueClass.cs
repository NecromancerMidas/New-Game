using System;

namespace New_Game.Classes
{
     /*Rogue Class template*/
    public class RogueClass : BaseCharacter
    {
        public RogueClass()
        {
            Class = "Rogue";
            Health = 1250;
            Mana = 300;
            Strength = 25;
            Agility = 40;
            Intelligence = 20;
        }
    }
}