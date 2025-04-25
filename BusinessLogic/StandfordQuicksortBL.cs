

namespace BusinessLogic
{
    public class StandfordQuicksortBL
    {
        public int GetSwapCount()
        {
            return 0;
        }

        public void QuickSort(int[] input, int l = 0, int r = 0)
        {
            if (l<r)
            {
                var p = Partion(input, l, r);
                QuickSort(input, l, p - 1);
                QuickSort(input, p + 1, r);
            }
        }

        public int Partion(int[] input, int l = 0, int r = 0)
        {
            var p = input[l];
            var j = r;
            for (var i = r; i > l; i--)
            {
                if (input[i] > p)
                {
                    Swap(input, j, i);
                    j--;
                }
            }
            Swap(input, l, j);
            return j;
        }

        public int[] Swap(int[] input, int p1, int p2)
        {
            var temp = input[p1];
            input[p1] = input[p2];
            input[p2] = temp;
            return input;
        }

    }
}
