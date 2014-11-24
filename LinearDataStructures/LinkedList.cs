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

		public LinkedListNode<T> Prev
		{
			set;
			get;
		}
	}


	public class LinkedList<T>
	{

		private int _count = 0;
		private LinkedListNode<T> _currentNode;

		public LinkedList(IEnumerable<T> data)
		{
			foreach (var node in data)
			{
				AddLast(data);
			}
		}

		public LinkedListNode<T> AddLast(T data)
		{
			_count++;
			var newNode = new LinkedListNode(data);
			if (_currentNode == null)
				_currentNode = newNode;
			else
				_currentNode.Next = newNode;			
			return newNode;
		}


		public int Count 
		{
			get { return _count; }
		}

		public bool IsEmpty
		{
			get 
			{
				return _currentNode == null;
			}
		}

		public LinkedListNode<T> RemoveLast()
		{
			_count--;
			var result = _currentNode;
			if (IsEmpty && _currentNode.Prev != null)
				_currentNode = _currentNode.Prev;
			return result;
		}

    }
}
