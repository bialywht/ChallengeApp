namespace ChallengeApp
{
    public interface IEmployee
    {        
        string FirstName { get; }
        string LastName { get; }
        string Gender { get; }
        Statistics GetStatistics();
        void AddGrade(float grade);
        void AddGrade(char grade);
        void AddGrade(string grade);
        void AddGrade(long grade);
        void AddGrade(double grade);
        void AddGrade(decimal grade);

    }
}
