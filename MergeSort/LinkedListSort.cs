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
			var headNode = Sort(elementsToSort.First);			
		}

		public static DataStructures.Linear.LinkedListNode<T> Sort<T>(DataStructures.Linear.LinkedListNode<T> firstNode) where T : IComparable<T>
		{

			var head = firstNode;
			var aNode = head;
			var iterNum = 0;

			while (aNode != null)
			{
				aNode = head;
				iterNum = 0;
				DataStructures.Linear.LinkedListNode<T> tailNode = null;

				while (aNode != null)
				{
					var sentinelNode = GetSentinelNode(aNode);
					var bNode = sentinelNode.Next;
					if (bNode == null)
					{
						tailNode.Next = sentinelNode;
						break;
					}

					sentinelNode.Next = null;

					sentinelNode = GetSentinelNode(bNode);
					var restNode = sentinelNode.Next;
					sentinelNode.Next = null;

					DataStructures.Linear.LinkedListNode<T> newTailNode = null; 
					var mergedList = Merge(aNode, bNode, ref newTailNode);
					if (iterNum == 0)
					{
						head = mergedList;
						tailNode = newTailNode;
					}
					else
					{
						tailNode.Next = mergedList;
						tailNode = newTailNode;
					}
					aNode = restNode;
					iterNum++;
				}
				if (iterNum == 0)
					break;
			}
			return head;
		}

		private static DataStructures.Linear.LinkedListNode<T> Merge<T>(DataStructures.Linear.LinkedListNode<T> aNode,																		
																		DataStructures.Linear.LinkedListNode<T> bNode,
																		ref DataStructures.Linear.LinkedListNode<T> tailNode) where T : IComparable<T>
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
				else if (aNode == null)
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
			tailNode = curNode;
			return dummyHead.Next;
		}

		private static DataStructures.Linear.LinkedListNode<T> GetSentinelNode<T>(DataStructures.Linear.LinkedListNode<T> firstNode) where T : IComparable<T>
		{
			var curNode = firstNode;

			while (curNode != null && curNode.Next != null && curNode.Value.CompareTo(curNode.Next.Value) <= 0)				
				curNode = curNode.Next;

			return curNode;
		}
	}
}
