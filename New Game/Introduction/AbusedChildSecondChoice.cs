using New_Game.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Game.Introduction
{
    //Handles the different story choices for AbusedChild very sad :( why would you choose this one?
    public class AbusedChildSecondChoice
    {
        public static string Choices(BaseCharacter Class)
        {
            string introduction2 = string.Empty;
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.C)
            {
                introduction2 = @$"
The army, what else? Fearless as a child, fearless as an adult. You welcome the chance to leave your past behind. They came to conscript you, but you signed up willingly.
Such a show of interest elevated you beyond the rabble that were forced to join. Quickly you outshone the other recruits, and the commander took a liking to you.
Though your low birth prevented you from becoming an officer. He made you part of his bodyguard, and you did your duty with dedication. You have scars marking your body from saving your patrons life many times over.
When the war ended your patron rewarded you handsomely, affording you equipment that would bring envy to any other {Class.Class}.
";
                Class.Traits.Add("BodyGuard");
            }
            else if (key.Key == ConsoleKey.A)
            {
                introduction2 = @"
The Academy, sick of your current life you have decided to work your way into the academy. Very ambitious, you would have to commit to hard labor and study for a place there.
Not unfamiliar to hardship you persevere. You learn of magic, and the different planes that exist that one could theoretically travel between.
You learn of Demons, Djinn, Elementals and many more creatures that inhabit this world.
Despite your upbringing you have developed a keen mind, and despite the labor to get into the academy you managed to outshine most students.
";
                Class.Traits.Add("AbusedScholar");
            }
            else if (key.Key == ConsoleKey.M)
            {
                introduction2 = @"
Unbeknownst to you things would get even rougher. A man came into town, covered in terrible scars a burn mark scorched his visage.
People seemed to be in awe of this man, and not a single one seemed to care when he took you with him.
In the end you found out the man was a 'Dragon' class amongst the Monster Hunter Guild, explaining the burn on his face.
Also knowing your fate, you were assigned the rank of 'Toad' near the lowest rung in ranking.
You were made to serve the needs of your 'Betters', however you still learned to slay monsters. Perhaps in due time, you could climb the ranks of the guild?
";

                Class.Traits.Add("ToadMonsterHunter");
            }
            else if (key.Key == ConsoleKey.W)
            {
                introduction2 = @"
You didn't really need a reason to set out into the world, getting away from home was reason enough. You would try to find meaning to your existence in your travels.
Before you left, you made sure to take what you could from the home, not caring wether it was needed or not by your parents. Feeling you were owed some compensation.
In your travels you met a plethora of different people, some were even worse than your parents, but many were also quite the opposite.
You stopped at an inn once in your travels, and wove the tale of your travels. And even the reason you left in the first place.
A mysterious stranger took pity on you, or perhaps just appreciated the tale. He gifted you a weapon humming with magic. Claiming it would serve you better and that he no longer needed it.
";

                Class.Traits.Add("AbusedWanderer");
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