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
			var loNode = elementsToSort.First;
			var miNode = GetSentinelNode(loNode);
			var hiNode = GetSentinelNode(miNode);





		}

		private static void Merge<T>(DataStructures.Linear.LinkedListNode<T> loNode, DataStructures.Linear.LinkedListNode<T> midNode) where T : IComparable<T>
		{

		}

		private static DataStructures.Linear.LinkedListNode<T> GetSentinelNode<T>(DataStructures.Linear.LinkedListNode<T> startNode) where T : IComparable<T>
		{
			return null;
		}
	}
}
