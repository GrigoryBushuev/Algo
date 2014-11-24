using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Linear
{

	public class LinkedListNode<T>
	{
		public LinkedListNode(T value)
		{
			Value = value;
		}

		public LinkedListNode(LinkedListNode<T> next, T value)
		{
			Next = next;
			Value = value;
		}

		public T Value
		{
			private set; 
			get;
		}

		public LinkedListNode<T> Next
		{
			set; 
			get;
		}
	}


	public class LinkedList<T>
	{

		private LinkedListNode<T> _currentNode;

		public LinkedList(IEnumerable<T> data)
		{
			foreach (var node in data)
			{
				
			}
		}

		public LinkedListNode<T> AddLast(T data)
		{
			var newNode = new LinkedListNode<T>(data);
			if (_currentNode == null)
				_currentNode = newNode;
			else
				_currentNode.Next = newNode;

			return newNode;
		}

    }
}
