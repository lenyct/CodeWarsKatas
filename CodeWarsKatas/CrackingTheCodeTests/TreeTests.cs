using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CrackingTheCodingInt.TreeNodes;

namespace CrackingTheCodeTests
{
    [TestFixture]
    public class TreeTests
    {
        [Test]
        public void TestHeightOfTree()
        {
            TreeNode leaf1 = new TreeNode(null, null);
            TreeNode leaf2 = new TreeNode(null, null);
            TreeNode leaf3 = new TreeNode(null, null);
            TreeNode node2 = new TreeNode(leaf1, null);
            TreeNode node3 = new TreeNode(leaf1, null);
            TreeNode node = new TreeNode(node2, null);
            TreeNode root = new TreeNode(node, null);

            Assert.AreEqual(4, TreeTraversal.GetHeight(root));
        }

        [Test]
        public void TestBalancedTree()
        {
            TreeNode leaf1 = new TreeNode(null, null);
            TreeNode leaf2 = new TreeNode(null, null);
            TreeNode leaf3 = new TreeNode(null, null);
            TreeNode node2 = new TreeNode(leaf1, null);
            TreeNode node3 = new TreeNode(leaf1, null);
            TreeNode node = new TreeNode(node2, null);
            TreeNode root = new TreeNode(node, node);

            Assert.AreEqual(4, TreeTraversal.GetHeight(root));
        }
    }
}
