using System.Reflection.Metadata;

namespace ChallengeApp.tests
{
    public class Tests
    {
        [Test]
        public void ComparisonOfThreeIntType_SumShouldBeOK()
        {
            var liczba1 = 0;
            var liczba2 = 2;
            var liczba3 = 3;

            Assert.AreEqual(5, liczba3 + liczba2 + liczba1);
        }

        [Test]

        public void ComparisonOfThreeStringType_ShouldNotBeTheSame()
        {
            string name1 = "Zbigniew";
            string name2 = "Jaros³aw";
            string name3 = "Mateusz";

            Assert.AreNotSame(name3, name2, name1);
        }

        [Test]

        public void ComparisonOfTwoReferenceType_ShouldNotBeEqual() 
        
        {
            var employee1 = new Employee("Zbigniew", "Stonoga", "45");
            var employee2 = new Employee("Jaros³aw", "Kaczyñski", "65");
            
            Assert.AreNotEqual(employee1, employee2);

        }
    }
}