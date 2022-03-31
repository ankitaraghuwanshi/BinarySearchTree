
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class INode<T>
    {
        public T data;
        internal INode<T> leftchild;
        internal INode<T> rightchild;

        public INode(T data)
        {
            this.data = data;
            this.leftchild = null;
            this.rightchild = null;
        }
    }
}