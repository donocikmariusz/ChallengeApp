
Console.WriteLine("Podaj number: ");
string number = Console.ReadLine();
Console.WriteLine(" ");
int.TryParse(number, out int numberint);


for (int i = numberint; i >= 0; i--)
{
    Console.WriteLine(i);
}
