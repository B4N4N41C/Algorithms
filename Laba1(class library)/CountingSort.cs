using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_class_library_
{
    public class CountingSort : IStrategy
    {
        private ulong _comparisonCount = 0;
        private ulong _replacementCount = 0;
        public int[] Array { get; set; }
        public int[] Sort(int[] array)
        {
            int min = array[0];
            int max = array[0];

            foreach (int element in array)
            {
                _comparisonCount++;
                if (element < min)
                {
                    min = element;
                    _replacementCount++;
                }
                else if(element > max)
                {
                    max = element;
                    _replacementCount++;
                }
            }

            int correctionFactor = min != 0 ? -min : 0;
            max += correctionFactor;

            int[] count = new int[max + 1];
            for (int i = 0; i < array.Length; i++)
            {
                count[array[i] + correctionFactor]++;
            }

            int index = 0;
            for (int i = 0; i < count.Length; i++)
            {
                for (int j = 0; j < count[i]; j++)
                {
                    array[index] = i - correctionFactor;
                    index++;
                    _replacementCount++;
                }
            }
            return array;
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
