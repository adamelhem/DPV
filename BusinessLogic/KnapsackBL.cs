namespace BusinessLogic
{
    public class KnapsackItem
    {
        private int _id;
        private int _weight;
        private int _value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="weight"></param>
        /// <param name="value"></param>
        public KnapsackItem(int id, int value, int weight)
        {
            _id = id;
            _weight = weight;
            _value = value;
        }
        public int Id { get => _id; set => _id = value; }
        public int Weight { get => _weight; set => _weight = value; }
        public int Value { get => _value; set => _value = value; }
    }
        public class knapsackBL
        {
            public int MaxItemsSum(List<KnapsackItem> input, int B)
        {
            var n = input.Count;
            var _L = new int[n + 1, B + 1];
            for (var i = 1; i <= n; i++)
            {
                for (var b = 1; b <= B; b++)
                {
                    // this condition is enough because
                    // we may decide to take this item only
                    // if the item weight fit in as is and
                    // provide max value over weight
                    if (input[i-1].Weight <= b)
                    {
                        _L[i, b] = 
                            Math.Max(
                                input[i - 1].Value 
                                + _L[i - 1, b - input[i-1].Weight]
                                , _L[i - 1, b]);
                    } else
                    {
                        _L[i, b] = _L[i-1, b];
                    }
                }
            }
            return _L[n, B];
        }
    }
}