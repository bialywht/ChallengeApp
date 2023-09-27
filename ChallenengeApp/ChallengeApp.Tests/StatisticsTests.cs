namespace ChallengeApp.Tests
{
    public class StatisticsTests
    {
        [Test]
        public void ComperingIntType()
        {
            int number1 = 5;
            int number2 = 6;

            Assert.AreNotEqual(number1, number2);
        }
    }
}
