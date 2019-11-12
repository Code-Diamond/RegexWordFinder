using System;
using System.Text.RegularExpressions;

namespace RegexWordFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find number of times the word "the or The" using regex, and display index location within text
            String text = "The the quick brown fox  fox jumps over the lazy dog.";
            Regex rx = new Regex(@"(the|The)");
            MatchCollection matches = rx.Matches(text);
            //Summary
            Console.WriteLine("{0} matches found in:\n   {1}", matches.Count, text);

            // Report on each match.
            foreach (Match match in matches)
            {
                GroupCollection groups = match.Groups;
                Console.WriteLine("'{0}' repeated at positions {1} and {2}",
                                  groups[0].Value,
                                  groups[0].Index,
                                  groups[1].Index);
            }

        }
    }
}
