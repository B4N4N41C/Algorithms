using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_class_library_
{
    public class SelectionSort : IStrategy
    {
        private ulong _comparisonCount = 0;
        private ulong _replacementCount = 0;

        public int[] Array { get; set; }
        public int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int k = i;
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    _comparisonCount++;

                    if (array[j] < array[k])
                    {
                        k = j;

                        _replacementCount++;
                    }

                    _comparisonCount++;

                    if(i != k)
                    {
                        Swap(ref array[j], ref array[k]);

                        _replacementCount++;
                    }
                }
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
