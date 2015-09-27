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
      // return masked string
      public static string Mask(string cc)
      {
          return cc.Length > 4 ? cc.Substring(cc.Length - 4).PadLeft(cc.Length, '#') : cc;
      }

      public static double CalculateAreaOfCircle(string radius)
      {
          double r;
          if(!double.TryParse(radius, out r) || r<=0)
             throw new ArgumentException();
          var t = Math.Round(r * r * Math.PI, 2);
          return t;
      }


      public static int GetMissingCandies(int[] candies)
      {
          int max = candies.Max();
          
          return candies.Length >=1? candies.Select(x => max - x).Sum() : -1;
      }

      public static int DescendingOrder(int num)
      {
          return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
      }

      public static int GetVowelCount(string str)
      {
          Regex r = new Regex("[aeiou]",RegexOptions.IgnoreCase);
          return r.Matches(str).Count;    
      }

      public static string[] CapMe(string[] strings)
      {
          //strings =
         return strings.Select(a => a.ToLower().Insert(0, a.ElementAt(0).ToString().ToUpper()).Remove(1,1)).ToArray();
        //  return strings;
      }

      public static string ShorterReverseLonger(string a, string b)
      {
          a = String.IsNullOrWhiteSpace(a) ? "" : a;
          b = String.IsNullOrWhiteSpace(b) ? "" : b;
          String shorter =( a.Count() < b.Count() ? a : b);
          String longer = new String(a.Count() >= b.Count() ? a.ToCharArray().Reverse().ToArray() : b.ToCharArray().Reverse().ToArray());
          
          return new StringBuilder(shorter + longer + shorter).ToString();
      }

      public static bool IsSquare(int input)
      {
          return Math.Sqrt(input) % 1 == 0;
      }

      public static int FilterString(string s)
      {
          return Convert.ToInt32(Regex.Replace(s, @"[^0-9]+", ""));
      }
     
      //Filters numbers from strings and returns the results
      public static string FilterNumbers(string str)
      {         
         return  new string(str.Where(c => !char.IsDigit(c)).ToArray());          
      }

      public static int FindSmallest(int[] numbers, string toReturn)
      {
         return toReturn.Equals("value") ? numbers.Min() : Array.IndexOf(numbers, numbers.Min());
      }


      public static int[] DeleteNth(int[] arr, int x)
      {
          var a = new List<int>();

          foreach (int b in arr)
              if (a.Count(i => i.Equals(b)) < x)
                  a.Add(b);
          return a.ToArray();
      }

      public static List<String> GameStop(int start, int end)
      {
          List<String> list = new List<string>();
          for (int i = start; i <= end; i++)
          {
              if (i % 3 == 0 && i % 5==0)
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
   }//end class  
}
