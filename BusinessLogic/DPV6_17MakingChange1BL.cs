namespace BusinessLogic
{
    public class DPV6_17MakingChange1BL
    {
        public int MinCoinChange(int[] coins, int sum)
        {
            var n = coins.Length;
            if(n == 0 || sum == 0)
            {
                return 1;
            }
            var _L = new int[sum + 1];
            Array.Fill(_L, int.MaxValue);
            _L[0] = 0;
            for (int i = 1; i < sum + 1; i++)
            {
                foreach (int coin in coins)
                {
                    if (i - coin >= 0)
                    {
                        _L[i] = 
                            Math.Min(_L[i],
                                _L[i - coin] + 1);
                    }
                }
            }
            return _L[sum];
        }
    }
}