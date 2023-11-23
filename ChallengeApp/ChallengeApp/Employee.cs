namespace ChallengeApp
{
    public class Employee : Person
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname, string gender, int age)
            : base(name, surname, gender, age)
        {

        }

        public void AddGrades(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }

            else
            {
                throw new Exception("invalid grade value");
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
                throw new Exception("wrong letter");

            }
        }

        public void AddGrades(byte grade)
        {
            var grade1 = (float)grade;
            this.AddGrades(grade1);
        }

        public void AddGrades(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrades(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrades(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrades(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrades(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrades(20);
                    break;
                default:
                    throw new Exception("wrong letter");
            }
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