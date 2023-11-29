namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;
        private List<float> grades = new List<float>();

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }
        public override void AddGrades(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
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
            var gradeAsFloat = (float)grade;
            this.AddGrades(gradeAsFloat);
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
            var statistics = new Statistics();

           foreach(var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            
            return statistics;
        }
    }
}
