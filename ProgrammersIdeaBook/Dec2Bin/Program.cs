using Dec2Bin;

Console.WriteLine("This application converts from decimal to binary and back again for the Programmers Idea Book Project.");
Console.Write("Enter Decimal Number: ");
var input = Console.ReadLine();

if(!int.TryParse(input, out var number))
{
    Console.WriteLine("Unable to convert to int!");
    Environment.Exit(1);
}

var bin = NumberConverter.DecToBin(number);
var dec = NumberConverter.BinToDec(bin);

Console.WriteLine();
Console.WriteLine("Result:");
Console.WriteLine(bin);
Console.WriteLine(dec);