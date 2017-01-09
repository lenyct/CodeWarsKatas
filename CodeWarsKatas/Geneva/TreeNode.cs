using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geneva
{
    public class TreeNode
    {
        public TreeNode LeftChild { get; private set; }
        public TreeNode RightChild { get; private set; }

        public TreeNode(TreeNode leftChild, TreeNode rightChild)
        {
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }
    }
}
