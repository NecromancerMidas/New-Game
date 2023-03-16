using System;
using System.Net.Security;
using System.Security.Claims;

// SE på arv til og forbedre kode her. Nice job :) :) :)
namespace New_Game.Classes
{
    //Maybe rename? Draws up stats of chosen class when called.
    public class Stats
    {
        public static string DrawStats(BaseCharacter Class)
        {
            string stats = $@"
Name: {Class.DisplayName}
Level: {Class.Level} 
Health: {Class.Health} 
Mana:  {Class.Mana} 
Strength: {Class.Strength} 
Agility:  {Class.Agility}
Intelligence: {Class.Intelligence}
";

            return stats;
        }
    }
}


/*public class MageClass


{
    public int Level = 1;

    public int Level2 { get; private set } = 1;
    private string Class = "Mage";
    public int Health = 1000;
    public int Mana = 500;
    public int Strength = 20;
    public int Agility = 10;
    public int Intelligence = 40;


    public void setName(string name)
    {
        Class = name
       }
    var mage = new MageClass();
    var mage2 = new MageClass();

    //mage.setName("hei")
    public string getName()
    {
        return Class
       }
*/

/*public class RogueClass

{
    public int Level = 1;
    public string Class = "Rogue";
    public int Health = 1250;
    public int Mana = 300;
    public int Strength = 25;
    public int Agility = 40;
    public int Intelligence = 20;

}
public class CurrentClass
{
    public string Name;
    public string Class;
    public int Level;
    public int Health;
    public int Mana;
    public int Strength;
    public int Agility;
    public int Intelligence;
    public List<string> Traits = new List<string>();

    public CurrentClass(string name, string @class, int level, int health, int mana, int strength, int agility, int intelligence)
    {
        Name = name;
        Class = @class;
        Level = level;
        Health = health;
        Mana = mana;
        Strength = strength;
        Agility = agility;
        Intelligence = intelligence;
    }*/
    /*        public CurrentClass(WarriorClass warrior)
            {

                Class = warrior.Class;
                Level = warrior.evel;
                Health = warrior.health;
                Mana = warrior.mana;
                Strength = warrior.strength;
                Agility = warrior.agility;
                Intelligence = warrior.intelligence;
            }*/

        //public CurrentClass(string name)
        //{
        //    Name = name;
        //}

    
   

