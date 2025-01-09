
using System.Diagnostics;

namespace BusinessLogic
{
    public class UtilsBL
    {
        public void PrintL(int[] L)
        {
            var iLen = L.GetLength(0);
            var jLen = L.GetLength(1);
            for (var i = 0; i < iLen; i++)
            {
                Debug.Write(L[i]);
            }
        }

        public void PrintL(int[,] L)
        {
            var iLen = L.GetLength(0);
            var jLen = L.GetLength(1);
            for (var i = 0; i < iLen; i++)
            {
                Debug.WriteLine("");
                for (var j = 0; j < jLen; j++)
                {
                    Debug.Write(L[i, j]);
                }
            }
        }

        internal void Print(string input)
            => Debug.Write(input);
        
    }
}
