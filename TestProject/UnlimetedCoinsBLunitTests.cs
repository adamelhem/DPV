using BusinessLogic;

namespace TestProject
{
    public class UnlimetedCoinsBLunitTests
    {
        private UnlimetedCoinsKnapsackBL _BL;

        [SetUp]
        public void Setup()
        {
            _BL = new UnlimetedCoinsKnapsackBL();
        }

        [Test]
        public void Test1()
        {

            /*
             * Input: sum = 10, coins[] = [2, 5, 3, 6]
             * Output: 5
             * Explanation: 
             * There are five solutions: 
             * [2, 2, 2, 2, 2], 
             * [2, 2, 3, 3], 
             * [2, 2, 6], 
             * [2, 3, 5],
             * [5, 5]                                          
             */

            int v = 10/* your value for v */;
            int[] x = { 2, 5, 3, 6 }; // Initialize your array x with appropriate values
            var result = _BL.CanMakeChange( v, x);
            Assert.That(result, Is.True);
        }

    }
}
