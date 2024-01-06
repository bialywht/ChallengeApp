namespace ChallengeApp
{
    public abstract class Person
    {

        public Person()
        {
            
        }
        public Person(string firstName)
        {
               this.FirstName = firstName;
        }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person(string firstName, string lastName, string gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Gender { get; private set; }
    }
}
