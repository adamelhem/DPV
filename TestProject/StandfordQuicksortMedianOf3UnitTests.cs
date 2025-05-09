using BusinessLogic;

namespace TestProject
{
    public class StandfordQuicksortMedianOf3UnitTests
    {
        private StandfordQuicksortMedianOf3BL _BL;

        [SetUp]
        public void Setup()
        {
            _BL = new StandfordQuicksortMedianOf3BL();
        }

        [Test]
        public void TestSwap()
        {
            var input = new double[] { 2, 8, 21, 36, 41, 56, 14, 17 };
            var pivot = _BL.MedianOf3(input, 0, 0);
            Assert.That(pivot, Is.EqualTo(new int[] { 2, 1 }));
        }

    }
}
