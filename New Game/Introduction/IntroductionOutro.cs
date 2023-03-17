using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace New_Game.Introduction
{
    public class IntroductionOutro
    {
        public static void outro()
        {
            Console.WriteLine("Press Enter to Continue");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {

                Console.Clear();
                string outro = @"
And now your true story begins. You will face many challenges, your decisions will be critical for success.
Sometimes its better to flee than to fight. Good luck.
";
                Draw.Box(outro);

            }
            else
            {
                outro();
            }
        }
    }
}
