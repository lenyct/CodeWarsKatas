using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInt.TreeNodes
{
    public static class TreeTraversal
    {
        public static int GetHeight(TreeNode root)
        {
            if (root == null) return 0;

            return Math.Max(GetHeight(root.LeftChild),
                GetHeight(root.RightChild)) + 1;
        }

        public static bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;

            int heightDiff = (GetHeight(root.LeftChild) - GetHeight(root.RightChild));

            if (heightDiff > 1)
                return false;
            else
                return IsBalanced(root.LeftChild) && IsBalanced(root.RightChild);
        }

        //public static string BFS(TreeNode node)
        //{
        //    Queue<TreeNode> q = new Queue<TreeNode>();
        //    StringBuilder sb = new StringBuilder();
        //    q.Enqueue(node);
        //    while (q.Count > 0)
        //    {
        //        var child = q.Dequeue();
        //        sb.Append(child.ToString());
        //        if (child.LeftChild != null)
        //            q.Enqueue(child.LeftChild);
        //        if (child.RightChild != null)
        //            q.Enqueue(child.RightChild);
                
        //    }

        //    return sb.ToString();
        //}


    }
}