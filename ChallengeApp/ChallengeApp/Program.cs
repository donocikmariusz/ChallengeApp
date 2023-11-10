long number = 9900;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

string letters2 = "jaroslaw kaczynski";


int[] counters = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'w', 'u', 'x', 'y', 'z' };

foreach (char letter in letters2)
{
    for (int a = 0; a < alphabet.Length; a++)
    {
        if (letter == alphabet[a]) { counters[a]++; }
       
    }
}

for (int i = 0; i < counters.Length; i++)
{
    Console.WriteLine(alphabet[i] + " => " + counters[i]);
}