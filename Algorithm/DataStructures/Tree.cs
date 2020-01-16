using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    class Tree<T> where T : IComparable
    {
        public Node<T> Root { get; private set; }

        public Tree() { }

        public Tree(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public int Count { get; private set; }

        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }
            Root.Add(data);
            Count++;
        }

        public List<T> Preorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }
            return Preorder(Root);
        }

        public List<T> PostOrder()
        {
            if (Root == null)
            {
                return new List<T>();
            }
            return PostOrder(Root);
        }

        public List<T> InOrder()
        {
            if (Root == null)
            {
                return new List<T>();
            }
            return InOrder(Root);
        }

        private List<T> Preorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                list.Add(node.Data);

                if (node.Left != null)
                {
                    list.AddRange(Preorder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(Preorder(node.Right));
                }
            }
            return list;
        }

        private List<T> PostOrder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(PostOrder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(PostOrder(node.Right));
                }
                list.Add(node.Data);
            }
            return list;
        }

        private List<T> InOrder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(InOrder(node.Left));
                }
                list.Add(node.Data);
                if (node.Right != null)
                {
                    list.AddRange(InOrder(node.Right));
                }
            }
            return list;
        }

    }
}
