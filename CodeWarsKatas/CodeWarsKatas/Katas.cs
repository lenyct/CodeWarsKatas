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
   }//end class  
}
