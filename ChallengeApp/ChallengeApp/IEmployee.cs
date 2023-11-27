namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        void Addgrade(double grade);
        void Addgrade(char grade);
        void Addgrade(string grade);
        void Addgrade(int grade);
        void Addgrade(float grade);

        Statistics GetStatistics();
    }
}
