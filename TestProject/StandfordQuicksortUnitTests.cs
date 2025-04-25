using BusinessLogic;
namespace TestProject
{
    public class StandfordQuicksortUnitTests
    {
        private StandfordQuicksortBL _BL;

        [SetUp]
        public void Setup()
        {
            _BL = new StandfordQuicksortBL();
        }

        [Test]
        public void TestSwap()
        {
            var input = new int[] { 1, 2 };
            var sorted = _BL.Swap(input, 0, 1);
            Assert.That(sorted, Is.EqualTo(new int[] { 2, 1 }));
        }

        [Test]
        public void TestPartion()
        {
            var input = new int[] { 7, 6, 10, 5, 9, 2, 1, 15, 7 };
            var sorted = _BL.Partion(input, 0, input.Length - 1);
            Assert.That(sorted, Is.EqualTo(new int[]{ 2, 6, 1, 5, 7, 7, 10, 9, 15}));
        }

        [Test]
        public void TestQuickSort()
        {
            var input = new int[] { 7, 6, 10, 5, 9, 2, 1, 15, 7 };
            var sorted = _BL.QuickSort(input);
            Assert.That(sorted, Is.EqualTo(new int[] { 1, 2, 5, 6, 7, 7, 9, 10, 15 }));
        }

        [Test]
        public void TestSwapCount()
        {
            var input = new int[] { 5, 4, 3, 2, 1 };
            //var outputCount = _BL.InversionCount(input);
            var sorted = _BL.QuickSort(input);
            var outputCount = _BL.GetSwapCount();
            Assert.That(outputCount, Is.EqualTo(10));
        }

    }
}
