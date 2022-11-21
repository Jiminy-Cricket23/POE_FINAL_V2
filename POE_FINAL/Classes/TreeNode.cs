using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_FINAL.Classes
{
    /// <summary>
    /// Using code from class for the Tree
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class TreeNode<T> : IEnumerable<TreeNode<T>>
    {
        public T Data { get; set; }
        public TreeNode<T> Parent { get; set; }
        public ICollection<TreeNode<T>> Children { get; set; }
        private ICollection<TreeNode<T>> Elements { get; set; }
        private ICollection<TreeNode<T>> ElementsIndex { get; set; }

        /// <summary>
        /// Returns if node is a Root
        /// </summary>
        public Boolean isRoot
        {
            get { return Parent == null; }
        }

        /// <summary>
        /// Returns if node is a leaf
        /// </summary>
        public Boolean isLeaf
        {
            get { return Children.Count == 0; }
        }

        /// <summary>
        /// Finds the level of the node
        /// </summary>
        public int Level
        {
            get
            {
                if (this.isRoot)
                    return 0;
                return Parent.Level + 1;
            }
        }

        /// <summary>
        /// Constructor for treeNode class
        /// </summary>
        /// <param name="data"></param>
        public TreeNode(T data)
        {
            this.Data = data;
            this.Children = new LinkedList<TreeNode<T>>();

            this.ElementsIndex = new LinkedList<TreeNode<T>>();
            this.ElementsIndex.Add(this);
        }

        /// <summary>
        /// Generating a node / child
        /// </summary>
        /// <param name="child"></param>
        /// <returns></returns>
        public TreeNode<T> AddChild(T child)
        {
            TreeNode<T> childNode = new TreeNode<T>(child) { Parent = this };
            this.Children.Add(childNode);
            this.RegisterChildForSearch(childNode);

            return childNode;
        }

        /// <summary>
        /// Converts the nodes to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Data != null ? Data.ToString() : "[DataNull]";
            // if data != null then (?) else :
        }

        /// <summary>
        /// This method registers the child for a search as soon as it is added
        /// </summary>
        /// <param name="node"></param>
        private void RegisterChildForSearch(TreeNode<T> node)
        {
            ElementsIndex.Add(node);
            if (Parent != null)
                Parent.RegisterChildForSearch(node);
        }

        /// <summary>
        /// A method that returns a node using a LINQ statement
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public TreeNode<T> FindTreeNode(Func<TreeNode<T>, bool> predicate)
        {
            return this.ElementsIndex.FirstOrDefault(predicate);
        }

        /// <summary>
        /// Returns a IEnumerator for the tree
        /// </summary>
        /// <returns></returns>
        public IEnumerator<TreeNode<T>> GetEnumerator()
        {
            yield return this;
            foreach (var directChild in this.Children)
            {
                foreach (var anyChild in directChild)
                    yield return anyChild;
            }

        }

        /// <summary>
        /// Returns the above method
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
