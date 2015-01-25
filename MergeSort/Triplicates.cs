﻿using System;
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
			var mergedList = firstList.Concat(secondList).Concat(thirdList).ToList(); 
			
			
			var sortedList = Sort(mergedList);
			var result = new List<string>();
			for (int i = 0; i < sortedList.Count - 2; i++)
			{
				var firstWord = sortedList[i];
				var secondWord = sortedList[i + 1];
				var thirdWord = sortedList[i + 2];
				if ((firstWord == secondWord) && (secondWord == thirdWord))
				{
					result.Add(sortedList[i]);
					i += 2;
				}
			}
			return result;
		}

		private List<string> Sort(List<string> listToSort)
		{
			var auxList = listToSort.ToList();
			Sort(listToSort, auxList, 0, listToSort.Count() - 1);
			return listToSort;
		}

		private void Sort(List<string> listToSort, List<string> auxList, int startIndex, int endIndex)
		{
			if (startIndex >= endIndex)
				return;

			int midIndex = startIndex + (endIndex - startIndex) / 2;

			Sort(listToSort, auxList, startIndex, midIndex);
			Sort(listToSort, auxList, midIndex + 1, endIndex);
			Merge(listToSort, auxList, startIndex, midIndex, endIndex);
		}

		private void Merge(List<string> listToSort, List<string> auxList, int startIndex, int midIndex, int endIndex)
		{
			int i = startIndex;
			int j = midIndex + 1;

			for (int k = startIndex; k <= endIndex; k++)
			{
				auxList[k] = listToSort[k];
			}

			for(int k = startIndex; k <= endIndex; k++)
			{
				if (i > midIndex)
				{
					listToSort[k] = auxList[j++];
				}
				else if (j > endIndex)
				{
					listToSort[k] = auxList[i++];
				}
				else if(String.Compare(auxList[i], auxList[j]) <= 0 )
				{
					listToSort[k] = auxList[i++];
				}
				else
				{
					listToSort[k] = auxList[j++];
				}
			}
		}
	}
}