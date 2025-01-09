namespace BusinessLogic
{
    public class DPV6_11LCS_ContinuesBL
    {
        private int[,] _L;
        public int LCS(string inputX, string inputY)
        {
            var inputXLen = inputX.Length;
            var inputYLen = inputY.Length;
            if (inputXLen == 0 || inputYLen == 0)
            {
                return 0;
            }            
            _L = new int[inputXLen + 1, inputYLen + 1];
            for (int i = 1; i < inputXLen; i++)
            {
                for (int j = 1; j < inputYLen; j++)
                {
                    if (inputX[i-1].Equals(inputY[j-1]))
                    {
                        _L[i, j] = _L[i - 1, j - 1] + 1;
                    }
                }
            }
            //for (int i = 0, li = 1; i < inputXLen; i++, li++)
            //{
            //    for (int j = 0,lj = 1; j < inputYLen; j++, lj++)
            //    {
            //        if (inputX[i].Equals(inputY[j]))
            //        {
            //            _L[li, lj] = _L[li - 1, lj - 1] + 1;
            //        }
            //    }
            //}
            new UtilsBL().PrintL(_L);
            return MaxValue(_L);
        }
        private int MaxValue(int[,] l)
        {
            var max = 0;
            for (var i = 0; i < l.GetLength(0); i++)
            {
                for (var j = 0; j < l.GetLength(1); j++)
                {
                    if (l[i, j]>max)
                    {
                        max = l[i, j];
                    }
                }
            }
            return max;
        }
    }
}