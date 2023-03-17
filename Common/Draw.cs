using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml;

// I hate my life.
public class Draw
{
    public static void Box(string convert)
    {
        string ulCorner = "╔";
        string llCorner = "╚";
        string urCorner = "╗";
        string lrCorner = "╝";
        string vertical = "║";
        string horizontal = "═";
        string width = null;
        string top;
        string bottom;
        string left = vertical + " ";
        string result = String.Empty;
        string Result;
        string newline;

        string[] lines = convert.Split('\u000A');
        int longest = 0;
        foreach (string line in lines)
        {



            newline = Regex.Replace(line, @"\t|\r|\n", string.Empty);
         

            if (newline.Length >= longest)
                longest = newline.Length +1;
        }

        for (int i = 0; i <= longest; i++)
        {
            width += horizontal;
        }

        top = ulCorner + width + urCorner;
        bottom = llCorner + width + lrCorner;

        foreach (string line in lines)
        {


            newline = Regex.Replace(line ,@"\t|\r|\n", string.Empty);
            int count = 0;
            for (int i = 0; i <= newline.Length; i++)
            {
                count++;
            }

            string padding = String.Empty;
          int timesToPad = longest - count;
            for (int j = timesToPad; j >= 0; j--)
            {
                padding += " ";
            }

            result += left + newline + padding + vertical + "\n";
        }
        // don't touch it works
        Result = top + "\n" + result + bottom;
        
        Console.WriteLine(@"
" + Result);
        
    }
}
