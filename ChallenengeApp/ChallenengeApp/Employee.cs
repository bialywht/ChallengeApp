namespace ChallengeApp
{
    public class Employee
    {
        private List<int> grades = new List<int>();

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Age { get; private set; }

        public int BestResult
        {
            get
            { 
                return this.grades.Sum();
            }
        }

        public void AddGrade(int grade)
        {
            grades.Add(grade);
            
        }

        public Employee(string firstName, string lastName, string age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        
    }
}
