namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)

        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; set; }
        public string Surname { get; set; }

        public void Addgrade(double grade)
        {
            throw new NotImplementedException();
        }

        public void Addgrade(decimal grade)
        {
            throw new NotImplementedException();
        }

        public void Addgrade(short grade)
        {
            throw new NotImplementedException();
        }

        public void Addgrade(char grade)
        {
            throw new NotImplementedException();
        }

        public void Addgrade(string grade)
        {
            throw new NotImplementedException();
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

        public void AddGrades1(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.AddGrades(100);
                    break;
                case "5+":
                case "+5":
                    this.AddGrades(85);
                    break;
                case "5":
                    this.AddGrades(80);
                    break;
                case "5-":
                case "-5":
                    this.AddGrades(75);
                    break;
                case "4+":
                case "+4":
                    this.AddGrades(65);
                    break;
                case "4":
                    this.AddGrades(60);
                    break;
                case "4-":
                case "-4":
                    this.AddGrades(55);
                    break;
                case "3+":
                case "+3":
                    this.AddGrades(45);
                    break;
                case "3":
                    this.AddGrades(40);
                    break;
                case "-3":
                case "3-":
                    this.AddGrades(35);
                    break;  
                case "+2":
                case "2+":
                    this.AddGrades(25);
                    break;
                case "2":
                    this.AddGrades(20);
                    break;
                case "2-":
                case "-2":
                    this.AddGrades(15);
                    break;
                case "1+":
                case "+1":
                    this.AddGrades(10);
                    break;
                case "1":
                    this.AddGrades(0);
                    break;
                default:
                    throw new Exception("wrong grade (1-6)");
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
                case var average when average == 100:
                    statistics.AverageLetter = "6";
                    break;
                case var average when average >= 80:
                    statistics.AverageLetter = "5";
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = "4";
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = "3";
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = "2";
                    break;
                default:
                    statistics.AverageLetter = "1";
                    break;
            }
            return statistics;
        }
    }
}