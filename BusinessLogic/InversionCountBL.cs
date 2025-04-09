/* 
 * references: https://onecompiler.com/c/43dx9gqg3
 * Given array is:
 * 12 11 13 5 6 7 
 * Sorted array is:
 * 5 6 7 11 12 13
 */

namespace BusinessLogic
{
    public class InversionCountBL
    {
        public InversionCountBL()
        {
        }

        public int InversionCount(int[] arr)
        {
            return MergeSort(arr, 0, arr.Length);
        }

        public int MergeSort(int[] arr, int l, int r)
        {
            // (2-0)/2 = 1
            int m = (r - l) / 2 + l;
            // m = 1, l = 0, r = 2
            if (m < r)
            {
                MergeSort(arr, l, m);
                MergeSort(arr, m + 1, r);
                Merge(arr, l, m, r);
            }
            return 0;
        }

        public int Merge(int[] arr, int l, int m, int r)
        {
            // m = 1, l = 0, r = 2
            int n1 = m - l + 1; //2
            int n2 = r - m; //1
            var L = new int[n1];
            var R = new int[n2];

            int i;
            int j;

            for (i = 0; i < n1; i++)
            {
                L[i] = arr[l + i];
            }

            for (j = 0; j < n2; j++)
            {
                R[j] = arr[m + 1 + j];
            }

            i = 0;
            j = 0;
            var k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
            return 0;
        }

    }
}