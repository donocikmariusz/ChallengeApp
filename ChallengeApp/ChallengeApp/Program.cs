using ChallengeApp;

var employee = new Employee("Parch", "Naczelny");

employee.AddGrades(0xa);
employee.AddGrades("1");
employee.AddGrades(10.0/5.0);
employee.AddGrades(1.0);
employee.AddGrades((byte)2);
employee.AddGrades(10.0);


var statistics = employee.GetStatistics();

Console.WriteLine($"Average : {statistics.Average:N5}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

Console.WriteLine("0xa: " + 0xa);


