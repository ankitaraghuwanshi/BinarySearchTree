using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Binary search tree problem ");
            ViewBST();
            Console.ReadLine();
        }

        public static void ViewBST()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.CreateNode(56);
            tree.CreateNode(30);
            tree.CreateNode(70);
            Console.WriteLine("Display Nodes");
            tree.Display();
        }
    }

}