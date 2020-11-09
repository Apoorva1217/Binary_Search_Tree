using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Node<T>
    {
        public T data;
        public Node<T> leftNode;
        public Node<T> rightNode;

        public Node(T data)
        {
            this.data = data;
            this.leftNode = null;
            this.rightNode = null;
        }
    }
}
