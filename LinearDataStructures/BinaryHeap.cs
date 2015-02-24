using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
	public class BinaryHeap<T> where T : IComparable<T>
	{
		private T[] _keys;
		private int _numKeys;

		public BinaryHeap()
		{
			_keys = new T[2];
		}

		public BinaryHeap(int size)
		{
			_keys = new T[size];
		}

		private int Resize()
		{
			Array.Resize(ref _keys, _keys.Length * 2);
			return _keys.Length;
		}

		public int Size
		{
			get
			{
				return _numKeys;
			} 
		}


		private int Swim(T key)
		{

		}

		private int Sink(T key)
		{
			return 0;
		}

		private void Insert(T key)
		{
			_numKeys++;
			if (_numKeys >= _keys.Length)
				Resize();
			_keys[_numKeys] = key;
			Swim(key);
		}



	}
}
