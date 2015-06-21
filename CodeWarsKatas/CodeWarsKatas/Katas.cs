using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
   }//end class  
}
