﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
	public class BinarySearchTreeNode<TKey, TValue> where TKey : IComparable<TKey> where TValue : IComparable<TValue>
	{
		public TKey Key { private set; get; }
		public TValue Value { set; get; }
		public BinarySearchTreeNode<TKey, TValue> LeftNode { set; get; }
		public BinarySearchTreeNode<TKey, TValue> RightNode { set; get; }
		public int Size { set; get; }

		public BinarySearchTreeNode(TKey key, TValue value, BinarySearchTreeNode<TKey, TValue> leftNode, BinarySearchTreeNode<TKey, TValue> rightNode, int size)
		{
			Key = key;
			Value = value;
			LeftNode = leftNode;
			RightNode = rightNode;
			Size = size;
		}
	}
}
