using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
	public class Triplicates
	{

		public List<string> GetTriplicates(List<string> firstList, List<string> secondList, List<string> thirdList)
		{
			var mergedList = firstList.Union(secondList).Union(thirdList).ToList();
			var sortedList = Sort(mergedList);
			var result = new List<string>();
			for (int i = 0; i < sortedList.Count - 4; i++)
			{
				if (sortedList[i] == sortedList[i + 1] == sortedList[i + 2])
					result.Add(sortedList[i]);
			}
			return result;
		}

		private List<string> Sort(IList<string> listToSort)
		{
			return null;
		}

		private void Sort(List<string> listToSort, int startIndex, int endIndex)
		{
			
		}

		private void Merge()
		{

		}

	}
}
