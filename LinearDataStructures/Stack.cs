using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Linear
{
	public class Stack<T>
	{
		private LinkedList<T> _linkedList = new LinkedList<T>();


		public void Push(T data)
		{
			_linkedList.AddFirst(data);
		}

		public T Pop()
		{
			if (_linkedList.IsEmpty)
				throw new ArgumentOutOfRangeException();

			var res = _linkedList.RemoveFirst();
			return res.Value;
		}
	}
}
