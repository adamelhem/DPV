using BusinessLogic;

namespace TestProject
{
    public class BestRouteUnitTest
    {
        private BestRouteBL _BestRoute;

        [SetUp]
        public void Setup()
        {
            _BestRoute = new BestRouteBL();
        }

        [Test]
        public void Test1()
        {
            var InputStops = new int[]{ 190, 420, 550, 660, 670};
            var ExpectedSequence = new int[] { 1, 2, 5 };
            var ExpectedMinimumPenalty = 3500;
            var ActualMinimumPenalty = _BestRoute.MinimumPenalty(InputStops);
            var ActualMinimumPenaltyExample = _BestRoute.ExampleHotelStopsMinPenalty(InputStops.ToList());
            _BestRoute.PrintL();
            Assert.That(ActualMinimumPenalty, Is.EqualTo(ExpectedMinimumPenalty));
        }

        [Test]
        public void Test2()
        {
            var InputStops = new int[] { 10, 200, 270, 430, 500 };
            var ExpectedSequence = new int[] { 3, 5 };
            var ExpectedMinimumPenalty = 5800;
            var ActualMinimumPenalty = _BestRoute.MinimumPenalty(InputStops);
            _BestRoute.PrintL();
            Assert.That(ActualMinimumPenalty, Is.EqualTo(ExpectedMinimumPenalty));
        }

    }
}
