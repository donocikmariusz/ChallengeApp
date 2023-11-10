int[] grades = new int[365];
string[] dayofWeeks = new string[7];
dayofWeeks[0] = "poniedziałek";
dayofWeeks[1] = "wtorek";
dayofWeeks[2] = "środa";
dayofWeeks[3] = "czwartek";
dayofWeeks[4] = "piątek";
dayofWeeks[5] = "sobota";
dayofWeeks[6] = "niedziela";

int ilerazy = 10;

for (int x = 1; x < ilerazy; x++)
{
    for (int i = 1; i < 10; i++)
    {
        Console.WriteLine(i);
    }

    for (int j = 10; j > 1; j--)
    {
        Console.WriteLine(j);
    }

}