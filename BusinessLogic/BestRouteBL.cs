using System.Diagnostics;

namespace BusinessLogic
{
    public class BestRouteBL
    {
        int[]? _L;
        public int MinimumPenalty(int[] a)
        {
            var a_ = new List<int>(a);
            a_.Insert(0, 0);
            _L = new int[a_.Count];
            for (var i = 1; i < a_.Count; i++)
            {
                _L[i] = int.MaxValue; 
                for (var j = 0; j < i; j++)
                {
                    // we check all steps from stops before i stop to i stop and update the best
                    // cost result to reach stop i, we keep do that up to i equal to last target
                    // stop final destination
                    // (we calculate best way to reach eqch stop i and build new result
                    // calculation based on it)

                    var penalityTotal = _L[j] + (200 - (a_[i] - a_[j])) * (200 - (a_[i] - a_[j]));
                    if (penalityTotal < _L[i])
                    {
                        _L[i] = penalityTotal;
                    }
                }
            }
            return _L[a_.Count - 1];
        }

        public (int, List<int>) ExampleHotelStopsMinPenalty(List<int> a)
        {
            // Let's define a0 = starting position = 0
            List<int> a_ = new List<int>(a);
            a_.Insert(0, 0);
            int[] P = new int[a_.Count];
            int[] s = new int[a_.Count];

            for (int i = 1; i < a_.Count; i++)
            {
                P[i] = int.MaxValue; // initialize to infinity
                for (int j = 0; j < i; j++)
                {
                    // Keep track of the previous stop that minimizes penalty at mile post i
                    int p = P[j] + (200 - (a_[i] - a_[j])) * (200 - (a_[i] - a_[j]));
                    if (p < P[i])
                    {
                        s[i] = j;
                        P[i] = p;
                    }
                }
            }

            List<int> stops = new List<int>();
            int k = a_.Count - 1;
            while (k > 0)
            {
                stops.Add(k);
                k = s[k];
            }

            stops.Reverse();
            return (P[a_.Count - 1], stops);
        }

        public void PrintL()
        {
            Debug.WriteLine("");
            for (var i = 0; i < _L.GetLength(0); i++)
            {
                    Debug.Write(_L[i] + " , ");
            }
            Debug.WriteLine("");
        }

    }
}