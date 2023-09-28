namespace Laba1_class_library_
{
    public class CocktailSort : IStrategy
    {
        private ulong _comparisonCount = 0;
        private ulong _replacementCount = 0;
        public int[] Array { get; set; }
        public int[] Sort(int[] array)
        {

            int left = 0;
            int right = array.Length - 1;
            int count = 0;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    _comparisonCount++;
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                        count++;
                        _replacementCount++;
                    }
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    _comparisonCount++;
                    if (array[i] < array[i - 1])
                    {
                        Swap(ref array[i], ref array[i - 1]);
                        count++;
                        _replacementCount++;
                    }
                }
                left++;
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

