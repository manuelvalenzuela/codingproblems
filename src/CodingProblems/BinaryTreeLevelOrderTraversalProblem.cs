using System.Collections.Generic;

namespace CodingProblems
{
    public class BinaryTreeLevelOrderTraversalProblem
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

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> result = new ();
            if (root is null) return result;

            Queue<TreeNode> queue = new();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                List<int> levelN = new();
                int actualQueueSize = queue.Count;

                for (int i = 0; i < actualQueueSize; i++)
                {
                    TreeNode node = queue.Dequeue();
                    levelN.Add(node.val);
                    if (node.left is not null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right is not null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                result.Add(levelN);
            }

            return result;
        }
    }
}