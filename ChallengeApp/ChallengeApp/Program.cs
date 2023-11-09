string name = "Jaroslaw K";
string gender = "male";
uint age = 65;

if (age == 33 && name == "Ewa" && gender == "female")
{
    Console.WriteLine("Ewa, lat 33");
}
        else if (age < 18 && gender == "male") 
        {
          Console.WriteLine("Niepelnoletni Mezczyzna");
        }
        else if (age < 30 && gender == "female")
        { 
          Console.WriteLine("Kobieta ponizej 30 lat");
        }
else
{
    Console.WriteLine("Danych z wejscia nie pozna podpiac pod pkt 1,2 lub 3.");
}





