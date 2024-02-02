namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public EmployeeInMemory()
        {
        }

        public EmployeeInMemory(string firstName) : base(firstName)
        {
        }

        public EmployeeInMemory(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public EmployeeInMemory(string firstName, string lastName, string gender) : base(firstName, lastName, gender)
        {
        }

        public List<float> grades = new List<float>();

        public override void AddGrade(float grade)
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

        public override void AddGrade(char grade)
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

        public override void AddGrade(string grade)
        {
            switch (grade)
            {
                case "A":
                case "a":
                    this.AddGrade(100);
                    break;
                case "B":
                case "b":
                    this.AddGrade(80);
                    break;
                case "C":
                case "c":
                    this.AddGrade(60);
                    break;
                case "D":
                case "d":
                    this.AddGrade(40);
                    break;
                case "E":
                case "e":
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wybierz A-E");
            }
        }

        public override void AddGrade(long grade)
        {
            this.AddGrade((float)grade);
        }

        public override void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }

        public override void AddGrade(decimal grade)
        {
            this.AddGrade((float)grade);
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
