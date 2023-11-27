﻿namespace ChallengeApp
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

        public void AddGrades(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }

            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public void AddGrades(byte grade)
        {
            var gradeAsFloat = (float)grade;
            this.AddGrades(gradeAsFloat);
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

        public void AddGrades(string grade)
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
                    throw new Exception("Wrong grade (1-6)");
            }
        }

        public void AddGrades(short grade)
        {
            var gradeAsFloat = (float)grade;
            this.AddGrades(gradeAsFloat);
        }

        public void AddGrades(decimal grade)
        {
            var gradeAsFloat = (float)grade;
            this.AddGrades(gradeAsFloat);
        }

        public void AddGrades(double grade)
        {
            var gradeAsFloat = (float)grade;
            this.AddGrades(gradeAsFloat);
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