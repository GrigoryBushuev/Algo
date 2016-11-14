using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
	public interface ISortingAlgorithm<T> where T : IComparable<T>
	{
		void Sort(IEnumerable<T> arrayToSort);
	}
}
