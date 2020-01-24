using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    public class Tree<T> : AlgorithmBase<T> where T : IComparable
    {
        private Node<T> Root { get; set; }
        public Tree() { }
        public Tree(IEnumerable<T> items)
        {
            var list = items.ToList();
            for (int i = 0; i < items.Count(); i++)
            {
                var item = list[i];
                Items.Add(item);
                var node = new Node<T>(item, i);
                Add(node);
            }
        }
        public int Count { get; private set; }
        private void Add(Node<T> node)
        {
            if (Root == null)
            {
                Root = node;
                Count = 1;
                return;
            }
            Add(Root, node);
            Count++;
        }
        private void Add(Node<T> node, Node<T> newNode)
        {
            if (Compare(node.Data, newNode.Data) == 1)
            {
                if (node.Left == null)
                {
                    node.Left = newNode;
                }
                else
                {
                    Add(node.Left, newNode);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = newNode;
                }
                else
                {
                    Add(node.Right, newNode);
                }
            }
        }
        protected override void MakeSort()
        {
            var result = InOrder(Root).Select(r => r.Data).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Set(i, result[i]);
            }
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
        private List<Node<T>> InOrder(Node<T> node)
        {
            var list = new List<Node<T>>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(InOrder(node.Left));
                }
                list.Add(node);
                if (node.Right != null)
                {
                    list.AddRange(InOrder(node.Right));
                }
            }
            return list;
        }
    }
}
