﻿
using System;
using System.Collections.Generic;
using System.Data;
using New_Game.Classes;

namespace New_Game
{
    public class CharacterIntroduction
    {

        public static void Choices(BaseCharacter Class)
        {
            string introduction = String.Empty;
            introduction =
                @$"Welcome to the world of Atharia, a world of fantasy awaits. Goblins and monsters run rampant across this Realm.
Civilized races such as Humans, Elves and Dwarves fight and squabble amongst each other. Whilst dragons sleep on their hoards.

You are a {Class.Class}. Every story has a beginning, we will now establish yours. What was your childhood like?
U: You were an urchin.
N: Raised as nobility.
F: Child of farmers.
A: Abusive household.";
            Draw.Box(introduction);
            ConsoleKeyInfo key = Console.ReadKey(true);
            Console.Clear();
            if (key.Key == ConsoleKey.U)
            {
                introduction = @"
You were an Urchin, as such life wasn't easy. 
You don't quite remember how you got yourself onto the streets, did you run away? Were you abandoned?
One thing you do remember is that you have had to fight for every scrap, the occasionally territorial dispute amongst other urchins or theft targeting the local merchants.
This has made you agile in your youth, and you know how to take a punch.
";
                Draw.Box(introduction);
                Class.Traits.Add("Urchin");
            }
            else if (key.Key == ConsoleKey.N)
            {
                introduction = @"
A blessed child, you had an upbringing amongst nobility, this has afforded you some affluence growing up.
Trinkets and heirlooms, hand me downs. To most these would be valuable, to you they were a part of your everyday life.
A pampered upbringing has not made you weak however, its custom amongst the majority of civilized cultures for nobles to have martial education from childhood.
This has made you stronger than most kids, and the study of martial history certainly hasn't addled your mind.
";
                Draw.Box(introduction);
                Class.Traits.Add("NobleChild");
            }
            else if (key.Key == ConsoleKey.F)
            {
                introduction = @"
Humble beginnings. A completely unremarkable upbringing, born to a family of farmers.
But just like the farmer is a backbone of society, a life on a farm has given you the backbone of a Hero.
Toiling the fields has given you a physique that is hard to beat. And though your family may not be wealthy they were not poor either.
They have left you a single heirloom, a magic ring left to you by your father a trophy from his conscripted service to the local lord.
";
                Draw.Box(introduction);
                Class.Traits.Add("FarmerChild");
            }
            else if (key.Key == ConsoleKey.A)
            {
                introduction = @"
A terrible upbringing, both your parents were alcoholics.
You feared the days they had access to drink, your father would frequently beat you on those very days.
You lack an education, but you have learned to defend yourself. The last you can remember was standing up to your father, ever since then he never raised his fist to you again.
A knack for fighting and not easily broken even under awful circumstances.
";
                Draw.Box(introduction);
                Class.Traits.Add("AbusedChild");
            }
            else
            {
                Console.Clear();
                Choices(Class);
            }

            SecondChoice(Class);
        }


