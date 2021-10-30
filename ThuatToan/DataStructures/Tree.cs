using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToan.DataStructures
{
    class Node
    {
        private double data;

        public double getData()
        {
            return data;
        }

        public void setData(double data)
        {
            this.data = data;
        }

        public Node getLeft()
        {
            return left;
        }

        public void setLeft(Node left)
        {
            this.left = left;
        }

        public Node getRight()
        {
            return right;
        }

        public void setRight(Node right)
        {
            this.right = right;
        }

        private Node left, right;

        public Node(double data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }
    }
    class Tree
    {
        private int nodeCount = 0;
        private Node root = null;
        public bool isEmpty()
        {
            return size() == 0;
        }
        public int size()
        {
            return nodeCount;
        }
        public int height()
        {
            return height(root);
        }

    }
}
