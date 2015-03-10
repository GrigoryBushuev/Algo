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

		public int Size
		{
			get { return GetSize(root); }
		}

		private int GetSize(BinarySearchTreeNode<TKey, TValue> node)
		{
			return node == null ? 0 : node.Size;
		}

		private BinarySearchTreeNode<TKey, TValue> GetNodeByKey(BinarySearchTreeNode<TKey, TValue> rootNode, TKey key)
		{
			BinarySearchTreeNode<TKey, TValue> result = null;

			var cmpResult = key.CompareTo(rootNode.Key);

			if (cmpResult > 0)
				result = GetNodeByKey(rootNode.RightNode, key);
			else if (cmpResult < 0)
				result = GetNodeByKey(rootNode.LeftNode, key);
			else
			{
				result = rootNode;
			}
			return result;
		}

		public void Add(TKey key, TValue value)
		{
			root = Add(root, key, value);
		}

		private BinarySearchTreeNode<TKey, TValue> Add(BinarySearchTreeNode<TKey, TValue> rootNode, TKey key, TValue value)
		{
			if (rootNode == null)
				return new BinarySearchTreeNode<TKey, TValue>(key, value, null, null, 1);

			var cmpResult = key.CompareTo(rootNode.Key);

			BinarySearchTreeNode<TKey, TValue> result = null;
			if (cmpResult > 0)
			{
				result = Add(rootNode.RightNode, key, value);
				rootNode.RightNode = result;
			}
			else if (cmpResult < 0)
			{
				result = Add(rootNode.LeftNode, key, value);
				rootNode.LeftNode = result;
			}
			else
			{
				rootNode.Value = value;
			}

			rootNode.Size = GetSize(rootNode.LeftNode) + GetSize(rootNode.RightNode) + 1;
			return rootNode;
		}

		public BinarySearchTreeNode<TKey, TValue> Min()
		{
			return Min(root);
		}

		public BinarySearchTreeNode<TKey, TValue> Min(BinarySearchTreeNode<TKey, TValue> node)
		{
			if (node.LeftNode == null) return node;
			return Min(node.LeftNode);
		}

		public void DeleteMin()
		{
			root = DeleteMin(root);
		}

		public BinarySearchTreeNode<TKey, TValue> DeleteMin(BinarySearchTreeNode<TKey, TValue> node)
		{
			if (node.LeftNode == null) return node.RightNode;
			node.LeftNode = DeleteMin(node.LeftNode);
			node.Size = GetSize(node.LeftNode) + GetSize(node.RightNode) + 1;
			return node;
		}

		public void Delete(TKey key)
		{
			root = Delete(root, key);
		}

		public BinarySearchTreeNode<TKey, TValue> Delete(BinarySearchTreeNode<TKey, TValue> node, TKey key)
		{
			BinarySearchTreeNode<TKey, TValue> result = null;
			var cmpResult = node.Key.CompareTo(key);
			if (cmpResult > 0)			
				node.RightNode = Delete(node.RightNode, key);
			else if (cmpResult < 0)
				node.LeftNode = Delete(node.LeftNode, key);
			else
			{
				var tempNode = node;
				result = Min(tempNode.RightNode);
				result.LeftNode = tempNode.LeftNode;
				result.RightNode = DeleteMin(tempNode.RightNode);
				result.Size = GetSize(result.LeftNode) + GetSize(result.RightNode) + 1;
			}
			return result;
		}
	}
}
