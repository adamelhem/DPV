using BusinessLogic;

namespace TestProject
{
    public class DPV6_4CorruptedDoumentUnitTests
    {
        private DPV6_4CorruptedDoumentBL _DPV6_4CorruptedDoumentBL;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanBeReconstitutedTest()
        {
                _DPV6_4CorruptedDoumentBL = new DPV6_4CorruptedDoumentBL();
                var expected = "you a are area a bold one ";
                var input = "youareaboldone";
                var actual = _DPV6_4CorruptedDoumentBL.CanBeReconstituted(input);
                Assert.That(actual, Is.EqualTo(expected));
        }

    }
}

/*
youareaboldone
00100000000000
00000000000000
00000000000000
00010110000000
00000000000000
00000000000000
00000010000000
00000000001000
00000000000000
00000000000000
00000000000000
00000000000001
00000000000000
00000000000000
 */