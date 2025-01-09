using System.Diagnostics;

namespace BusinessLogic
{
    public class LCSBL
    {
        private int[,]? _L;
        private string[]? _x;
        private string[]? _y;

        public int LCS(string[] x, string[] y)
        {
            _x = x;
            _y = y;
            // base case
            if (x == null || x.Length == 0)
            {
                return 0;
            }

            if (y == null || y.Length == 0)
            {
                return 0;
            }

            _L = new int[x.Length + 1, y.Length + 1];
            for (var p = 0; p < x.Length; p++)
            {
                for (var q = 0; q < y.Length; q++)
                {
                    var x_i = x[p];
                    var y_j = y[q];

                    var i = p + 1;
                    var j = q + 1;

                    if (x_i.Equals(y_j))
                    {
                        _L[i, j] = 1 + _L[i - 1, j - 1];
                    }
                    else
                    {
                        _L[i, j] = Math.Max(_L[i, j - 1], _L[i - 1, j]);
                    }
                }
            }

            return _L[x.Length, y.Length];
        }

        public void PrintL()
        {
            Debug.Write("0");
            for (var p = 0; p < _y.Length; p++)
            {
                Debug.Write(_y[p]);
            }
            Debug.WriteLine("");
            for (var i = 0; i < _L.GetLength(0); i++)
            {
                for (var j = 0; j < _L.GetLength(1); j++)
                {
                    Debug.Write(_L[i, j]);
                }
                if (i != 0)
                {
                    Debug.WriteLine(_x[i - 1]);
                } else
                {
                    Debug.WriteLine("");
                }

            }
        }

    }
}
