
//övning 1

string name = Console.ReadLine();

Console.WriteLine($"Hello {name}!");

///////////////////////////////////////////////

//övning 2
string passWord = "Hoppsan";

if (Console.ReadLine() == passWord)
{
    Console.WriteLine("Rätt");
}
else
{
    Console.WriteLine("FEL FEL FEL FEL FEL");
}
///////////////////////////////////////////////

//övning 3

Console.Write("Write a number:");

string nmrTry = Console.ReadLine();

int nmr = int.TryParse(nmrTry);