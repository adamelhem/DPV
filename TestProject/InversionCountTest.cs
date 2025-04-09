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
        public void TestInversionCount()
        {
            var input = new int[] { 1, 20, 6, 7, 5, 8, 11, 3 };
            var expectedOutput = 1234;
            var outputCount = _BL.InversionCount(input);
            Assert.That(outputCount, Is.EqualTo(expectedOutput));
        }

    }
}
