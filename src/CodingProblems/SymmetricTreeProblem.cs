using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    public class SymmetricTreeProblem
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public bool IsSymmetric(TreeNode root)
        {
            return IsSymmetricIteratively(root.left, root.right);
            //return IsSymmetricRecursive(root.left, root.right);
        }

        private bool IsSymmetricIteratively(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false; 
            if (left.val != right.val) return false;
            
            Stack<TreeNode> stack = new Stack<TreeNode>();

            stack.Push(left.left);
            stack.Push(right.right);
            stack.Push(left.right);
            stack.Push(right.left);

            while(stack.Any())
            {
                TreeNode nodeLeft = stack.Pop();
                TreeNode nodeRight = stack.Pop();

                if (nodeLeft != null && nodeRight != null)
                {
                    if (nodeLeft.val != nodeRight.val) return false;
                
                    stack.Push(nodeLeft.left);
                    stack.Push(nodeRight.right);
                    stack.Push(nodeLeft.right);
                    stack.Push(nodeRight.left);
                }
                else if (nodeLeft != null || nodeRight != null)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsSymmetricRecursive(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;
            if (left.val != right.val) return false;

            return IsSymmetricRecursive(left.left, right.right) && IsSymmetricRecursive(left.right, right.left);
        }
    }
}