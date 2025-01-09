using BusinessLogic;
/* 
Example:
Let X = {ABCDFEGHT}
     and 
Y = {GHTABCDFEHGT}
Then the longest common subsequence is Z = {ABCDFE}
*/
namespace TestProject
{
    public class DPV6_11LCS_ContinuesUnitTest
    {
        private DPV6_11LCS_ContinuesBL _DPV6_11LCS_ContinuesBL;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LCScontinueTe5st()
        {
            _DPV6_11LCS_ContinuesBL = new DPV6_11LCS_ContinuesBL();
            var inputX = "ABCDFEGHT";
            var inputY = "GHTABCDFEHGT";
            var expected = "ABCDFE";
            var expectedLen = 6;
            var actualLenLCS = _DPV6_11LCS_ContinuesBL.LCS(inputX, inputY);
            Assert.That(actualLenLCS, Is.EqualTo(expectedLen));
        }

    }
}