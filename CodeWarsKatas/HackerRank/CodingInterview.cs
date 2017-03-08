using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class CodingInterview
    {
        //Input Format
        //The first line contains two space-separated integers denoting the respective values of
        //(the number of integers) and
        //(the number of left rotations you must perform). 
        //The second line contains
        //space-separated integers describing the respective elements of the array's initial state.
        //Print a single line of 
        //Output
        //space-separated integers denoting the final state of the array after performing
        //left rotations.
        public static string RotateLeftKTimes(int n, int k, int[] array)
        {
            var rots = array.Take(k).ToArray();
            var start = array.Skip(k).TakeWhile(x => true).ToArray();
            return string.Join(" ", start.Concat(rots));
        }

        public static string CamelCaseCounter(string s)
        {
            return Regex.Split(s, "[A-Z]").Count().ToString();
        }
    }
}
