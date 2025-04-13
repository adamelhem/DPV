using BusinessLogic;

namespace TestProjectLCS
{
    public class InversionCountTest
    {
        private InversionCountBL _BL;

        [SetUp]
        public void Setup()
        {
            _BL = new InversionCountBL();
        }

        [Test]
        public void TestMergeSort()
        {
            var input = new int[] { 12, 11, 13, 5, 6, 7 };
            var sorted = _BL.MergeSort(input);
            Assert.That(sorted, Is.EqualTo(new int[] { 5, 6, 7, 11, 12, 13 }));
        }

        [Test]
        public void TestInversionCount()
        {
            var input = new int[] { 12, 11, 13, 5, 6, 7 };
            var outputCount = _BL.InversionCount(input);
            Assert.That(outputCount, Is.EqualTo(10));
        }

    }
}