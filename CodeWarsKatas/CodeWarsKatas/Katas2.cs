using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

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
            if (string.IsNullOrEmpty(input)) return new Tuple<char?, int>(null, 0);

            var capacity =input.Length;
                input  += " ";
                int[] output = new int[capacity];
                var curNum = 0;
                for(int i=0; i <= capacity-1; i++)
                {

                    if (input[i] == input[i + 1])
                    {                        
                        output[curNum] += 1;                          
                    }else
                    {
                        output[curNum] += 1;
                        curNum = i+1;
                    }                    
                }
                var max = output.Max();
                var maxPosition = output.ToList().IndexOf(max);
                return new Tuple<char?, int>(input[maxPosition], max );
        }

        public static Tuple<char?, int> LongestRepetitionLinq(string input)
        {
            if (string.IsNullOrEmpty(input)) return new Tuple<char?, int>(null, 0);

            List<char> l = input.Select((c, index) => input.Substring(index).TakeWhile(x => x == c))
                .OrderByDescending(y => y.Count())
                .First().ToList();
            return new Tuple<char?, int>(l.First(), l.Count);
        }
        //You have to create a function that takes a positive integer number and returns the next bigger number formed by thw
        //same digits:
        public static string Factorial(int n)
        {             
            if (n < 0) return "";
            BigInteger result = n == 1 || n==0 ? 1 : n * (n-1);
            
            for (long i=n-1;i>1; i--)
            {
                result = result*(i-1);
            }
            return result.ToString();


        }

        //Write a function called validBraces that takes a string of braces, and determines if the order of the 
        //braces is valid.validBraces should return true if the string is valid, and false if it's invalid.
        public static bool ValidBraces(String braces)
        {
            
            Stack<char> s = new Stack<char>();
            List<char> opening = new  List<char>{ '(', '{', '[' };
            foreach(var c in braces.ToCharArray())
            {       
                if (opening.Contains(c))
                {
                    s.Push(c);
                }
                else
                {
                    if (s.Count.Equals(0))
                        return false;
                    var z = s.Pop();
                    switch (c)
                    {
                        case ')':
                            {
                                if (!z.Equals('('))
                                    return false;
                                break;
                            }
                        case '}':
                            {
                                if (!z.Equals('{'))
                                    return false;
                                break;
                            }
                        case ']':
                            {
                                if (!z.Equals('['))
                                    return false;
                                break;
                            }
                    }
                }
                
            }
            return s.Count!= 0;
        }

        public static bool validBracesNice(string braces)
        {
            var st = new Stack<char>();
            foreach (var c in braces)
                switch (c)
                {
                    case '(':
                    case '[':
                    case '{':
                        st.Push(c);
                        continue;
                    case ')':
                        if (st.Count == 0 || st.Pop() != '(') return false;
                        continue;
                    case ']':
                        if (st.Count == 0 || st.Pop() != '[') return false;
                        continue;
                    case '}':
                        if (st.Count == 0 || st.Pop() != '{') return false;
                        continue;
                }
            return st.Count == 0;
        }
    }
}
