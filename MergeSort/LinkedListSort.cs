using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms;
using DataStructures.Linear;

namespace MergeSort
{
	public static class LinkedListSort
	{
		public static void Sort<T>(this DataStructures.Linear.LinkedList<T> elementsToSort) where T : IComparable<T>
		{
			var startNode = elementsToSort.First;

			var sentinelNode = GetSentinelNode(startNode);

			var bNode = sentinelNode.Next;

			sentinelNode.Next = null;
			sentinelNode = GetSentinelNode(bNode);


			sentinelNode.Next = null;

			var mergedList = Merge(startNode, bNode);

		}
		
		private static DataStructures.Linear.LinkedListNode<T> Merge<T>(DataStructures.Linear.LinkedListNode<T> aNode, DataStructures.Linear.LinkedListNode<T> bNode) where T : IComparable<T>
		{
			var dummyHead = new DataStructures.Linear.LinkedListNode<T>();
			var curNode = dummyHead;

			while (aNode != null || bNode != null)
			{
				if (bNode == null)
				{
					curNode.Next = aNode;
					aNode = aNode.Next;
				}
				else if(aNode == null)
				{
					curNode.Next = bNode;
					bNode = bNode.Next;
				}
				else if (aNode.Value.CompareTo(bNode.Value) <= 0)
				{
					curNode.Next = aNode;
					aNode = aNode.Next;
				}
				else
				{
					curNode.Next = bNode;
					bNode = bNode.Next;					
				}
				curNode = curNode.Next;
			}
			return dummyHead.Next;
		}

		private static DataStructures.Linear.LinkedListNode<T> GetSentinelNode<T>(DataStructures.Linear.LinkedListNode<T> firstNode) where T : IComparable<T>
		{
			var curNode = firstNode;

			while (curNode != null && curNode.Next != null && curNode.Value.CompareTo(curNode.Next.Value) < 0)				
				curNode = curNode.Next;

			return curNode;
		}
	}
}
