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
            for (int i = 0; i <=  n; i++)
                row.Add(new leaf(i));
            row.ElementAt(position).HopperOnLeaf = true;
        }

        /// <summary>
        /// Grasshopper has eaten the current leaf and hopped left.
        /// </summary>
        public void EatAndHopLeft()
        {
            var leafIndex = visitLeaf();

            var newleaf = row.Select(x => x).Where(y => y.Index <= leafIndex).OrderByDescending(c=>c.Index).Skip(2).First(x => x.Ate ==false);          
            newleaf.HopperOnLeaf = true;

        }

        /// <summary>
        /// Grasshopper has eaten the current leaf and hopped right.
        /// </summary>
        public void EatAndHopRight()
        {
            int leafIndex = visitLeaf();

            var newleaf = row.Select(x => x).Where(y => y.Index >= leafIndex).Skip(2).First(x => x.Ate == false);            
            newleaf.HopperOnLeaf = true;
        }

        private int visitLeaf()
        {
            var leaf = row.Where(y => y.HopperOnLeaf == true).First();
            leaf.Ate = true;
            leaf.HopperOnLeaf = false;
            var leafIndex = leaf.Index;
            return leafIndex;
        }

        /// <returns>Leaf number that grasshopper is feeding on right now.</returns>        
        public int WhereAmI()
        {
            return row.IndexOf(row.Where(y => y.HopperOnLeaf == true).First());
        }

    }
}
