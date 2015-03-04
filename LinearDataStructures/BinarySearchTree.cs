using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
	public class BinarySearchTree<TKey, TValue> where TKey : IComparable<TKey> where TValue : IComparable<TValue>
	{
		private BinarySearchTreeNode<TKey, TValue> root;

		public BinarySearchTreeNode<TKey, TValue> GetByKey(TKey key)
		{
			return GetByKey(key);
		}

		private BinarySearchTreeNode<TKey, TValue> GetByKey(BinarySearchTreeNode<TKey, TValue> rootNode, TKey key)
		{
			BinarySearchTreeNode<TKey, TValue> result = null;
			if (key.CompareTo(rootNode.Key) > 0)
				result = GetByKey(rootNode.RightNode, key);
			else
				result = GetByKey(rootNode.LeftNode, key);

			return result;
		}

		public BinarySearchTreeNode<TKey, TValue> Add(TKey key, TValue value)
		{
			return Add(root, key, value);
		}

		private BinarySearchTreeNode<TKey, TValue> Add(BinarySearchTreeNode<TKey, TValue> rootNode, TKey key, TValue value)
		{
			if (rootNode == null)
				return new BinarySearchTreeNode<TKey, TValue>(key, value, null, null, 1);

			BinarySearchTreeNode<TKey, TValue> result = null;
			if (key.CompareTo(rootNode.Key) > 0)
			{
				result = Add(rootNode.RightNode, key, value);
				rootNode.RightNode = result;
			}
			else
			{
				result = Add(rootNode.LeftNode, key, value);
				rootNode.LeftNode = result;
			}

			result.Size = result.LeftNode.Size + result.RightNode.Size + 1;
			return result;
		}
	}
}
