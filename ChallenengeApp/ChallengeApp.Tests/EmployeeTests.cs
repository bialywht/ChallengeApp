


namespace ChallengeApp.Tests
{
    public class Tests
    {
       

        [Test]
        public void CheckingStatisticsMinValue()
        {
            Employee employee = new Employee();
            employee.AddGrade(56);
            employee.AddGrade(100);
            employee.AddGrade(22);
            employee.AddGrade(41);
            var statistics = employee.GetStatistics();


            Assert.AreEqual(22, statistics.Min);
        }

        [Test]
        public void CheckingStatisticsMaxValue()
        {
            Employee employee = new Employee();
            employee.AddGrade(56);
            employee.AddGrade(100);
            employee.AddGrade(22);
            employee.AddGrade(41);
            var statistics = employee.GetStatistics();


            Assert.AreEqual(100, statistics.Max);
        }

        [Test]
        public void CheckingStatisticsAverage()
        {
            Employee employee = new Employee();
            employee.AddGrade(56);
            employee.AddGrade(100);
            employee.AddGrade(22);
            employee.AddGrade(41);
            var statistics = employee.GetStatistics();


            Assert.AreEqual(Math.Round(54.75, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void CheckingStatisticsAverageLetter()
        {
            Employee employee = new Employee();
            employee.AddGrade(56);
            employee.AddGrade(100);
            employee.AddGrade(22);
            employee.AddGrade(41);
            var statistics = employee.GetStatistics();


            Assert.AreEqual('C', statistics.AverageLetter);
        }
    }
}