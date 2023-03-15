namespace New_Game.Introduction
{
    //Handles the different choices for Urchin story, the world really is cruel :(.
    public class UrchinSecondChoice
    {
        
        public static string Choices(Classes.BaseCharacter Class)
        {
            string introduction = string.Empty;


            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.C)
            {
                introduction = @"
Reaching adulthood, you were still prowling the streets to survive. You had become quite skilled at it, however one day it all changed.
The military came through your town, pulling all the dregs of society they could find off the streets into the army.
They shoved a spear into your hand and ordered you to march, despite the forceful nature of your recruitment at least you were fed daily.
Despite starting out with very little in the army, you nevertheless managed to survive the harsh environment despite being under equipped.
Eventually you were even granted some of the spoils of war, slowly building up an arsenal.
You are now stronger than ever, and even decently equipped for battle.
";

                Class.Traits.Add("SoldierUrchin");
            }
            else if (key.Key == ConsoleKey.A)
            {
                introduction = @"
Your life changed forever when a wizard came through town. Either intentionally or out of pity he pulled you off the streets to enlist into the academy.
As a person of no means, you were looked down upon in the academy. This did not deter you, you were used to being looked down upon.
You started to excel in your studies, and ultimately are grateful for the mysterious wizard that took you in.
Into adulthood your life would change once again, the mysterious wizard came through the academy and would grant you an item of great power.
Leaving as fast as he came, he yet remained a mystery. But perhaps he had a soft spot for you, a little gift as a reward for how you have grown perhaps?
";
                Class.Traits.Add("UrchinAcademy");


            }
            else if (key.Key == ConsoleKey.M)
            {
                introduction = @"
Living on the streets is rough, but unbeknownst to you things would get even rougher. A man came into town, covered in terrible scars a burn mark scorched his visage.
People seemed to be in awe of this man, and not a single one seemed to care when he laid claim to you and some other urchins. In fact they seemed happy.
'Finally they will be useful for something.''Good riddance.' In the end you found out the man was a 'Dragon' class amongst the Monster Hunter Guild, explaining the burn on his face.
Also knowing your fate, you were assigned the rank of 'Roach' the lowest rung of the Guild, typically filled with bandits and malcontents.
You were made to serve the needs of your 'Betters', however you still learned to slay monsters. Perhaps in due time, you could climb the ranks of the guild?
";

                Class.Traits.Add("RoachMonsterHunter");
            }

            else if (key.Key == ConsoleKey.W)
            {
                introduction = @"
Sick and tired of your life on the street, you decided to take your luck elsewhere or rather the lack thereof. Perhaps fortune would start to shine upon you somewhere else.
With what little you had you started to wander the world, still employing methods from your youth to get by.
With the new dangers in the world you did however improve in fending for yourself, eventually even able to do odd jobs here and there for coin.
After some time you even no longer had to steal to get by. Your wanderlust has left you an experienced individual.
";

                Class.Traits.Add("UrchinWanderer");
            }
            else
            {
                Console.Clear();
                SecondChoiceSelector.SecondIntroduction(Class);
            }

            return introduction;
        }
    }
}


