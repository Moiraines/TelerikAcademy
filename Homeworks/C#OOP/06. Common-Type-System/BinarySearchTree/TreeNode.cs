namespace BinarySearchTree
{
    using System;
    using System.Collections.Generic;
    public class TreeNode<T> : ICloneable, IComparable<TreeNode<T>>
        where T : IComparable<T>
    {
        internal T value;
        internal TreeNode<T> parent;
        internal TreeNode<T> leftChild;
        internal TreeNode<T> rightChild;

        //constructors

        public TreeNode(T value)
        {
            this.value = value;
            this.parent = null;
            this.leftChild = null;
            this.rightChild = null;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }

        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            TreeNode<T> other = (TreeNode<T>)obj;
            return this.CompareTo(other) == 0;
        }

        public int CompareTo(TreeNode<T> other)
        {
            return this.value.CompareTo(other.value);
        }
    }
}
