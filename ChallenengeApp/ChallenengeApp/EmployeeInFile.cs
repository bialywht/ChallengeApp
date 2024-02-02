namespace ChallengeApp

{
    internal class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile()
        {
        }

        public EmployeeInFile(string firstName) : base(firstName)
        {
        }

        public EmployeeInFile(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public EmployeeInFile(string firstName, string lastName, string gender) : base(firstName, lastName, gender)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Ocena musi być od 0 - 100");
            }
            using (var writer = File.AppendText(fileName)) 
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(100);
                    }
                    break;
                case 'B':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(80);
                    }
                    break;
                case 'C':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(60);
                    }
                    break;
                case 'D':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(40);
                    }
                    break;
                case 'E':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(20);
                    }
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
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(100);
                    }
                    break;
                case "B":
                case "b":
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(80);
                    }
                    break;
                case "C":
                case "c":
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(60);
                    }
                    break;
                case "D":
                case "d":
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(40);
                    }
                    break;
                case "E":
                case "e":
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(20);
                    }
                    break;
                default:
                    throw new Exception("Wybierz A-E");
            }
        }
        

        public override void AddGrade(long grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine((float)grade);
            }
        }

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine((float)grade);
            }
        }

        public override void AddGrade(decimal grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine((float)grade);
            }
        }

        

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists(fileName))
            {
                using(var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while(line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }

            return grades;
            
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            
            return result;
        }

        private Statistics CountStatistics(List<float> gradesFromFile)
        {
            var statistics = new Statistics();
            statistics.Max = gradesFromFile.Max();
            statistics.Min = gradesFromFile.Min();
            statistics.Average = gradesFromFile.Average();

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
