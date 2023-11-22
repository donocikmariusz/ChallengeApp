using ChallengeApp;

var employee = new Employee("Parch", "Naczelny");

employee.AddGrades("Zbigniew S");
employee.AddGrades(9f);
employee.AddGrades(1.11);
employee.AddGrades("4000");
employee.AddGrades(10.0/5.0);
employee.AddGrades(6);

var statistics = employee.GetStatistics();

Console.WriteLine("Wyniki dla GetStatistics");
Console.WriteLine($"Base Average : {statistics.Average:N5}");
Console.WriteLine($"Base Min: {statistics.Min}");
Console.WriteLine($"Base Max: {statistics.Max}");

var statistics1 = employee.GetStatisticsWithForEach();

Console.WriteLine("Wyniki dla GetStatisticsWithForEach");
Console.WriteLine($"For Each Average : {statistics1.Average:N5}");
Console.WriteLine($"For Each Min: {statistics1.Min}");
Console.WriteLine($"For Each Max: {statistics1.Max}");

var statistics2 = employee.GetStatisticsWithFor();

Console.WriteLine("Wyniki dla GetStatisticsWithFor");
Console.WriteLine($"For Average : {statistics2.Average:N5}");
Console.WriteLine($"For Min: {statistics2.Min}");
Console.WriteLine($"For Max: {statistics2.Max}");

var statistics3 = employee.GetStatisticsWithDoWhile();

Console.WriteLine("Wyniki dla GetStatisticsWithDoWhile");
Console.WriteLine($"DoWhile Average : {statistics3.Average:N5}");
Console.WriteLine($"DoWhile Average Min: {statistics3.Min}");
Console.WriteLine($"DoWhile Average Max: {statistics3.Max}");

var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine("Wyniki dla GetStatisticsWithWhile");
Console.WriteLine($"While Average : {statistics4.Average:N5}");
Console.WriteLine($"While Average Min: {statistics4.Min}");
Console.WriteLine($"While Average Max: {statistics4.Max}");