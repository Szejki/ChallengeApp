string name = "Łukasz";
bool sex = true; //true - mężczyzna, false - kobieta
int age = 35;


if (sex == true) //mężczyzna
{
    if (age == 0 && name == "Admin")
    {
        Console.WriteLine("Witam Admnistratora !");
    }
    else if (age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }
    else if (age >= 18 && age < 60)
    {
        Console.WriteLine("Mężczyzna " + name + ", lat " + age);
    }
    else if (age >= 60)
    {
        Console.WriteLine("Mężczyzna w podeszłym wieku");
    }
}
else if (sex == false) //kobieta
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletnia Kobieta");
    }
    else if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 Lat");
    }
    else if (age >= 30 && age < 60)
    {
        Console.WriteLine("Kobieta " + name + ", lat " + age);
    }
    else if (age >= 60)
    {
        Console.WriteLine("Kobieta w podeszłym wieku");
    }
}