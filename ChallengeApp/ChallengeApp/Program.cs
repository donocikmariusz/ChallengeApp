using ChallengeApp;

Console.WriteLine("Witamy w programie xyz do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee();

/*
try
{
    Employee emp = null;
    var name = emp.Surname;
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}
finally
{
    Console.WriteLine("Finally here");
}
*/

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    Console.WriteLine("Wciśnij 'Q' lub 'q' aby wyjść");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        employee.AddGrades(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }

}

var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average}");
Console.WriteLine($"MIN: {statistics.Min}");
Console.WriteLine($"MAX: {statistics.Max}");
Console.WriteLine();
Console.WriteLine($"Asses As: {statistics.AverageLetter}");
