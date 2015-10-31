using System.Security.Principal;

namespace Problem_01
{
    using System;
    using System.Collections.Generic;

    public class Tree<T>
    {
        public TreeNode<T> Root { get; set; }

        private bool isLeaf(TreeNode<T> node)
        {
            if (node.Children.Count == 0)
            {
                return true;
            }

            return false;
        }

        private bool isMiddle(TreeNode<T> node)
        {
            if (node.Children.Count != 0 && !object.ReferenceEquals(node, this.Root))
            {
                return true;
            }

            return false;
        }

        private string Dfs(TreeNode<T> node, Func<TreeNode<T>, bool> check)
        {
            var output = "";
            foreach (var child in node.Children)
            {
                output += Dfs(child, check);
            }

            if (check(node))
            {
                output += node.Value + " ";
            }

            return output;
        }

        private int FindPathLength(TreeNode<T> node)
        {
            if (node.Children.Count == 0)
            {
                return 0;
            }

            int pathLength = 0;
            foreach (var child in node.Children)
            {
                pathLength = Math.Max(pathLength, FindPathLength(child));
            }

            return pathLength + 1;
        }

        public string GetAllLeafs()
        {
            return Dfs(this.Root, isLeaf);
        }

        public string GetAllMiddleNodes()
        {
            return Dfs(this.Root, isMiddle);
        }

        public int GetLongestPath()
        {
            return FindPathLength(this.Root);
        }

        //casting T to int via parsing, cause I've already made the class generic
        public IList<string> GetAllPathsWithGivenSum(int sum)
        {
            IList<string> allPaths = new List<string>();
            FindPathWithSum(sum, (dynamic)this.Root.Value, allPaths, this.Root.Value.ToString(), this.Root, true);
            return allPaths;
        }

        private void FindPathWithSum(
                        int targetSum, 
                        int currentSum, 
                        IList<string> paths, 
                        string currentPath, 
                        TreeNode<T> node, 
                        bool searchOnlyFullPaths )
        {
            var sumFound = (currentSum == targetSum) && (!searchOnlyFullPaths || (node.Children.Count == 0));

            if (sumFound)
            {
                paths.Add(currentPath);
            }

            foreach (var childNode in node.Children)
            {
                var newSum = currentSum + int.Parse(childNode.Value.ToString());
                string newPath = currentPath + " " + childNode.Value;
                FindPathWithSum(targetSum, newSum, paths, newPath, childNode, searchOnlyFullPaths);
            }
        }

        public IList<string> GetAllSubtreeWithGivenSum(int sum)
        {
            IList<string> allPaths = new List<string>();
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(this.Root);
            while (queue.Count !=0)
            {
                var node = queue.Dequeue();
                FindPathWithSum(sum, (dynamic)node.Value, allPaths, node.Value.ToString(), node, false);
                foreach (var childNode in node.Children)
                {
                    queue.Enqueue(childNode);
                }
            }

            return allPaths;

        }
    }
}
