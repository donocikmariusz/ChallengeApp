namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades1.txt";


        public EmployeeInFile(string name, string surname)
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
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }
        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MaxValue;
            statistics.Min = float.MinValue;

            foreach (var grade in grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }
            statistics.Average /= grades.Count;
            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = "A";
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = "B";
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = "C";
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = "D";
                    break;
                default:
                    statistics.AverageLetter = "E";
                    break;
            }
            return statistics;
        }

    }
}

