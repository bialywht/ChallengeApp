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

        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;            
            foreach(var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }                     
            statistics.Average = statistics.Average/grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;
            int i = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Average += grades[i];
                i++;
            }
            while (i < grades.Count);
            statistics.Average = statistics.Average / grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;
            int i = 0;
            while (i < grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Average += grades[i];
                i++;
            }
            statistics.Average = statistics.Average / grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;
            int i;
            for (i =0; i < grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Average += grades[i];
            }
            statistics.Average = statistics.Average / grades.Count;
            return statistics;
        }
    }
}
