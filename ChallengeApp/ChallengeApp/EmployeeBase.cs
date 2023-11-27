namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public abstract void Addgrade(double grade);
        public abstract void Addgrade(char grade);
        public abstract void Addgrade(string grade);
        public abstract void Addgrade(int grade);
        public abstract void Addgrade(float grade);
        public abstract Statistics GetStatistics();

    }
}
