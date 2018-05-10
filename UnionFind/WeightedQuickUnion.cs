﻿namespace UnionFind
{
	public class WeightedQuickUnion
	{
		private int[] _components;
		private int[] _sizes;

		public WeightedQuickUnion(int num)
		{ 
			_components = new int[num];
			_sizes = new int[num];

			for (var i = 0; i < num; i++)
			{
				_components[i] = i;
				_sizes[i] = 1;
			}
		}

		/// <summary>
		/// Returns the root index of the searching component
		/// </summary>
		/// <param name="p"></param>
		/// <returns></returns>
		public int Find(int p)
		{
			while (_components[p] != p)
				p = _components[p];

			return p;
		}

		public bool IsConnected(int p, int q)
		{
			return Find(p) == Find(q);
		}

		public int[] Components => _components;

	    public void Union(int p, int q)
		{
			var pRoot = Find(p);
			var qRoot = Find(q);

			//Check whether components are already connected
			if (pRoot == qRoot) return;

			if (_sizes[pRoot] >= _sizes[qRoot])
			{
				_components[qRoot] = pRoot;
				_sizes[pRoot] += _sizes[qRoot];
			}
			else
			{ 
				_components[pRoot] = qRoot;
				_sizes[qRoot] += _sizes[pRoot];
			}
		}
	}
}
