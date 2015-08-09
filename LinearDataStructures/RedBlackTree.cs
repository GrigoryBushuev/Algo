using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class RedBlackTree<TNode, TKey, TValue> where TKey : IComparable<TKey> where TNode : RedBlackTreeNode<TKey, TValue>
    {
        private RedBlackTreeNode<TKey, TValue> _root;

        private void RotateLeft()
        {

        }

        private void RotateRight()
        {

        }

        private void FlipColors()
        {

        }

        public void Add(TKey key, TValue value)
        {
            Add(_root, key, value);
        }

        public RedBlackTreeNode<TKey, TValue> Add(RedBlackTreeNode<TKey, TValue> node, TKey key, TValue value)
        {
            if (node == null)
                node = new RedBlackTreeNode<TKey, TValue>(key, value, null, null, 1, false);

            int cmp = key.CompareTo(node.Key);
            if (cmp < 0)
                node.LeftNode = Add(node, key, value);
            else if (cmp > 0)
                node.RightNode = Add(node, key, value);
            else
                node.Value = value;

            //Red-black magic is here
            return node;
        }
    }
}
