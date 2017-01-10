using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public static string sumStrings(string a, string b)
        {
             BigInteger number1;
            BigInteger number2;

            BigInteger.TryParse(a, out number1);
            BigInteger.TryParse(b, out number2);
            return (number1 + number2).ToString();
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

        public static int IsSolved(int[,] board)
        {

            var t = playerWin(1, board);
            var t2 = playerWin(2, board);

            if (t > t2)
                return 1;
            else if (t2 > t)
                return 2;
            else
                return -1;


        }

        private static int playerWin(int player, int[,] board)
        {
            List<int[,]> wins = new List<int[,]>();

            //down wins
            if ((player + board[0, 0])
                + player + board[1, 0]
                + player + board[2, 0] == ((player * 3) * 2))
                return player;

            if ((player + board[0, 1])
                 + player + board[1, 1]
                 + player + board[2, 1] == ((player * 3) * 2))
                return player;

            if ((player + board[0, 2])
                 + player + board[1, 2]
                 + player + board[2, 2] == ((player * 3) * 2))
                return player;
            //across wins
            if ((player + board[0, 0])
                 + player + board[0, 1]
                 + player + board[0, 2] == ((player*3)*2) )
                return player;


            if ((player + board[1, 0]) 
                  + player + board[1, 1]
                  + player + board[1, 2] == ((player * 3) * 2))
                return player;

            if ((player + board[2, 0])
                 + player + board[2, 1]
                 + player + board[2, 2] == ((player * 3) * 2))
                return player;

            //Cross wins
            if ((player + board[0, 2])
                 + player + board[1, 1]
                 + player + board[2, 0] == ((player * 3) * 2))
                return player;

            if ((player + board[0, 0])
                 + player + board[1, 1]
                 + player + board[2, 2] == ((player * 3) * 2))
                return player;

            return -1;


        }
    }
}

    
