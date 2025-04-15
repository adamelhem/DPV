/* 
 * references: 
 * https://gist.github.com/pmgeorg/9122984
 * Given array is:
 * 12 11 13 5 6 7 
 * Sorted array is:
 * 5 6 7 11 12 13
 */

using System.Collections.Generic;
using System.Text.Json.Serialization.Metadata;

namespace BusinessLogic
{
    public class InversionCountBL
    {
        public int[] _arr;
        public int _inversionCount;
        public InversionCountBL()
        {
        }

        public int InversionCount(int[] arr)
            => 0;
        public int[] GetArray()
                            => _arr;
        public int GetInversionCount()
                            => _inversionCount;

        public  int[] MergeSort(int[] input, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                MergeSort(input, low, middle);
                MergeSort(input, middle + 1, high);
                Merge(input, low, middle, high);
            }
            return input;
        }

        public  int[] MergeSort(int[] input)
        {
            _inversionCount = 0;
            return MergeSort(input, 0, input.Length - 1); ;
        }

        private  void Merge(int[] input, int low, int middle, int high)
        {

            int left = low;
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left] < input[right])
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                }
                else
                {
                    _inversionCount = _inversionCount + (middle - left + 1) ;
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i] = tmp[i];
            }

        }

    }
}