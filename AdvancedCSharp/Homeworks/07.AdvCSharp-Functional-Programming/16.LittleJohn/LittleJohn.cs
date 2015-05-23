using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _16.LittleJohn
{
    class LittleJohn
    {
        static void Main()
        {
            string[] hay = new string [4];
            for (int i = 0; i < hay.Length; i++)
            {
                hay[i] = Console.ReadLine();
            }
            string number = String.Empty;

            int allBig = 0;
            int allMedium = 0;
            int allSmall = 0;
            foreach (var s in hay)
            {
                allBig += Regex.Matches(s, @"((?<!>)>>>----->>)\1?").Count;
                allMedium += Regex.Matches(s, @"((?<!>)>>----->)\1?").Count;
                allSmall += Regex.Matches(s, @"((?<!>)>>----->)\1?").Count;
            }

            number = Convert.ToString(uint.Parse(string.Format("" + allSmall + allMedium + allBig)), 2) +
                     string.Join("", Convert.ToString(uint.Parse(string.Format("" + allSmall + allMedium + allBig)), 2).Reverse());
            Console.WriteLine(Convert.ToUInt32(number,2));
        }
    }
}
