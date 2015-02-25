﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

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

		public T DeleteMax()
		{
			if (_numKeys == 0)
				throw new IndexOutOfRangeException();

			var result = _keys[1];
			_keys.Swap(1, _numKeys);
			Sink(1);
			_keys[_numKeys] = default(T);
			_numKeys--;

			return result;
		}

		public T Max 
		{
			get 
			{
				if (_numKeys == 0)
					throw new IndexOutOfRangeException();

				return _keys[1];
			}
		}

		private void Swim(int k)
		{									
			while(k > 1 && _keys[k/2].CompareTo(_keys[k]) < 0)
			{				
				_keys.Swap(k, k/2);
				k = k/2;
			}
		}

		private void Sink(int k)
		{
			int childIndex = k * 2;
			while (k < _numKeys && _keys[k].CompareTo(_keys[childIndex]) < 0)
			{				
				if (childIndex + 1 < _numKeys && _keys[childIndex].CompareTo(_keys[childIndex + 1]) < 0)
					childIndex++;

				_keys.Swap(k, childIndex);
				k = k * 2;
			}
		}

		public void Insert(T key)
		{
			_numKeys++;
			if (_numKeys >= _keys.Length)
				Resize();
			_keys[_numKeys] = key;
			Swim(_numKeys);
		}



	}
}
