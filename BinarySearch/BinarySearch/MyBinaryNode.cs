using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class BinaryTree<T> where T : IComparable
    {
        public INode<T> root;
        public void CreateNode(T value)
        {
            INode<T> node = new INode<T>(value);
            if (root == null)
            {
                root = node;
            }
            else
            {
                INode<T> parent = root;
                INode<T> current = root;
                if (current.data.CompareTo(value) >= 0)
                {
                    parent.leftchild = node;
                    return;
                }
                else
                {
                    parent.rightchild = node;
                    return;
                }
            }
        }
        public void Display()
        {
            INode<T> temp = root;
            if (temp != null)
            {
                Console.WriteLine("Root Node:{0}", temp.data.ToString());
            }
            if (temp.leftchild != null)
            {
                Console.WriteLine("Left Node:{0}", temp.leftchild.data.ToString());
            }
            if (temp.rightchild != null)
            {
                Console.WriteLine("Right Node:{0}", temp.rightchild.data.ToString());
            }
        }
    }
}