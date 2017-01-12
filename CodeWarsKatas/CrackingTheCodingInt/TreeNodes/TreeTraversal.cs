using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInt.TreeNodes
{
    public static class TreeTraversal
    {
        public static int getHeight(TreeNode root)
        {
            if (root == null) return 0;

            return Math.Max(getHeight(root.LeftChild), 
                getHeight(root.RightChild)) +1;
        }
    }
}
