using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Linear
{

	public class LinkedList<T>
	{
		private LinkedListNode<T> _firstNode;
		private LinkedListNode<T> _lastNode;
		private int _count;

		public LinkedList()
		{

		}

		public LinkedList(IEnumerable<T> data)
		{
			foreach (var node in data)
			{
				AddFirst(node);
			}
		}

		public LinkedListNode<T> First
		{
			get { return _firstNode; }
		}

		public LinkedListNode<T> Last
		{
			get { return _lastNode; }
		}

		public int Count
		{
			get { return _count; }
		}

		public bool IsEmpty
		{
			get { return _count == 0; }
		}

		public LinkedListNode<T> AddFirst(T data)
		{
			var newNode = new LinkedListNode<T>(data);
			if (_firstNode == null)
				_firstNode = _lastNode = newNode;
			else
			{
				newNode.Next = _firstNode;
				_firstNode = newNode;
			}
			_count++;
			return newNode;
		}

		public LinkedListNode<T> AddLast(T data)
		{
			var newNode = new LinkedListNode<T>(data);
			if (_lastNode == null)
				_firstNode = _lastNode = newNode;
			else
			{
				_lastNode.Next = newNode;
				_lastNode = newNode;
			}
			_count++;	
			return newNode;
		}


		public LinkedListNode<T> RemoveFirst()
		{
			if (IsEmpty)
				throw new ArgumentOutOfRangeException();

			var result = _firstNode;
			_firstNode = _firstNode.Next;
			_count--;
			return result;
		}	

    }
}
