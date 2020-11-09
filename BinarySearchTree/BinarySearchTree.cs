using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T:IComparable<T>
    {
        Node<T> Root;
        Node<T> currentNodeValue;
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }
       
        public void Insert(T item)
        {
            if (Root == null)
            {
                this.Root = new Node<T>(item);
                this.currentNodeValue = Root;
                return;
            }
            if ((this.currentNodeValue.data.CompareTo(item)) > 0)
            {
                ///Checks if left node is null.
                if (this.currentNodeValue.leftNode == null)
                {
                    this.currentNodeValue.leftNode = new Node<T>(item);
                    this.currentNodeValue = Root;
                }
                else
                {
                    this.currentNodeValue = this.currentNodeValue.leftNode;
                    Insert(item);
                }
            }
            else
            {
                ///Checks if right node is null.
                if (this.currentNodeValue.rightNode == null)
                {
                    this.currentNodeValue.rightNode = new Node<T>(item);
                    this.currentNodeValue = Root;
                }
                else
                {
                    this.currentNodeValue = this.currentNodeValue.leftNode;
                    Insert(item);
                }
            }

        }
        public Node<T> GetRoot()
        {
            return this.Root;
        }
        public void Display(Node<T> node)
        {
            if (node != null)
            {
                Display(node.leftNode);
                Console.WriteLine("Elements in Binary Search Tree: " + node.data);
                Display(node.rightNode);
            }
        }
    }
}
