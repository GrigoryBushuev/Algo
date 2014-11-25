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

<<<<<<< HEAD
		public LinkedList(IEnumerable<T> data)
		{
			foreach (var node in data)
			{
				AddFirst(node);
			}
		}

		public int Count
=======
		public T Value
>>>>>>> origin/master
		{
			get { return _count; }
		}

		public bool IsEmpty
		{
			get { return _count == 0; }
		}
<<<<<<< HEAD

=======

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
>>>>>>> origin/master

		public LinkedListNode<T> AddFirst(T data)
		{
			var newNode = new LinkedListNode<T>(data);
			if (_firstNode == null)
				_firstNode = _lastNode = newNode;
			else
			{
<<<<<<< HEAD
				newNode.Next = _firstNode;
				_firstNode = newNode;
=======
				AddLast(data);
>>>>>>> origin/master
			}
			_count++;
			return newNode;
		}

		public LinkedListNode<T> AddLast(T data)
		{
<<<<<<< HEAD
			var newNode = new LinkedListNode<T>(data);
			if (_lastNode == null)
				_firstNode = _lastNode = newNode;
			else
			{
				_lastNode.Next = newNode;
				_lastNode = newNode;
			}
			_count++;
=======
			_count++;
			var newNode = new LinkedListNode(data);
			if (_currentNode == null)
				_currentNode = newNode;
			else
				_currentNode.Next = newNode;			
>>>>>>> origin/master
			return newNode;
		}


<<<<<<< HEAD
		public LinkedListNode<T> RemoveFirst()
		{
			if (IsEmpty)
				throw new ArgumentOutOfRangeException();

			var result = _firstNode;
			_firstNode = _firstNode.Next;
			return result;
		}
	}
=======
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
>>>>>>> origin/master
}
