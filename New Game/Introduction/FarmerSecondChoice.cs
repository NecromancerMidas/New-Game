using New_Game.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Game.Introduction
{//Handles the different choices for Farmer back story.
    public class FarmerSecondChoice
    {
        public static string FarmerChoice(BaseCharacter Class)
        {
            string introduction2 = string.Empty;
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.C)
            {
                introduction2 = @"
In times of war its common practice in Atarhia to conscript the strong offspring of farmers. You are one of these.
Donning your magic ring, you went to battle like your father before you. Not as poorly equipped as the urchins pulled off the streets, you were still no knight.
Chaff is what they called the poorer classes. Just there to absorb the arrows and bog down the cavalry charges. You however excelled at this.
Spear in hand you dismounted several knights in battle, a rare feat for a peasant as yourself. With each person slain, your ring would hum with magic.
Towards the end of your conscription you were unrecognizable from what you were before. Your ring seemed to have increased in power, boosting you even further beyond your usual capabilities.
";
                Class.Traits.Add("ConscriptedFarmer");
            }
            else if (key.Key == ConsoleKey.A)
            {
                introduction2 = @"
Pondering upon your magic ring you have become inspired. The occasional glow of it, you wish to find out more about magic.
Using what little wealth you have earned, you enlist into the academy.
Thought not well regarded for your lowborn status, you do not let this deter you. To understand magic is a lofty goal, and you won't let something petty like low-birth keep you down.
During your studies you read up on enchanted items like your ring, perhaps you would be capable of furthering its enchantment.
The reagents to do so are not easily obtained, you have slain several monsters to do so. This has left you stronger than most at the academy.
Enchanting your ring was no easy feat, your understanding of magic has expanded greatly. And naturally you have a more powerful ring.
You have also found out that this ring, feeds upon death growing stronger as you kill monsters but perhaps it works on people too?
";
                Class.Traits.Add("AcademicFarmer");
            }
            else if (key.Key == ConsoleKey.M)
            {
                introduction2 = @"
Your fathers ring is no ordinary treasure, that fact that its magic catches your interest. Perhaps there are more like it out in the world.
You believe the best way to do so is to join the monster hunter guild. Slaying monsters, you are sure to come to find some treasure tucked away somewhere.
Dragons are known for their hoards, perhaps its not delusional to get access to such a hoard. Though it probably is.
You were assigned the rank of 'Dog'. A middle of the road rank, given to those that aren't forced into their ranks.
Tough your time there has not lead to any riches, you have slain many monsters by now. And you ring seems to have grown in power in the process.
";
                Class.Traits.Add("DogMonsterHunter");
            }
            else if (key.Key == ConsoleKey.W)
            {
                introduction2 = @"
Boredom describes your current state. Day in day out work the fields, barely anything to do during the winter season. Just sitting by the hearth.
It's time for a change, you take a couple possessions. Your fathers spear from his conscription and the magic ring you were given.
You set out to wander the world, make your own luck. Killing a few creatures in your travels, your ring glowing in response.
You have become knowledgeable of the world, and you have become quite experienced traveling it.
";
                Class.Traits.Add("FarmerWanderer");
            }
            else
            {
                Console.Clear();
                SecondChoiceSelector.SecondIntroduction(Class);
            }

            return introduction2;
        }
    }
}
