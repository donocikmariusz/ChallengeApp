using ChallengeApp;

Console.WriteLine("Witamy w programie xyz do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new EmployeeInFile("Zbigniew", "Stonoga");
var employee1 = new EmployeeInMemory("Jarosław", "Kaczyński");
employee1.GradeAdded += EmployeeGradeAdded;
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

while (true)
{
    Console.WriteLine("Wybierz pracownika 'S' - supervisor, 'E' - pracownik");
    var option = Console.ReadLine();

    if (option == "s" || option == "S")
    {
        Console.WriteLine("Wybrano Supervisior");
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
                employee1.AddGrades(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catched: {e.Message}");
            }
        }

        var statistics = employee1.GetStatistics();

        Console.WriteLine($"Statistics for: {employee1.Name}, {employee1.Surname}");
        Console.WriteLine($"AVG: {statistics.Average:N3}");
        Console.WriteLine($"MIN: {statistics.Min}");
        Console.WriteLine($"MAX: {statistics.Max}");
        Console.WriteLine();
        Console.WriteLine($"Asses As: {statistics.AverageLetter}");
        break;
    }

    else if (option == "e" || option == "E")
    {
        Console.WriteLine("Wybrano Employee");

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

        Console.WriteLine($"Statistics for: {employee.Name}, {employee.Surname}");
        Console.WriteLine($"AVG: {statistics.Average:N3}");
        Console.WriteLine($"MIN: {statistics.Min}");
        Console.WriteLine($"MAX: {statistics.Max}");
        Console.WriteLine();
        Console.WriteLine($"Asses As: {statistics.AverageLetter}");
        break;
    }
    else
    {
        Console.WriteLine("Niewłaściwy wybór. Try Again.");
    }

}

