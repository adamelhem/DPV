using BusinessLogic;
namespace TestProject
{
/* DPV6.17:*
Input: { 2, 3, 5, 10, 20, 30, 50 };
Target: 78
Answer: { 3, 5, 20, 50 };

Input: { 2, 3, 5, 6 };
Target: 9
Answer: { 3, 6 };
Greedy: { 5, 2, 2 };

    /*
        Input: sum = 4, coins[] = [1, 2, 3]
        Output: 4
        Explanation: There are four solutions: [1, 1, 1, 1], [1, 1, 2], [2, 2] and[1, 3]

        Input: sum = 10, coins[] = [2, 5, 3, 6]
        Output: 5
        Explanation: There are five solutions: 
        [2, 2, 2, 2, 2], [2, 2, 3, 3], [2, 2, 6], [2, 3, 5] and[5, 5]

        Input: sum = 10, coins[] = [10]
        Output: 1
        Explanation: The only is CancellationToken pick 1 coin of value 10.

        Input: sum = 5, coins[] = [4]
        Output: 0
        Explanation:  We cannot make sum 5 with the given coins
        */
public class DPV6_17MakingChange1UnitTest
    {
        private DPV6_17MakingChange1BL _BL;
        [SetUp]
        public void Setup()
        {
            _BL = new DPV6_17MakingChange1BL();
        }

        [Test]
        public void Test1()
        {
            var coins =
                new int[] { 1, 2, 3 };
            var sum = 4;
            var expectedOutput = 2;
            var actualOutput =
                _BL.MinCoinChange(coins,
                sum);
            Assert.That(actualOutput,
                Is.EqualTo(expectedOutput));
        }

        /*
        [Test]
        public void Test1()
        {
            var InputCoinsSupply =
                new int[] { 2, 3, 5, 10, 20, 30, 50 };
            var InputTarget = 78;
            var ExpectedSequence =
                new int[] { 3, 5, 20, 50 };
            var ActualSequence =
                _BL.MinCoinChange(InputCoinsSupply,
                InputTarget);
            Assert.That(ActualSequence,
                Is.EqualTo(ExpectedSequence));
        }
        [Test]
        public void Test2()
        {
            var InputCoinsSupply =
                new int[] { 2, 3, 5, 6 };
            var InputTarget = 9;
            var ExpectedSequence = new int[] { 3, 6 };
            var ActualSequence =
                _BL.MinCoinChange(InputCoinsSupply,
                InputTarget);
            Assert.That(ActualSequence,
                Is.EqualTo(ExpectedSequence));
        }
        */
    }
}