using BusinessLogic;

namespace TestProject
{
    internal class DPV6_1MaximumContiguousSubsequenceUnitTest
    {
        private DPV6_1MaxContiguousSubSeqBL _BL;

        [SetUp]
        public void Setup()
        {
            _BL = 
                new DPV6_1MaxContiguousSubSeqBL();
        }

        [Test]
        public void Test1()
        {
            // input: A = [-6, 2, -4, 1, 3, -1, 5, -1]
            // output: S = [1, 3,-1, 5]

            var A = new int[] { -6, 2, -4, 1, 3, -1, 5, -1 };
            var ExpectedS = new int[] { 1, 3, -1, 5};
            var ActualS = 
                _BL.MaxContiguousSubSeq(A);
            Assert.That(ActualS,
                    Is.EqualTo(ExpectedS));
        }

    }
}