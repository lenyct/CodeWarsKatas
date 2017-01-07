using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    public static class Katas2
    {
        //For a given string s find the character c with longest consecutive repetition and return a tuple(c, l) (in Haskell
        //Just(Char, Int), in C# Tuple<char?, int>) where l is the length of the repetition. If there are two or more 
        //characters with the same l return the first.
        //For empty string return ('', 0) (in Haskell Nothing, in C# Tuple<char, int>(null, 0)).
        public static Tuple<char?, int> LongestRepetition(string input)
        {
            if(input.Length > 0)
            {
                var order = input.OrderBy(c => c).ToList();
                Dictionary<char, int> t = new Dictionary<char, int>();

                foreach (var key in order)
                {
                    if (t.ContainsKey(key))
                    {
                        t[key] += 1;
                    }
                    else
                    {
                        t.Add(key, 1);
                    }
                }

                
                var maxKey = t.FirstOrDefault(MaxGuid => MaxGuid.Value == t.Values.Max());

                return new Tuple<char?, int>(maxKey.Key, maxKey.Value);
            }
            return new Tuple<char?, int>(null, 0);


        }
    }
}
