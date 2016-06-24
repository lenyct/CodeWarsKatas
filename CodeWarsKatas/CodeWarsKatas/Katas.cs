using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CodeWarsKatas
{
    public class Katas
    {
      // return masked string and only revel last four digits. current account example
      public static string Mask(string cc)
      {
          return cc.Length > 4 ? cc.Substring(cc.Length - 4).PadLeft(cc.Length, '#') : cc;
      }

        //Method that takes string input determines if double and returns radius. throws exception if invalid
      public static double CalculateAreaOfCircle(string radius)
      {
          double r;         
          if(!double.TryParse(radius, out r) || r<=0)
             throw new ArgumentException();
          var t = Math.Round(r * r * Math.PI, 2);
          return t;
      }

      //Given a int[] that where each entry represents a child. ad its value represents the amount of candy they have,
        //to give the same number of candy to each child how much more is needed so all children have the same
      public static int GetMissingCandies(int[] candies)
      {        
         int max = candies.Max();
          
         return candies.Count() > 1 ? candies.Select(x => max - x).Sum() : -1;          
      }

      //re order an int into decending order => 4536721 => 7654321
      public static int DescendingOrder(int num)
      {
          return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
      }

     //Takes a sting input and returns number of vowels within the string
      public static int GetVowelCount(string str)
      {
          Regex r = new Regex("[aeiou]",RegexOptions.IgnoreCase);
          return r.Matches(str).Count;    
      }

      //Takes a String input, and returns the strings with first letter capped and rest lowercase
      public static string[] CapMe(string[] strings)
      {
         return strings.Select(a => a.ToLower().Insert(0, a.ElementAt(0).ToString().ToUpper()).Remove(1,1)).ToArray();        
      }

        //find shortest string, reverse longer, concat so that shorter + longerReversed + shorter
        //if both the same 1st param + reversed second param + 1st param
      public static string ShorterReverseLonger(string a, string b)
      {
          a = String.IsNullOrWhiteSpace(a) ? "" : a;
          b = String.IsNullOrWhiteSpace(b) ? "" : b;
          String shorter =( a.Count() < b.Count() ? a : b);
          String longer = new String(a.Count() >= b.Count() ? a.ToCharArray().Reverse().ToArray() : b.ToCharArray().Reverse().ToArray());
          
          return new StringBuilder(shorter + longer + shorter).ToString();
      }
        //determine if the input is square number
      public static bool IsSquare(int input)
      {
          return Math.Sqrt(input) % 1 == 0;
      }

        //Strip any numbers from a string
      public static int FilterString(string s)
      {
          return Convert.ToInt32(Regex.Replace(s, @"[^0-9]+", ""));
      }
     
      //Filters numbers from strings and returns the results
      public static string FilterNumbers(string str)
      {         
         return  new string(str.Where(c => !char.IsDigit(c)).ToArray());          
      }

      //find smallest entry, if value passed then get smallest number present, if index passed find the position of smallest 
      public static int FindSmallest(int[] numbers, string toReturn)
      {
         return toReturn.Equals("value") ? numbers.Min() : Array.IndexOf(numbers, numbers.Min());
      }

        //delete the nth recuring input
      public static int[] DeleteNth(int[] arr, int x)
      {
          var a = new List<int>();

          foreach (int b in arr)
              if (a.Count(i => i.Equals(b)) < x)
                  a.Add(b);
          return a.ToArray();
      }

        //for multiples of 3 print Game, multiples of 5 print stop. for multiples of 3 and 5 print gamestop
      public static List<String> GameStop(int start, int end)
      {
          List<String> list = new List<string>();

          for (int i = start; i <= end; i++)
          {
              if (i%15==0)
                  list.Add("GameStop");
              else if (i % 3 == 0)
                  list.Add("Game");
              else if (i % 5 == 0)
                  list.Add("Stop");
              else
                  list.Add(i.ToString());
          }
          return list;
      }

        //Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, 
        //which is the number of times you must multiply the digits in num until you reach a single digit.
        //persistence(39) == 3 // because 3*9 = 27, 2*7 = 14, 1*4=4
        // and 4 has only one digit
      public static int Persistence(long n)
      {
          return n < 10 ? 0 : RecursivePersistence(n);         
      }

      private static int RecursivePersistence(long n)
      {
          var count = 1;
          var sum = n.ToString().ToList().Select(x => int.Parse(x.ToString())).Aggregate((a, x) => a * x);

          if (sum < 10)
              return count;
          return count += Persistence(sum);
      }

      public static bool isMerge(string s, string part1, string part2)
      {
          var concated = part2.ToArray().Concat(part1.ToArray()).ToArray();
          var test = concated.Select(x=>x).Where(x => s.Contains(x)).ToArray();
     
          if (s.Length ==(test.Length))
              return true;
          return false;
      }
      
    //The action of a Caesar cipher is to replace each plaintext letter with a different one a fixed number of places up or down 
    //the alphabet.
    //This program performs a variation of the Caesar shift. The shift increases by 1 for each character (on each iteration).
    //If the shift is initially 1, the first character of the message to be encoded will be shifted by 1, 
      //the second character will be shifted by 2, etc...
      #region cipher
      public static List<string> movingShift(string s, int shift)
      {
          StringBuilder sb = new StringBuilder();
          foreach (Char c in s)
          {
              if (char.IsLetter(c))
                  sb.Append(cipher((int)c, shift));
              else
                  sb.Append(c);

              shift++;
                
          }
          //covert to 5 runners
          return seperateOut(sb);        
      }

      private static List<string> seperateOut(StringBuilder sb)
      {
          var seperator = sb.ToString().Count() / 5;
          List<string> list = new List<string>();
          for (int i = 0; i < 4; i++)
          {
              list.Add(sb.ToString().Substring(0, seperator));
              sb.Remove(0, seperator);
          }
          list.Add(sb.ToString());
          return list;
      }

       private static bool isLowerCharacter(int c)
       {
           if (c >= (int)'a' && c <= (int)'z')
               return true;
           return false;
       }

      private static char cipher(int c, int shift)
      {

          if (isLowerCharacter(c))
          {
              var lowerZ = (int)'z';

              var t = ((int)c + (shift %26));
              if (t > lowerZ)
                  t = (int)'a' + (t - lowerZ)-1;
              return (char)t;
          }
          else
          {
              var UpperZ = (int)'Z';

              var t = ((int)c + (shift % 26));
              if (t > UpperZ)
                  t = (int)'A' + (t - UpperZ)-1;
              return (char)t;
          }           
      }

      private static char deciphier(int c, int shift)
      {
          if (isLowerCharacter(c))
          {
              var lowerA = (int)'a';

              var t = ((int)c - (shift % 26));
              if (t < lowerA)
              {
                  t = (int)'z' - ((t - lowerA) * -1) + 1;
              }                  
              return (char)t;
          }
          else
          {
              var UpperA = (int)'A';

              var t = ((int)c - (shift % 26));
              if (t < UpperA)
                  t = (int)'Z' - ((t - UpperA) * -1) + 1;
              return (char)t;
          } 
      }

      public static string demovingShift(List<string> s, int shift)
      {
          StringBuilder sb = new StringBuilder();
          foreach (string line in s)
          {
              foreach (char c in line)
              {
                  if (char.IsLetter(c))
                      sb.Append(deciphier((int)c, shift));
                  else
                      sb.Append(c);

                  shift++;

              }              
          }
          var t = sb.ToString();
          return sb.ToString();
      }
#endregion

      public static string Pattern(int n)
      {
          StringBuilder sb = new StringBuilder();
          for (int i = n; i > 0; i--)
          {
              var temp = n;
              for (int j = i; j > 0; j--)
              {
                  sb.Append(temp--);
              }

              if (i > 1)
                  sb.Append("\n");              
          }
          return sb.ToString();
      }

      public static int[] Capitals(string word)
      {
          var letters = word.ToCharArray();
          return letters.Select((x, i) => new { x, i })
                        .Where(y => char.IsUpper(y.x))
                        .Select(z => z.i)
                        .ToArray();
      }

      public static int evaporator(double content, double evap_per_day, double threshold)
      {
          threshold = (content / 100) * threshold;
          int day = 0;
          while(content>=threshold)
          {
              content -= (content / 100) * evap_per_day;
              day++;
          }
          return day;          
      }

      public static string Swap(string str)
      {
          var t = str.Select(n => char.IsUpper(n) ? char.ToLower(n) : char.ToUpper(n));
          //foreach(char c in str)
             // char
          return t.ToString();
      }

        public static string PigIt(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var t in Regex.Split(str, " "))
            {
               var g = t.Remove(0, 1);
               sb.Append(g).Append(t[0]).Append("ay ");
            }
            var val = sb.ToString().TrimEnd();
            return val;
        }
    }//end class  
}
