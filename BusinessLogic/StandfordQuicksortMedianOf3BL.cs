

namespace BusinessLogic
{
    public class StandfordQuicksortMedianOf3BL
    {
        private double _CompareCount;

        public double GetCompareCount()
        {
            return _CompareCount;
        }

        public void QuickSort(double[] input, int l, int r)
        {
            if ( l >= r )
            {
                return;
            }
            _CompareCount = _CompareCount + r-l+1;
            var p = Partion(input, l, r);
            QuickSort(input, l, p - 1);
            QuickSort(input, p, r);
        }

        public int Partion(double[] input, int l, int r)
        {
            var p = input[l];
            var i = l+1;
            for (var j = l+1 ; j <= r; j++)
            {
                if (input[j] < p)
                {
                    Swap(input, j, i);
                    i++;
                }
            }
            Swap(input, l, i - 1);
            return i;
        }

        public double[] Swap(double[] input, int p1, int p2)
        {
            var temp = input[p1];
            input[p1] = input[p2];
            input[p2] = temp;
            return input;
        }

    }
}
