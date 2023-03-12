using Classes;
using System;
using System.Collections.Generic;

public class CharacterIntroduction
{
	public static void Choices(CurrentClass Class)
	{

		Console.WriteLine(@"Welcome to the world of Atharia, a world of fantasy awaits. Goblins and monsters run rampant across this Realm.
Civilized races such as Humans, Elves and Dwarves fight and squabble amongst eachother. Whilst dragons sleep on their hoards.

You are a " + Class.Class + @". Every story has a beggining, we will now establish yours. What was your childhood like?
U: You were an urchin.
N: Raised as nobility.
F: Child of farmers.
A: Abusive household.");
		ConsoleKeyInfo key = Console.ReadKey(true);
		if (key.Key == ConsoleKey.U)
		{
			Console.WriteLine(@"
You were an Urchin, as such life wasn't easy. 
You don't quite remember how you got yourself onto the streets, did you run away? Were you abandoned?
One thing you do remember is that you have had to fight for every scrap, the ocasionally territorial dispute amongst other urchins or theft targeting the local merchants.
This has made you agile in your youth, and you know how to take a punch.");
			Class.Traits.Add("Urchin");
		}
		else if (key.Key == ConsoleKey.N)
		{
			Console.WriteLine(@"
A blessed child, you had an upbringing amongst nobility, this has afforded you some affluence growing up.
Trinkets and heirlooms, hand me downs. To most these would be valuable, to you they were a part of your everyday life.
A pampered upbringing has not made you weak however, its custom amongst the majority of civilized cultures for nobles to have martial education from childhood.
This has made you stronger than most kids, and the study of martial history certainly hasn't addled your mind.");
			Class.Traits.Add("NobleChild");
		}
		else if (key.Key == ConsoleKey.F)
		{
			Console.WriteLine(@"
Humble beginings. A completely unremarabkle upbringing, born to a family of farmers.
But just like the farmer is a backbone of society, a life on a farm has given you the backbone of a Hero.
Toiling the fields has given you a physique that is hard to beat. And though your family may not be wealthy they were not poor either.
They have left you a single heirloom, a magic ring left to you by your father a trophy from his conscripted service to the local lord.");
			Class.Traits.Add("FarmerChild");
		}
		else if (key.Key == ConsoleKey.A)
		{
			Console.WriteLine(@"
A terrible upbringing, both your parents were alcoholics.
You feared the days they had access to drink, your father would frequently beat you on those very days.
You lack an education, but you have learned to defend yourself. The last you can remember was standing up to your father, ever since then he never raised his fist to you again.
A knack for fighting and not easily broken even under awful circumstances.");
			Class.Traits.Add("AbusedChild");
		}
		else
		{
			Console.Clear();
			Choices(Class);
		}
		SecondChoice(Class);
	}


	public static void SecondChoice(CurrentClass Class)
	{
		Console.WriteLine(@"
");
	}
}