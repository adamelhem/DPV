
namespace BusinessLogic
{
    public class UnlimetedCoinsKnapsackBL
    {
        public bool CanMakeChange(int v, int[] x)
        {
            int[] T = new int[v + 1];

            T[0] = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j <= v; j++)
                {
                    if (x[i] <= j)
                    {
                        T[j] = Math.Max(T[j], T[j - x[i]] + x[i]);
                    }
                }
            }
            return (T[v] == v);
        }
    }
}
 