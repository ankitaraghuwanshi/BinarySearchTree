using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class MyBinaryTree<T> where T : IComparable
    {
        public INode<T> root;

        public void CreateNode(T value)
        {
            INode<T> newNode = new INode<T>(value);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                INode<T> parent = root;
                INode<T> current = root;
                while (true)
                {
                    parent = current;
                    if (current.data.CompareTo(value) >= 0)
                    {
                        current = current.leftchild;
                        if (current== null)
                        {
                            parent.leftchild = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.rightchild;
                        if (current== null)
                        {
                            parent.rightchild = newNode;
                            break;
                        }
                    }
                }
            }
        }
        //Display Root Node.
        public void Root()
        {
            do
            {
                Console.WriteLine("BST Root Node:" + root.data);
                break;
            } while (root != null);
        }

        /// Displays Nodes in BST
        public void Display(INode<T> parent)
        {
            if (parent != null)
            {
                Display(parent.leftchild);
                Display(parent.rightchild);
                Console.WriteLine("{0} is BST Node", parent.data);
            }
        }

        private void Display(object right)
        {
            throw new NotImplementedException();
        }

        public int Size(INode<T> root)
        {
            if (root == null)
                return 0;
            else
                return Size(root.leftchild) + 1 + Size(root.rightchild);
        }

    }
}