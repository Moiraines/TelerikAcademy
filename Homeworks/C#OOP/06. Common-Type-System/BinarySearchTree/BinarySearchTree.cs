namespace BinarySearchTree
{
    using System;
    class BinarySearchTree<T>
        where T : IComparable<T>
    {
        private TreeNode<T> root;

        public BinarySearchTree()
        {
            this.root = null;
        }

        public void Insert(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }
            this.root = Insert(value, null, root);
        }

        private TreeNode<T> Insert(T value, TreeNode<T> parentNode, TreeNode<T> node)
        {
            if (node == null)
            {
                node = new TreeNode<T>(value);
                node.parent = parentNode;
            }
            else
            {
                int compareTo = value.CompareTo(node.value);
                if (compareTo < 0)
                {
                    node.leftChild =
                    Insert(value, node, node.leftChild);
                }
                else if (compareTo > 0)
                {
                    node.rightChild =
                    Insert(value, node, node.rightChild);
                }
            }
            return node;
        }

        private TreeNode<T> Find(T value)
        {
            TreeNode<T> node = this.root;
            while (node != null)
            {
                int compareTo = value.CompareTo(node.value);
                if (compareTo < 0)
                {
                    node = node.leftChild;
                }
                else if (compareTo > 0)
                {
                    node = node.rightChild;
                }
                else
                {
                    break;
                }
            }
            return node;
        }

        public void Remove(T value)
        {
            TreeNode<T> nodeToDelete = Find(value);
            if (nodeToDelete == null)
            {
                return;
            }
            Remove(nodeToDelete);
        }
        private void Remove(TreeNode<T> node)
        {
            if (node.leftChild != null && node.rightChild != null)
            {
                TreeNode<T> replacement = node.rightChild;
                while (replacement.leftChild != null)
                {
                    replacement = replacement.leftChild;
                }
                node.value = replacement.value;
                node = replacement;
            }

            TreeNode<T> theChild = node.leftChild != null ? node.leftChild : node.rightChild;

            if (theChild != null)
            {
                theChild.parent = node.parent;

                if (node.parent == null)
                {
                    root = theChild;
                }
                else
                {
                    if (node.parent.leftChild == node)
                    {
                        node.parent.leftChild = theChild;
                    }
                    else
                    {
                        node.parent.rightChild = theChild;
                    }
                }
            }
            else
            {
                if (node.parent == null)
                {
                    root = null;
                }
                else
                {
                    if (node.parent.leftChild == node)
                    {
                        node.parent.leftChild = null;
                    }
                    else
                    {
                        node.parent.rightChild = null;
                    }
                }
            }
        }
    }
}
