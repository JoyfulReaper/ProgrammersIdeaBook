Console.WriteLine("This application converts from decimal to binary and back again for the Programmers Idea Book Project.");
Console.Write("Enter Decimal Number: ");
var input = Console.ReadLine();

if(!int.TryParse(input, out var number))
{
    Console.WriteLine("Unable to convert to int!");
    Environment.Exit(1);
}

var bin = DecToBin(number);
var dec = BinToDec(bin);

Console.WriteLine();
Console.WriteLine("Result:");
Console.WriteLine(bin);
Console.WriteLine(dec);

static string DecToBin(int number)
{
    string result = string.Empty;
    while (number > 0)
    {
        result = number % 2 + result;
        number /= 2;
    }

    return result;
}

static int BinToDec(string number)
{
    if(!int.TryParse(number, out _))
    {
        throw new ArgumentException(nameof(number) + " could not be converted to an integer!");
    }

    int result = 0;
    int place = 0;
    for(int i = number.Length -1; i >= 0; i--)
    {
        var curr = int.Parse(number[i].ToString());
        if (curr == 1)
        {
            result = result + (int)Math.Pow(2, place);
        }
        place++;
    }

    return result;
}