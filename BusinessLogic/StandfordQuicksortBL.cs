

namespace BusinessLogic
{
    public class StandfordQuicksortBL
    {
        private double _CompareCount;

        public double GetCompareCount()
        {
            return _CompareCount;
        }

        public void QuickSort(int[] input, int l, int r)
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
                _CompareCount = _CompareCount + 1;
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
