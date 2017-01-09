using System.Collections.Generic;
using System.Linq;

namespace Geneva
{
    public class leaf
    {
        public int Index { get; set; }
        public bool Ate { get; set; }
        public bool HopperOnLeaf { get; set; }

        public leaf(int index)
        {
            Index = index;
            HopperOnLeaf = Ate = false;            
        }                        
    }
    public class Grasshopper
    {
        private List<leaf> row = new List<leaf>();

        /// <summary>
        /// Initialization of view field with n leaves and grasshopper on leaf 'position'.
        /// </summary>
        /// <param name="n">Number of leaves in row.</param>
        /// <param name="position">Position.</param>
        public Grasshopper(int n, int position)
        {
            for (int i = 0; i <= n; i++)
                row.Add(new leaf(i));
            row.ElementAt(position).HopperOnLeaf = true;
        }

        /// <summary>
        /// Grasshopper has eaten the current leaf and hopped left.
        /// </summary>
        public void EatAndHopLeft()
        {
            var leaf = row.ElementAt(WhereAmI());
            leaf.Ate = true;
            leaf.HopperOnLeaf = false;
            var t = leaf.Index;

            var newleaf = row.Select(x => x).Where(y => y.Index <= t).Skip(2).First(x => x.Ate ==false);
           // row.RemoveAll(x => x.Ate == true);
            newleaf.HopperOnLeaf = true;

        }

        /// <summary>
        /// Grasshopper has eaten the current leaf and hopped right.
        /// </summary>
        public void EatAndHopRight()
        {
            var leaf = row.ElementAt(WhereAmI());
            leaf.Ate = true;
            leaf.HopperOnLeaf = false;
            var t = leaf.Index;            

            var newleaf = row.Select(x => x).Where(y => y.Index >= t).Skip(2).First(x=>x.Ate==false);
            //row.RemoveAll(x => x.Ate == true);
            newleaf.HopperOnLeaf = true;
        }

        /// <returns>Leaf number that grasshopper is feeding on right now.</returns>        
        public int WhereAmI()
        {
            return row.Where(y => y.HopperOnLeaf == true).First().Index;
        }

    }
}
