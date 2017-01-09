using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geneva
{
    public class TreeHeight
    {
        public static int CalculateHeight(TreeNode root)
        {
            if (root == null)
                return 0;


            int leftCount =  CalculateHeight(root.LeftChild);
            int rightCount = CalculateHeight(root.RightChild);

            if (leftCount > rightCount)
                return leftCount + 1;
            else
                return rightCount + 1;
            
        }

       
    }
}
