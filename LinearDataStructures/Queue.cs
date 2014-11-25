using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Linear
{
	public class Queue<T>
	{
		private LinkedList<T> _linkedList = new LinkedList<T>();

		public void Enqueue(T data)
		{
			_linkedList.AddLast(data);
		}

		public T Peek()
		{
			if (_linkedList.IsEmpty)
				throw new ArgumentOutOfRangeException();

			var res = _linkedList.First;
			return res.Value;
		}

		public T Dequeue()
		{
			if (_linkedList.IsEmpty)
				throw new ArgumentOutOfRangeException();

			var res = _linkedList.RemoveFirst();
			return res.Value;
		}

	}
}
