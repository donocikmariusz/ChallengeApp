﻿namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;
        private const string fileName = "grades2.txt";
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }
        public override void AddGrades(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Invalid Grade Value");
            }
        }
        public override void AddGrades(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrades(result);
            }
            else
            {
                throw new Exception("Wrong letter");
            }
        }
        public override void AddGrades(char grade)
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
                    throw new Exception("Wrong letter");
            }
        }
        public override void AddGrades(short grade)
        {
            var gradeAsFloat = (float)grade;
            this.AddGrades(gradeAsFloat);
        }
        public override void AddGrades(decimal grade)
        {
            var gradeAsFloat = (float)grade;
            this.AddGrades(gradeAsFloat);
        }
        public override void AddGrades(double grade)
        {
            var gradeAsFloat = (float)grade;
            this.AddGrades(gradeAsFloat);
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
                using (var reader = File.OpenText(fileName))
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

            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }

    }
}

