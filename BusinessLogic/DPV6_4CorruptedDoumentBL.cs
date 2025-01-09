
namespace BusinessLogic
{
    public class DPV6_4CorruptedDoumentBL
    {
        private readonly string[] _Dict = {
            "you",
            "are",
            "area",
            "a",
            "bold",
            "one"
        };

        private int[,] _L;

        public string CanBeReconstituted(string input)
        {
            _L = new int[input.Length, input.Length] ;
            for (var i = 0; i < _L.GetLength(0); i++)
            {
                for (var j = 0; j <= i; j++)
                {
                    if (isValidWord(j, i, input))
                    {
                        _L[i, j] = 1;
                    }
                }
            }
            new UtilsBL().Print(input);
            new UtilsBL().PrintL(_L);

            var output = "";
            for (var i = 0; i < _L.GetLength(0); i++)
            {
                for (var j = 0; j <= i; j++)
                {
                    if (_L[i, j] == 1)
                    {
                        var word = new string(input.Take(i+1).Skip(j).ToArray());
                        output += word + " ";
                    }
                }
            }

            return output;
        }

        private bool isValidWord(int j, int i, string input)
        {
            var word = new string(input.Take(i+1).Skip(j).ToArray());
            var isValid = _Dict.Contains(word);
            return isValid;
        }

    }
}
