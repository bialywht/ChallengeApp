namespace ChallengeApp.Tests
{
    public class TypeTests
    {

        [Test]
        public void ComperingIntType()
        {            
            int number1 = 5;
            int number2 = 6;
         
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void ComperingStringType()
        {
            string name1 = "Zygfryd";
            string name2 = "Zygfryd";

            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void ComperingReferenceTypes()
        {            
            var emloyee1 = GetEmployee("Emil");
            var emloyee2 = GetEmployee("Emil");
         
            Assert.AreNotEqual(emloyee1, emloyee2);
        }

        private Employee GetEmployee(string firstName) 
        {
            return new Employee(firstName);
        }
    }
}
