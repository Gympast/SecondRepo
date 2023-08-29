
static void ovning1()
{
    Console.Write("Write your name: ");
    string name = Console.ReadLine();

    Console.WriteLine($"Hello {name}!");
}

static void ovning2()
{
    Console.Write("Enter your password: ");
    string passWord = "Hoppsan";

    if (Console.ReadLine() == passWord)
    {
        Console.WriteLine("Rätt");
    }
    else
    {
        Console.WriteLine("FEL FEL FEL FEL FEL");
    }
}
///////////////////////////////////////////////

//övning 3

Console.Write("Write a number:");



while (true)
{
    string nmrTry = Console.ReadLine();
    int nmr = 0;
    bool nmrBool = int.TryParse(nmrTry, out nmr);
    if (nmrBool == true)
    {
        if (nmr == 666)
        {
            Console.WriteLine("The program died...");
            break;
        }
        if (nmr < 100)
        {
            Console.WriteLine("Smaller than 100");
            Console.Write("Write another number: ");
            Console.WriteLine("Or to continue type 666");
        }
        else if (nmr > 100)
        {
            Console.WriteLine("Bigger than 100");
            Console.Write("Write another number: ");
            Console.WriteLine("Or to continue type 666");
        }
        else
        {
            Console.WriteLine("Number is 100");
            Console.Write("Write another number: ");
            Console.WriteLine("Or to continue type 666");
        }
    }
    else
    {
        Console.WriteLine("Write a number... dickhead...");
    }
}

/////////////////////////////////////////////////////////////


//övning 4
Console.Write("Write your name: ");
name = Console.ReadLine();

Console.Write("How many times do you want to repeat it? Default is one");

string nmrTimesString = Console.ReadLine();

int nmrTimes = 1;
bool nmrTimesBool = int.TryParse(nmrTimesString, out nmrTimes);

for (int i = 0; i < nmrTimes; i++)
{
    Console.WriteLine($"Hello {name}!");
}