using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_class_library_
{
    public class CombSort : IStrategy
    {
        private ulong _comparisonCount = 0;
        private ulong _replacementCount = 0;

        public int[] Array { get; set; }

        public int[] Sort(int[] array)
        {
            int currentStep = array.Length - 1;

            while (currentStep > 1)
            {
                for(int i = 0; i + currentStep< array.Length; i++)
                {
                    _comparisonCount++; 

                    if (array[i] > array[i + currentStep])
                    {
                        Swap(ref array[i], ref array[i + currentStep]);
                        _replacementCount++;
                    }
                }

                currentStep = GetNextStep(currentStep);
            }

            for (int i = 1; i < array.Length; i++)
            {
                bool swapFlag = false;

                for (int j = 0; j < array.Length - i; j++)
                {
                    _comparisonCount++;

                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapFlag= true;
                    }

                    _comparisonCount++;

                    if (!swapFlag)
                    {
                        break;
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
        static int GetNextStep(int s)
        {
            s = s * 1000 / 1247;
            return s > 1 ? s : 1;
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
