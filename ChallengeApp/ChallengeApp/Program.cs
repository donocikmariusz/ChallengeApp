long number = 1223445667;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

int[] counters = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

foreach (char letter in letters)
{
    for (int a = 0; a < numbers.Length; a++)
    {
        if (letter == numbers[a]) { counters[a]++; }

    }
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(numbers[i] + " => " + counters[i]);
}