        public static void SecondChoice(BaseCharacter Class)
        {
            string introduction2 = String.Empty;
            if (Class.Traits[0] == "NobleChild")
            {
                introduction2 = @"
As most creatures do, you have grown older. Now on the edge of adulthood, what did you do?

C: Conscripted into the army.
N: Continued noble life.
A: Joined the academy.
M: Inducted in a monster hunter guild.
W: Became a Wanderer.
";
                Draw.Box(introduction2);
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
                    Draw.Box(introduction2);
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
                    Draw.Box(introduction2);
                    Class.Traits.Add("PamperedNoble");
                }
                else if (key.Key == ConsoleKey.A)
                {
                    introduction2 = @"
An interesting turn of events. You decided to enroll into the academy, where you would come to study magic.
You have come to know that magic is innate to all creatures of Atharia. Anyone can learn it.
With your martial education as nobility, combined with your education at the academy, you may use spells to supplement your keen understanding of battle.
";
                    Draw.Box(introduction2);
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
                    Draw.Box(introduction2);
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
                    Draw.Box(introduction2);
                    Class.Traits.Add("NobleWanderer");

                }
                else
                {
                    Console.Clear();
                    SecondChoice(Class);
                }
            }
            else if (Class.Traits[0] == "Urchin")
            {
                introduction2 = @"
As most creatures do, you have grown older. Now on the edge of adulthood, what did you do?

C: Conscripted into the army.
A: Joined the academy.
M: Inducted in a monster hunter guild.
W: Became a Wanderer.
";
                Draw.Box(introduction2);
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.C)
                {
                    introduction2 = @"
Reaching adulthood, you were still prowling the streets to survive. You had become quite skilled at it, however one day it all changed.
The military came through your town, pulling all the dregs of society they could find off the streets into the army.
They shoved a spear into your hand and ordered you to march, despite the forceful nature of your recruitment at least you were fed daily.
Despite starting out with very little in the army, you nevertheless managed to survive the harsh environment despite being under equipped.
Eventually you were even granted some of the spoil of war, slowly building up an arsenal.
You are now stronger than ever, and even decently equipped for battle.
";
                    Draw.Box(introduction2);
                    Class.Traits.Add("SoldierUrchin");
                }
                else if (key.Key == ConsoleKey.A)
                {
                    introduction2 = @"
Your life changed forever when a wizard came through town. Either intentionally or out of pity he pulled you off the streets to enlist into the academy.
As a person of no means, you were looked down upon in the academy. This did not deter you, you were used to being looked down upon.
You started to excel in your studies, and ultimately are grateful for the mysterious wizard that took you in.
Into adulthood your life would change once again, the mysterious wizard came through the academy and would grant you an item of great power.
Leaving as fast as he came, he yet remained a mystery. But perhaps he had a soft spot for you, a little gift as a reward for how you have grown perhaps?
";
                    Class.Traits.Add("UrchinAcademy");
                    Draw.Box(introduction2);

                }
                else if (key.Key == ConsoleKey.M)
                {
                    introduction2 = @"
Living on the streets is rough, but unbeknownst to you things would get even rougher. A man came into town, covered in terrible scars a burn mark scorched his visage.
People seemed to be in awe of this man, and not a single one seemed to care when he laid claim to you and some other urchins. In fact they seemed happy.
'Finally they will be useful for something.''Good riddance.' In the end you found out the man was a 'Dragon' class amongst the Monster Hunter Guild, explaining the burn on his face.
Also knowing your fate, you were assigned the rank of 'Roach' the lowest rung of the Guild, typically filled with bandits and malcontents.
You were made to serve the needs of your 'Betters', however you still learned to slay monsters. Perhaps in due time, you could climb the ranks of the guild?
";
                    Draw.Box(introduction2);
                    Class.Traits.Add("RoachMonsterHunter");
                }

                else if (key.Key == ConsoleKey.W)
                {
                    introduction2 = @"
Sick and tired of your life on the street, you decided to take your luck elsewhere or rather the lack thereof. Perhaps fortune would start to shine upon you somewhere else.
With what little you had you started to wander the world, still employing methods from your youth to get by.
With the new dangers in the world you did however improve in fending for yourself, eventually even able to do odd jobs here and there for coin.
After some time you even no longer had to steal to get by. Your wanderlust has left you an experienced individual.
";
                    Draw.Box(introduction2);
                    Class.Traits.Add("UrchinWanderer");
                }
            }

            if (Class.Traits[0] == "FarmerChild")
            {
                introduction2 =
                    @"As most creatures do, you have grown older. Now on the edge of adulthood, what did you do?
C: Conscripted into the army.
A: Joined the academy.
M: Inducted in a monster hunter guild.
W: Became a Wanderer.
";
                Draw.Box(introduction2);
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.C)
                {

                }
            }
        }
    }
}