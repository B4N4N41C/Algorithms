using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_class_library_
{
    public class InsertionSort : IStrategy
    {
        private ulong _comparisonCount = 0;
        private ulong _replacementCount = 0;
        public int[] Array { get; set; }
        public int[] Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i;

                while (j > 1 && array[j - 1] > key)
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                    _comparisonCount++;
                    _replacementCount++;
                }
                array[j] = key;
            }
            return array;
        }
        static void Swap(ref int value1, ref int value2)
        {
            int swap = value1;
            value1 = value2;
            value2 = swap;
        }
        public ulong OutComparisonCount()
        {
            return _comparisonCount;
        }
        public ulong OutReplacementCount()
        {
            return _replacementCount;
        }
    }
}
