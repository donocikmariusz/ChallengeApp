
namespace ChallengeApp
{
    public class Person : System.Object
    {
        public Person(string name, string surname, string gender, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Age = age;

        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Gender { get; private set; }
        public int Age { get; private set; }


    }
}
