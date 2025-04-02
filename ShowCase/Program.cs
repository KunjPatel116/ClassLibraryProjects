// In ShowCase/Program.cs
using static UtilityLibraries.StringLibrary;
using UtilityLibraries;

Console.WriteLine("String Library Demo");
Console.WriteLine("------------------");

TestString("Hello World");
TestString("hello world");
TestString(null);
TestString("");

void TestString(string input)
{
    bool isUpper = input.StartsWithUpper();
    Console.WriteLine($"\"{input}\" starts with uppercase? {(isUpper ? "YES" : "NO")}");
}