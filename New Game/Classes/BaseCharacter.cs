using New_Game.Classes;
using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace New_Game.Classes
{

    /*Template for a character, gets built on further with more detail*/
    public class BaseCharacter
    {
        public string DisplayName { get; protected set; }
        public string Name { get; protected set; }
        public string Class { get; protected set; }
        public int Xp { get; protected set; }
        public int Level { get; protected set; }
        public int Health { get; protected set; }
        public int Mana { get; protected set; }
        public int Strength { get; protected set; }
        public int Agility { get; protected set; }
        public int Intelligence { get; protected set; }
        public List<string> Traits { get; protected set; }

        public BaseCharacter()
        {
            Xp = 0;
            Level = 1;
            Traits = new List<string>();
        }
        public void ClassStringChanger(string value,string field)
        {
            if (field == "name")
            {
                Name = value;
                
            }
            else if (field == "displayName")
            {
                DisplayName = Name + " the " + value;
            }
        }
    }

    }


/*public BaseCharacter(string @class, int health, int mana, int strength, int agility, int intelligence)
{

    Class = @class;
    Health = health;
    Mana = mana;
    Strength = strength;
    Agility = agility;
    Intelligence = intelligence;
}*/