using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInt.TreeNodes
{
    public class TreeNode
    {
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }

        public TreeNode(TreeNode leftChild, TreeNode rightChild)
        {
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }
    }
}
