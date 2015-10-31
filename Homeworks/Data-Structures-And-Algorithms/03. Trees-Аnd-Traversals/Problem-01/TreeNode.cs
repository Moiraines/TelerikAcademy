using System.Collections.Generic;

namespace Problem_01
{
    public class TreeNode<T>
    {
        public T Value { get; set; }

        public ICollection<TreeNode<T>> Children { get; private set; }


        public TreeNode(T value)
        {
            this.Value = value;
            this.Children = new List<TreeNode<T>>();
        }

        public void AddChild(TreeNode<T> child)
        {
            this.Children.Add(child);
        }
    }
}
