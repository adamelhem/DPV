using BusinessLogic;
namespace TestProject
{
    public class KnapsackUnitTest
    {
        private knapsackBL _BL;
        [SetUp]
        public void Setup()
        {
            _BL = new knapsackBL();
        }
        [Test]
        public void MaxItemsSumUnitTest()
        {
            var Input = new List<KnapsackItem> { 
                new KnapsackItem(1, 15, 15),
                new KnapsackItem(2, 10, 12),
                new KnapsackItem(3, 8, 10),
                new KnapsackItem(4, 1, 5)
            };
            var B = 22;
            var ExpectedResult = 18;
            var ActualResult = _BL.MaxItemsSum(Input, B);
            Assert.That(ActualResult, Is.EqualTo(ExpectedResult));
        }
    }
}