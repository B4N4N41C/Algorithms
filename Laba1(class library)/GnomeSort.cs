using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_class_library_
{
    public class GnomeSort : IStrategy

    {
        private ulong _comparisonCount = 0;
        private ulong _replacementCount = 0;

        public int[] Array { get; set; }
        public int[] Sort(int[] array)
        {
            int i = 1;
            while (i < array.Length)
            {
                _comparisonCount++; 
                if (i > 0 && array[i] < array[i - 1])
                {
                    Swap(ref array[i], ref array[i - 1]);
                    _replacementCount++;
                    i--;
                }
                else
                    i++;
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
