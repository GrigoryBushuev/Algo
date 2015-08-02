using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Linear
{
	public class Queue<T> : IEnumerable<T>
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

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var node in _linkedList)
            {
                yield return node;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
