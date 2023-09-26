


namespace ChallengeApp.Tests
{
    public class Tests
    {
       

        [Test]
        public void CheckingCollectingOfEmployeeGrades()
        {
            //arrange

            var employee = new Employee("Zygfryd", "Potocki", "103");
            employee.AddGrade(5);
            employee.AddGrade(8);
            employee.AddGrade(-2);
            employee.AddGrade(4);
            employee.AddGrade(-1);
            employee.AddGrade(6);

            //act
            var result = employee.BestResult;



           //assert
           Assert.AreEqual(20, result);



        }
    }
}