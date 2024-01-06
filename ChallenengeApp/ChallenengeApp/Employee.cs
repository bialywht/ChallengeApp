namespace ChallengeApp
{
    public class Employee : Person
    {
        public Employee() { }
        public Employee(string firstName) : base(firstName) { }
        public Employee(string firstName, string lastName) : base(firstName, lastName) { }
        public Employee(string firstName, string lastName, string gender) : base(firstName, lastName, gender) {}
            

        private List<float> grades = new List<float>();

        public void AddGrade(float grade)
        {            
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Ocena musi być od 0 - 100");               
            }
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                    this.AddGrade(80);
                    break;
                case 'C':
                    this.AddGrade(60);
                    break;
                case 'D':
                    this.AddGrade(40);
                    break;
                case 'E':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wybierz A-E");
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
                throw new Exception($"({grade}) nie jest oceną");                
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

        public Statistics GetStatistics() 
        {
            var statistics = new Statistics();
            statistics.Max = grades.Max();
            statistics.Min = grades.Min();
            statistics.Average = grades.Average();

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }

       
    }
}
