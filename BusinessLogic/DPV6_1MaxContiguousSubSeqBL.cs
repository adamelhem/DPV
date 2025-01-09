namespace BusinessLogic
{
    public class DPV6_1MaxContiguousSubSeqBL
    {
        public int[] MaxContiguousSubSeq(int[] a)
        {
            var L = new int[a.Length];
            if (a == null|| a?.Length == 0)
            {
                return [];
            }
            L[0] = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                L[i] = Math.Max(L[i - 1] + a[i], a[i]);
            }
            var maxVal = L.Max();
            var maxValIndex = Array.IndexOf(L, maxVal);
            var output = new List<int>();
            for (var i = maxValIndex; i > 0
                && L[i] > 0; i--)
            {
                output.Add(a[i]);
            }
            output.Reverse();
            return output.ToArray();
        }
    }
}