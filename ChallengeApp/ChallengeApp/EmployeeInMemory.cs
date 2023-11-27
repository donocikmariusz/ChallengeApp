namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        {

        }

        public override void Addgrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override void Addgrade(char grade)
        {
            throw new NotImplementedException();
        }

        public override void Addgrade(string grade)
        {
            throw new NotImplementedException();
        }

        public override void Addgrade(int grade)
        {
            throw new NotImplementedException();
        }

        public override void Addgrade(float grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
