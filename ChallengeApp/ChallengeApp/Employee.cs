﻿using System.Runtime.InteropServices;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee()
        {
        }

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

        public void AddGrades(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;

                default:
                    this.grades.Add(0);
                    break;
            }
            // var grade1 = (float)grade;
            // this.AddGrades(grade1);
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