using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_class_library_
{
    public class ShellSort : IStrategy
    {
        private ulong _comparisonCount = 0;
        private ulong _replacementCount = 0;
        public int[] Array { get; set; }
        public int[] Sort(int[] array)
        {
            int step = array.Length / 2;
            while(step >= 1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int j = i;
                    while((j >= step) && (array[j - step] > array[j]))
                    {
                        _comparisonCount++;
                        _replacementCount++;

                        Swap(ref array[j], ref array[j - step]);
                        j = j - step;
                    }
                }

                _comparisonCount++;
                step = step / 2;
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
