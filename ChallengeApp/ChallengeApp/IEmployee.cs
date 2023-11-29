using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        void AddGrades(float grade);
        void AddGrades(string grade);
        void AddGrades(char grade);
        void AddGrades(short grade);
        void AddGrades(decimal grade);
        void AddGrades(double grade);

        event GradeAddedDelegate GradeAdded;
        Statistics GetStatistics();
    }
}
