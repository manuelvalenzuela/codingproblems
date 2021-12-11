using System.Collections.Generic;

namespace CodingProblems
{
    public class BinaryTreeZigzagLevelOrderTraversalProblem
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

        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            List<IList<int>> result = new();
            if (root is null) return result;

            Stack<TreeNode> s1 = new();
            Stack<TreeNode> s2 = new();

            s1.Push(root);

            while (s1.Count > 0 || s2.Count > 0)
            {
                List<int> levelN = new();

                while (s1.Count > 0)
                {
                    TreeNode node = s1.Pop();
                    levelN.Add(node.val);
                    if (node.left is not null)
                    {
                        s2.Push(node.left);
                    }
                    if (node.right is not null)
                    {
                        s2.Push(node.right);
                    }
                }
                result.Add(levelN);
                levelN = new();

                while (s2.Count > 0)
                {
                    TreeNode node = s2.Pop();
                    levelN.Add(node.val);
                    if (node.right is not null)
                    {
                        s1.Push(node.right);
                    }
                    if (node.left is not null)
                    {
                        s1.Push(node.left);
                    }
                }
                if (levelN.Count > 0)
                {
                    result.Add(levelN);
                }
            }

            return result;
        }

        public enum Movement
        {
            Left,
            Right
        }

        public IList<IList<int>> ZigzagLevelOrderV2(TreeNode root)
        {
            List<IList<int>> result = new();
            if (root is null) return result;

            Queue<TreeNode> queue = new();

            queue.Enqueue(root);

            Movement movement = Movement.Right;

            while (queue.Count > 0)
            {
                List<int> levelN = new();
                int actualQueueSize = queue.Count;

                for (int i = 0; i < actualQueueSize; i++)
                {
                    TreeNode node = queue.Dequeue();
                    if (movement == Movement.Right)
                    {
                        levelN.Add(node.val);
                    }
                    else
                    {
                        levelN.Insert(0, node.val);
                    }

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
                if (movement == Movement.Right)
                {
                    movement = Movement.Left;
                }
                else
                {
                    movement = Movement.Right;
                }
            }

            return result;
        }

        public IList<IList<int>> ZigzagLevelOrderV3(TreeNode root)
        {
            List<IList<int>> result = new();
            if (root is null) return result;

            Queue<TreeNode> queue = new();

            queue.Enqueue(root);

            Movement movement = Movement.Right;

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

                if (movement == Movement.Right)
                {
                    movement = Movement.Left;
                }
                else
                {
                    levelN.Reverse();
                    movement = Movement.Right;
                }
                result.Add(levelN);
            }

            return result;
        }
    }
}