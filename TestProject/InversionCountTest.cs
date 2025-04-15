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
            var input = new int[] { 5, 4, 3, 2, 1 };
            //var outputCount = _BL.InversionCount(input);
            var sorted = _BL.MergeSort(input);
            var outputCount = _BL.GetInversionCount();
            Assert.That(outputCount, Is.EqualTo(10));
        }

        [Test]
        public void TestInversionCount2()
        {
            var input = new int[] { 1, 2, 3, 4, 5 };
            //var outputCount = _BL.InversionCount(input);
            var sorted = _BL.MergeSort(input);
            var outputCount = _BL.GetInversionCount();
            Assert.That(outputCount, Is.EqualTo(0));
        }

        [Test]
        public void TestInversionCount3()
        {
            var input = new int[] { 1, 5, 2, 8, 3, 4 };
            //var outputCount = _BL.InversionCount(input);
            var sorted = _BL.MergeSort(input);
            var outputCount = _BL.GetInversionCount();
            Assert.That(outputCount, Is.EqualTo(5));
        }

    }
}