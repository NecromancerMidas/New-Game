using System;
using System.ComponentModel.Design;
using New_Game.Classes;

namespace New_Game.Introduction
{

    //Handles what introduction you get based on CharacterIntroduction choice. Why does noble get an extra? Life is unfair.
    public class SecondChoiceSelector
    {
        public static void SecondIntroduction(BaseCharacter Class)
        {
            Console.Clear();
            string introduction2 = @"
As most creatures do, you have grown older. Now on the edge of adulthood, what did you do?
C: Conscripted into the army.
A: Joined the academy.
M: Inducted in a monster hunter guild.
W: Became a Wanderer.
";
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
                Draw.Box(NobleSecondChoice.Choices(Class));
            }
            else if (Class.Traits[0] == "Urchin")
            {
                
                Draw.Box(introduction2);
                Draw.Box(UrchinSecondChoice.Choices(Class));
            }

            else if (Class.Traits[0] == "FarmerChild")
            {

                Draw.Box(introduction2);
                Draw.Box(FarmerSecondChoice.FarmerChoice(Class));
            }
            else if (Class.Traits[0] == "AbusedChild")
            {
                Draw.Box(introduction2);
                Draw.Box(AbusedChildSecondChoice.Choices(Class));

            } 

            IntroductionOutro.outro();
        }


    }
}
        

