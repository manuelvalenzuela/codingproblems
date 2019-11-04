using System.ComponentModel.Design;

namespace CodingProblems
{
    public class IsSubtreeProblem
    {
        public static bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (s == null && t == null)
            {
                return true;
            }

            if (s == null || t == null)
            {
                return false;
            }

            if (IsEqual(s, t))
            {
                return true;
            }

            return IsSubtree(s.left, t) || IsSubtree(s.right, t);

        }

        private static bool IsEqual(TreeNode s, TreeNode t)
        {
            if (s == null && t == null)
            {
                return true;
            }

            if (s == null || t == null)
            {
                return false;
            }

            return s.val == t.val && IsEqual(s.left, t.left) && IsEqual(s.right, t.right);
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }
}