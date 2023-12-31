﻿namespace ChallengeApp
{
    public class Employee : IEmployee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Gender { get; private set; }
        public Employee()
        {
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
        public Employee(string firstName, string lastName, string gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
        }
            

        public List<float> grades = new List<float>();

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
        public void AddGrade(string grade)
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
