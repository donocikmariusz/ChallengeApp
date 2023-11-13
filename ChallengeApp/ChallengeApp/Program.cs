using ChallengeApp;

Employee user1 = new Employee("Zbigniew", "Stonoga", "54");
Employee user2 = new Employee("Jarosław", "Kaczynski", "65");
Employee user3 = new Employee("Mateusz", "Morawiacki", "49");

user1.AddScore(5);
user1.AddScore(5);
user1.AddScore(4);
user1.AddScore(3);
user1.AddScore(5);

user2.AddScore(1);
user2.AddScore(2);
user2.AddScore(3);
user2.AddScore(4);
user2.AddScore(5);

user3.AddScore(5);
user3.AddScore(5);
user3.AddScore(3);
user3.AddScore(4);
user3.AddScore(1);

List<Employee> list = new List<Employee>()
{
    user1, user2, user3
};

int maxResult = -1;
Employee userwithMaxValue = null;

foreach (var user in list)
{
    if (user.Result > maxResult)
    {
        userwithMaxValue = user;
        maxResult = user.Result;
    }
}

Console.WriteLine("Najwyzsza ilośc punktów ma : " + userwithMaxValue.Name +
    " " + userwithMaxValue.Surname + " ilość punktów: " + userwithMaxValue.Result);
