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

   }//end class  
}
