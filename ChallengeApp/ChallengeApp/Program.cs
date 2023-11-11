
Console.WriteLine("1. C TO F ");
Console.WriteLine("2. F TO C ");
Console.WriteLine("Twój wybór :");

string number = Console.ReadLine();
Console.WriteLine(" ");
int.TryParse(number, out int numberint);

if (numberint == 1)
{
    Console.WriteLine("Podaj wartość w stopniach C: ");
    string wartoscC = Console.ReadLine();
    Console.WriteLine(" ");
    float.TryParse(wartoscC, out float wartoscCfloat);

   
    double wynikCtoF = (wartoscCfloat * (9.0/5.0) + 32);
    Console.WriteLine(wartoscCfloat + " stopni C to " + wynikCtoF + " stopni F ");
}

else if (numberint == 2)
{
    Console.WriteLine("Podaj wartość w stopniach F: ");
    string wartoscF = Console.ReadLine();
    Console.WriteLine(" ");
    float.TryParse(wartoscF, out float wartoscFfloat);

    
    double wynikFtoC = (5.0/9.0) * (wartoscFfloat - 32);
    Console.WriteLine(wartoscFfloat + " stopni F to " + wynikFtoC + " stopni C ");
}

else
{
    Console.WriteLine("Niewlasciwy Wybor. Try again");
}


