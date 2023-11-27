
namespace ChallengeApp.tests
{
    public class EmployeeTests
    {
        [Test]
        public void MinTest()
        {
            var employee = new EmployeeInMemory("Parch", "Naczelny");
            employee.AddGrades(2);
            employee.AddGrades(2);
            employee.AddGrades(6);

            var statistics = employee.GetStatistics();
            Assert.AreEqual(2, statistics.Min);
        }

        [Test]

        public void ALetterTest()
        {
            var employee1 = new EmployeeInMemory("Jarosław", "Kaczyński");
            float grade1 = 81;
            float grade2 = 81;
            float grade3 = 81;

            employee1.AddGrades(grade1);
            employee1.AddGrades(grade2);
            employee1.AddGrades(grade3);
            var statistics = employee1.GetStatistics();

            Assert.That(statistics.AverageLetter, Is.EqualTo("A"));
        }

        [Test]

        public void BLetterTest()
        {
            var employee1 = new EmployeeInMemory("Jarosław", "Kaczyński");
            float grade1 = 61;
            float grade2 = 61;
            float grade3 = 61;

            employee1.AddGrades(grade1);
            employee1.AddGrades(grade2);
            employee1.AddGrades(grade3);
            var statistics = employee1.GetStatistics();

            Assert.That(statistics.AverageLetter, Is.EqualTo("B"));
        }

        [Test]

        public void CLetterTest()
        {
            var employee1 = new EmployeeInMemory("Jarosław", "Kaczyński");
            float grade1 = 41;
            float grade2 = 41;
            float grade3 = 41;


            employee1.AddGrades(grade1);
            employee1.AddGrades(grade2);
            employee1.AddGrades(grade3);
            var statistics = employee1.GetStatistics();

            Assert.That(statistics.AverageLetter, Is.EqualTo("C"));
        }

        [Test]
        public void MaxTest()
        {
            var employee1 = new EmployeeInMemory("Jarosław", "Kaczyński");
            employee1.AddGrades(4);
            employee1.AddGrades(2);
            employee1.AddGrades(6);

            var statistics = employee1.GetStatistics();
            Assert.AreEqual(6, statistics.Max);
        }

        [Test]
        public void AverageTest()
        {
            var employee2 = new EmployeeInMemory("Zbigniew", "Stonoga");
            employee2.AddGrades(4);
            employee2.AddGrades(2);
            employee2.AddGrades(4);

            var statistics = employee2.GetStatistics();

            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));
        }
    }
}
