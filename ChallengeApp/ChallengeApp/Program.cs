using ChallengeApp;

Console.WriteLine("Witamy w programie xyz do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee("Zbigniew", "Stonoga");
var supervisor = new Supervisor("Jarosław", "Kaczyński");

while (true)
{
    Console.WriteLine("Wybierz pracownika 's' - supervisor, 'e' - pracownik");
    var option = Console.ReadLine();

    if (option == "s" || option == "S")
    {

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
                supervisor.AddGrades1(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catched: {e.Message}");
            }

        }

        var statistics = supervisor.GetStatistics();

        Console.WriteLine($"Statistics for: {supervisor.Name}, {supervisor.Surname}");
        Console.WriteLine($"AVG: {statistics.Average:N3}");
        Console.WriteLine($"MIN: {statistics.Min}");
        Console.WriteLine($"MAX: {statistics.Max}");
        Console.WriteLine();
        Console.WriteLine($"Asses As: {statistics.AverageLetter}");
        break;
    }

    else if (option == "e" || option =="E")
    {

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