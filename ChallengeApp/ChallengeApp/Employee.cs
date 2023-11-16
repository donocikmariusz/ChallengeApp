using System.Runtime.InteropServices;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrades(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }

            else
            {
                Console.WriteLine("invalid grade value");
            }
        }



        public void AddGrades(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrades(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        public void AddGrades(byte grade)
        {
            var grade1 = (float)grade;
            this.AddGrades(grade1);
        }

        public void AddGrades(ushort grade)
        {
            var grade1 = (float)grade;
            this.AddGrades(grade1);
        }

        public void AddGrades(short grade)
        {
            var grade1 = (float)grade;
            this.AddGrades(grade1);
        }

        public void AddGrades(decimal grade)
        {
            var grade1 = (float)grade;
            this.AddGrades(grade1);
        }

        public void AddGrades(double grade)
        {
            var grade1 = (float)grade;
            this.AddGrades(grade1);
        }



        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}

