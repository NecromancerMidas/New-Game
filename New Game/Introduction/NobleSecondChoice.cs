using New_Game.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Game.Introduction
{//Handles the different choices for Noble back story. Ego much??
    public class NobleSecondChoice
    {
        public static string Choices(BaseCharacter Class)
        {
            string introduction2 = string.Empty;
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.C)
            {
                introduction2 = @$"
Despite your noble blood you were still conscripted into the army, wether by choice or otherwise.
Armies still need leaders, and with your education and noble status you were swiftly elevated to an officer in the army.
Your martial education helped you conduct battle plans, and even assist in drawing them up.
As an officer you were at the heart of battle with your men, you have seen plenty of death and despair, dealing your fair share of it yourself.
Reaching adulthood you have the markings of a true battle-hardened {Class.Class}.
";
                Class.Traits.Add("ArmyOfficer");
            }
            else if (key.Key == ConsoleKey.N)
            {
                introduction2 = @$"
You continued your pampered noble life, seeing very little reason to trade out your comforts for cheap thrills.
Completing your studies as a noble, broadening your studies into economic management. Knowing how to wring every gold coin you are owed by the peasants your parents ruled over.
With a noble education you have become quite wise, you have become exceptionally intelligent and wealthy, however your comfortable lifestyle has left your physical traits something to be desired.
You may not be a battle hardened {Class.Class} but you have a keen mind to make up for it.
";

                Class.Traits.Add("PamperedNoble");
            }
            else if (key.Key == ConsoleKey.A)
            {
                introduction2 = @"
An interesting turn of events. You decided to enroll into the academy, where you would come to study magic.
You have come to know that magic is innate to all creatures of Atharia. Anyone can learn it.
With your martial education as nobility, combined with your education at the academy, you may use spells to supplement your keen understanding of battle.
";
                Class.Traits.Add("AcademicNoble");
            }
            else if (key.Key == ConsoleKey.M)
            {
                introduction2 = @"
As you grew towards adulthood, you joined the monster hunter guild. Either your parents sent you off to solve a succession issue or maybe you joined on your own.
The monster hunter has a mixed reputation, typically the lower rungs are considered no more than common bandits.
But fortune shines upon you, as you are of noble blood. You joined the 'Cat' rank of hunter. Typically associated with the nobles and skilled hunters.
Few people outrank you in the guild, but there is still plenty of ladder to climb. Perhaps one day you could achieve the coveted rank of 'Dragon' by slaying one?
Joining the guild has given you a great understanding of alchemy and monsters and how to slay them, plenty of physical trials have been passed to get where you are.
Intelligent, Agile and Strong. These are things that describe you now, though you don't excel at any you have struck a fine balance required to hunt monsters.
";

                Class.Traits.Add("CatMonsterHunter");
            }
            else if (key.Key == ConsoleKey.W)
            {
                introduction2 = @"
Towards adulthood you have grown weary of your pampered lifestyle, sneaking out from under your parents nose with quite a few of your posessions you set out to the wider world.
Traveling the world has left you knowledgeable of it, and the monsters that inhabit it that you ocassionally have had to run into. 
You have gained more experience of the world that a textbook ever could.
Though your travels have left your personal funds tight by a noble's standards, you have become more skilled in all aspects.
";

                Class.Traits.Add("NobleWanderer");
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
