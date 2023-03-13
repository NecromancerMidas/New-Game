using System;

public class Randomer
{
	public static int Randomizer(int min, int max)
	{
		Random rng = new Random();
	    int num = rng.Next(min, max);
		return num;
	  

	}
}
