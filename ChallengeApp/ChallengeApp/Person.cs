namespace ChallengeApp
{
    public abstract class Person : System.Object
    {
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
    }
}
