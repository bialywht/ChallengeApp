namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
     

        public float BestResult
        {
            get
            { 
                return this.grades.Sum();
            }
        }

        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
            
        }

      
        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            
        }

        public Statistics GetStatistics() 
        {
            var statistics = new Statistics();
            statistics.Max = grades.Max();
            statistics.Min = grades.Min();
            statistics.Avarage = grades.Average();
            return statistics;
        }

        
    }
}
