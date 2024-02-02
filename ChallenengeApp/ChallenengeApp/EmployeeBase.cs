
namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {

        public EmployeeBase()
        {
            
        }

        public EmployeeBase(string firstName)
        {
            this.FirstName = firstName;
        }

        public EmployeeBase(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public EmployeeBase(string firstName, string lastName, string gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Gender { get; private set; }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(char grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(long grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(decimal grade);

        public abstract Statistics GetStatistics();
    }
}
