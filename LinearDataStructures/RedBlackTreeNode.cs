using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class RedBlackTreeNode<TKey, TValue> where TKey : IComparable<TKey>
    {
        public TKey Key { private set; get; }

        public TValue Value { set; get; }

        public RedBlackTreeNode<TKey, TValue> LeftNode { set; get; }

        public RedBlackTreeNode<TKey, TValue> RightNode { set; get; }

        public int Size { set; get; }

        public bool IsRed { set; get; }


        public RedBlackTreeNode(TKey key, TValue value, RedBlackTreeNode<TKey, TValue> leftNode, RedBlackTreeNode<TKey, TValue> rightNode, int size, bool isRed = true)
        {
            Key = key;
            Value = value;
            LeftNode = leftNode;
            RightNode = rightNode;
            Size = size;
            IsRed = isRed;
        }
    }
}
