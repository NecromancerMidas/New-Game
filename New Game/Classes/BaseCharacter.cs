using New_Game.Classes;
using System;
using System.Dynamic;
using System.Security.Claims;

namespace New_Game.Classes
{


    public class BaseCharacter
    {
        protected string name;
        protected string @class;
        protected int xp = 0;
        protected int level = 1;
        protected int health;
        protected int mana;
        protected int strength;
        protected int agility;
        protected int intelligence;
        protected List<string> traits = new List<string>();
        public int Xp
        {
            get => xp;
            set => xp = value;
        }

        public int Level
        {
            get => level;
            set => level = value;
        }

        public int Health
        {
            get => health;
            set => health = value;
        }

        public int Mana
        {
            get => mana;
            set => mana = value;
        }

        public int Strength
        {
            get => strength;
            set => strength = value;
        }

        public int Agility
        {
            get => agility;
            set => agility = value;
        }

        public int Intelligence
        {
            get => intelligence;
            set => intelligence = value;
        }

        public string Name
        {
            get { return name; }
            set {name = value;}
        }

        public string Class
        {
            get { return @class; } 
            set { @class = value;}
        }
        public List<string> Traits { get { return traits; }}
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