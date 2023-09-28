using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_class_library_
{
    public class MergeSort : IStrategy
    {
        
        static ulong _comparisonCount = 0;
        static ulong _replacementCount = 0;
        
        public int[] Array { get; set; }
        public int[] Sort(int[] arrayNoSort)
        {
            return MergeSorting(arrayNoSort);
        }
        static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            int left = lowIndex;
            int right = middleIndex + 1;
            int[] tempArray = new int[highIndex - lowIndex + 1];
            int index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                _comparisonCount++;
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    _replacementCount++;
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    _replacementCount++;
                    right++;
                }
                index++;
            }
            
            for (int i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                _replacementCount++;
                index++;
            }

            for (int i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                _replacementCount++;
                index++;
            }

            for (int i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
                _replacementCount++;
            }
        }

        static int[] MergeSorting(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                int middleIndex = (lowIndex + highIndex) / 2;
                MergeSorting(array, lowIndex, middleIndex);
                MergeSorting(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }

        static int[] MergeSorting(int[] array)
        {
            return MergeSorting(array, 0, array.Length - 1);
        }
        public ulong OutComparisonCount ()
        {
            return _comparisonCount;
        }
        public ulong OutReplacementCount()
        {
            return _replacementCount;
        }

    }
}
