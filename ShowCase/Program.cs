// Program.cs in your Console App
using static UtilityLibraries.StringLibrary;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        bool startsWithUpper = input.StartsWithUpper();
        Console.WriteLine($"Starts with uppercase: {startsWithUpper}");
    }
}