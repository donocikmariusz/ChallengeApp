using System;

Random generator = new Random();

int numberRandom = generator.Next(1, 100);
int ileprób = 0;

while (true)
{
    Console.WriteLine("Zgadnij Liczbe: ");
    int userNumber = int.Parse(Console.ReadLine());

    if (numberRandom > userNumber)
    {
        Console.WriteLine("Za mała. Try Again");
        ileprób++;
    }

    else if (numberRandom < userNumber)
    {
        Console.WriteLine("Za duża. Try Again");
        ileprób++;
    }
    else
    {
        Console.WriteLine("Dobrze, liczba prób: " + ileprób);
        break;
    }
}



