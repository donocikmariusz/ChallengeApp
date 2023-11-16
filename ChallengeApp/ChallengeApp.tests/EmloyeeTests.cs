
namespace ChallengeApp.tests
{
    public class EmployeeTests
    {
        [Test]
        public void MinTest()
        {
            var employee = new Employee("Parch", "Naczelny");
            employee.AddGrades(2);
            employee.AddGrades(2);
            employee.AddGrades(6);

            var statistics = employee.GetStatistics();
            Assert.AreEqual(2, statistics.Min);

        }

        [Test]
        public void MaxTest()
        {
            var employee1 = new Employee("Jarosław", "Kaczyński");
            employee1.AddGrades(4);
            employee1.AddGrades(2);
            employee1.AddGrades(6);

            var statistics = employee1.GetStatistics();
            Assert.AreEqual(6, statistics.Max);
        }

        [Test]
        public void AverageTest()
        {
            var employee2 = new Employee("Zbigniew", "Stonoga");
            employee2.AddGrades(4);
            employee2.AddGrades(2);
            employee2.AddGrades(4);

            var statistics = employee2.GetStatistics();

            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));
        }
    }
}
