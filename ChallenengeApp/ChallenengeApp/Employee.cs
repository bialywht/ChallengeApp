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
            

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Ocena musi być od 0 - 100");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {                            
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine($"({grade}) nie jest oceną");
            }
        }

        public void AddGrade(long grade)
        {            
                this.AddGrade((float)grade);            
        }

        public void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }

        public void AddGrade(decimal grade)
        {
            this.AddGrade((float)grade);
        }

        public Employee(string firstName)
        {
            this.FirstName = firstName;
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
            statistics.Average = grades.Average();
            return statistics;
        }

       
    }
}
