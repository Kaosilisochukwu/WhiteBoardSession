// See https://aka.ms/new-console-template for more information
using WhiteBoardSession;

Console.WriteLine("Hello, World!");


var prog = new Class1();

var result = prog.GetChipCount(123456789);
Console.WriteLine("===================================");
foreach (var item in result)
{
    Console.WriteLine($"{item.Key} => {item.Value}");
}
Console.WriteLine($"Total => {result.Values.Sum()}");
Console.WriteLine("==================================");

var word1 = "Hello World";
var word2 = "HelLo";
var word3 = "Hello";
Console.WriteLine("1 => " + prog.IsUnique(word1));
Console.WriteLine("2 => " + prog.IsUnique(word2));
Console.WriteLine("3 => " + prog.IsUnique(word3));
