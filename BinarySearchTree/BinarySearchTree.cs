using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T:IComparable<T>
    {
        Node<T> Root;
        Node<T> currentNodeValue;
        int count = 0;
        bool result = false;
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }
       
        /// <summary>
        /// Insert item into binary search tree
        /// </summary>
        /// <param name="item"></param>
        public void Insert(T item)
        {
            if (Root == null)
            {
                this.Root = new Node<T>(item);
                this.currentNodeValue = Root;
                count++;
                return;
            }
            if (this.currentNodeValue.data.CompareTo(item) > 0)
            {
                if (this.currentNodeValue.leftNode == null)
                {
                    this.currentNodeValue.leftNode = new Node<T>(item);
                    this.currentNodeValue = Root;
                    count++;
                }
                else
                {
                    this.currentNodeValue = this.currentNodeValue.leftNode;
                    Insert(item);
                }
            }
            else
            {
                if (this.currentNodeValue.rightNode == null)
                {
                    this.currentNodeValue.rightNode = new Node<T>(item);
                    this.currentNodeValue = Root;
                    count++;
                }
                else
                {
                    this.currentNodeValue = this.currentNodeValue.leftNode;
                    Insert(item);
                }
            }
        }

        /// <summary>
        /// count the number of elements in BST
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            Console.WriteLine("Count of elements in Binary Search Tree: ");
            return count;
        }

        /// <summary>
        /// Get the root element
        /// </summary>
        /// <returns></returns>
        public Node<T> GetRoot()
        {
            return this.Root;
        }

        /// <summary>
        /// display elements in BST
        /// </summary>
        /// <param name="node"></param>
        public void Display(Node<T> node)
        {
            if (node != null)
            {
                Display(node.leftNode);
                Console.WriteLine("Elements in Binary Search Tree: " + node.data);
                Display(node.rightNode);
            }
        }

        /// <summary>
        /// Search elements in BST
        /// </summary>
        /// <param name="element"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool Search(T element ,Node<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (this.currentNodeValue.data.Equals(element))
            {
                Console.WriteLine("Found the element in BST: " + this.currentNodeValue.data);
                result = true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in BST", this.currentNodeValue.data);
            }
            if (this.currentNodeValue.data.CompareTo(element) < 0)
            {
                this.currentNodeValue = this.currentNodeValue.leftNode;
                Search(element, currentNodeValue);
            }
            else
            {
                this.currentNodeValue = this.currentNodeValue.rightNode;
                Search(element, currentNodeValue);
            }
            return result;
        }
    }
}
