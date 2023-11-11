
Console.WriteLine("Podaj dzień tygodnia: ");


Console.WriteLine(" ");


string[] dayofWeeks = { "", "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };
string number = Console.ReadLine();

int.TryParse(number, out int numberint);

for (int i = 0; i < dayofWeeks.Length; i++)
{
    if (numberint == i)
    {
        Console.WriteLine(dayofWeeks[i]);
    }
}