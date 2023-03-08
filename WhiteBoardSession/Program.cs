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

var result1 = prog.GetChipCountString(123456789);
Console.WriteLine("===================================");
foreach (var item in result1)
{
    Console.WriteLine(item);
}
Console.WriteLine(string.Join(",", result1));
//Console.WriteLine($"Total => {result1.Values.Sum()}");
Console.WriteLine("==================================");

var word1 = "Hello World";
var word2 = "HelLo";
var word3 = "Hello";
Console.WriteLine("1 => " + prog.IsUnique(word1));
Console.WriteLine("2 => " + prog.IsUnique(word2));
Console.WriteLine("3 => " + prog.IsUnique(word3));

Console.WriteLine("=====================================================================================");
Console.WriteLine("=====================================================================================");
Console.WriteLine(prog.capitalize_words(""));
Console.WriteLine(prog.capitalize_words("a"));
Console.WriteLine(prog.capitalize_words("aa"));
Console.WriteLine(prog.capitalize_words("aaa"));
Console.WriteLine(prog.capitalize_words("a a"));
Console.WriteLine(prog.capitalize_words("aa a aaa"));
Console.WriteLine(prog.capitalize_words(" 12D 8a A xy"));
Console.WriteLine(prog.capitalize_words("ab.c"));
Console.WriteLine(prog.capitalize_words("ab. cC"));
Console.WriteLine(prog.capitalize_words("ab\ncd"));
Console.WriteLine(prog.capitalize_words("ab\tcd"));
Console.WriteLine("=====================================================================================");
Console.WriteLine("=====================================================================================");Console.WriteLine(prog.capitalize_words(""));
Console.WriteLine(prog.CyclicString("cabca"));
//Console.WriteLine(prog.CyclicString("aba"));
//Console.WriteLine(prog.CyclicString("abaca"));
//Console.WriteLine(prog.CyclicString("abcdefghi"));
//Console.WriteLine(prog.CyclicString("ccccccccccc"));
//Console.WriteLine(prog.CyclicString("a"));
//Console.WriteLine(prog.CyclicString("a"));
//Console.WriteLine(prog.CyclicString("a"));
Console.WriteLine("=====================================================================================");
Console.WriteLine("=====================================================================================");

