using BusinessLogic;
using BusinessLogic;
using NUnit.Framework.Legacy;

namespace TestProjectLCS
{
    public class LCScontinueTests
    {
        private LCScontinueBL _LCS;

        [SetUp]
        public void Setup()
        {
            _LCS = new LCScontinueBL();
        }

        [Test]
        public void Test1()
        {
            var x = new string[] { "a","z","x", "b","y", "c", "t","d" };
            var y = new string[] { "a","o", "b","p", "c", "d" };
            var output = _LCS.LCS(x, y);
            _LCS.PrintL();
            ClassicAssert.AreEqual(4, output);
        }

        [Test]
        public void Test2()
        {
            var x = new string[] { "a", "z", "b" };
            var y = new string[] { "a", "b" };
            var output = _LCS.LCS(x, y);
            _LCS.PrintL();
            ClassicAssert.AreEqual(2, output);
        }

        [Test]
        public void Test3()
        {
            var x = new string[] { "a", "z", "b" };
            var y = new string[] { "a", "b", "p" };
            var output = _LCS.LCS(x, y);
            ClassicAssert.AreEqual(2, output);
        }

    }
}
