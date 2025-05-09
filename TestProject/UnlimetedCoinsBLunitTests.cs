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
            var result = _BL.CanMakeChange(v, x);
            Assert.That(result, Is.True);
        }

        [Test]
        public void Test2()
        {
            int v = 5/* your value for v */;
            int[] x = { 4 }; // Initialize your array x with appropriate values
            var result = _BL.CanMakeChange(v, x);
            Assert.That(result, Is.False);
        }

        [Test]
        public void Test3()
        {
            int v = 30/* your value for v */;
            int[] x = { 25, 10, 5 }; // Initialize your array x with appropriate values
            var result = _BL.CanMakeChange(v, x);
            Assert.That(result, Is.True);
        }

        [Test]
        public void Test4()
        {
            int v = 19/* your value for v */;
            int[] x = { 9, 6, 5, 1 }; // Initialize your array x with appropriate values
            var result = _BL.CanMakeChange(v, x);
            Assert.That(result, Is.True);
        }

        [Test]
        public void Test5()
        {
            int v = 0/* your value for v */;
            int[] x = { 1, 5 }; // Initialize your array x with appropriate values
            var result = _BL.CanMakeChange(v, x);
            Assert.That(result, Is.True);
        }

        [Test]
        public void Test6()
        {
            int v = 5/* your value for v */;
            int[] x = { 4, 6, 2 }; // Initialize your array x with appropriate values
            var result = _BL.CanMakeChange(v, x);
            Assert.That(result, Is.False);
        }

    }
}
