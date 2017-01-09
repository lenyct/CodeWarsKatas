using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        //You need to write a function that reverses the words in a given string.
        public static string Reverse(string text)
        {
            var reversed = text.Split(' ').Reverse();
            var count = reversed.Count() - 1;

            if (text.Equals(string.Empty) || count < 1) return text;

            StringBuilder sb = new StringBuilder();

            for (int c = 0; c <= count; c++)
            {
                sb.Append(reversed.ElementAt(c));
                if (reversed.ElementAt(c).Equals(string.Empty) || c != count)
                    sb.Append(" ");
            }
            return sb.ToString();
        }

        public static string ReverseNice(string text)
        {

            return string.Join(" ", text.Split(' ').Reverse().ToArray());
        }

        //Write function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2, otherwise returns false.
        public static bool Scramble(string scrambledStringInput, string testStringInput)
        {
            // your code
            Dictionary<char, int> scrambled = new Dictionary<char, int>();
            Dictionary<char, int> testString = new Dictionary<char, int>();

            foreach (var c in scrambledStringInput)
            {
                if (scrambled.ContainsKey(c))
                    scrambled[c] += 1;
                else
                    scrambled.Add(c, 1);
            }


            foreach (var c in testStringInput)
            {
                if (testString.ContainsKey(c))
                    testString[c] += 1;
                else
                    testString.Add(c, 1);
            }
            
            foreach(var c in testStringInput)
            {
                int temp = 0;
                scrambled.TryGetValue(c, out temp);
                if (temp < testString[c]) 
                    return false;
            }
            return true;
        }

        public static bool ScrambleNice(string str1, string str2)
        {
            return str2.All(x => str1.Count(y => y == x) >= str2.Count(y => y == x));
        }

        //1.  All alpha characters will be treated as upper case
        //2.  The first alpha character will not change(except for switching to upper case).
        //3.  All subsequent alpha characters will be shifted toward 'Z' by the
        //    alphabetical position of the previous alpha character.
        //    (wrap back to 'A' if 'Z' is passed)
        //H -> H(first alpha character does not change)
        //e -> M(H is the previous alpha character, and is the 8th letter in the alphabet.  E + 8 = M)
        //1 -> 1 (non alpha characters do not change)
        //l -> Q(E is the previous alpha character, and is the 5th letter in the alphabet.  L + 5 = Q)
        //o -> A(L is the previous alpha character, and is the 12th letter in the alphabet.  O + 12 = A)
        public static string Encode(string input)
        {
            return string.Empty;
        }
        public static string Decode(string input)
        {
            return string.Empty;
        }
    }
}

    
