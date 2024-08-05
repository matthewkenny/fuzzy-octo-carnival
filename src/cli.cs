using System;
namespace App;

public static class Program
{
    public static void Main(string[] args)
    {
        var rand = new Random();
        var x = rand.Next(1, 10);
        var y = rand.Next(1, 10);
        Console.WriteLine($"The sum of {x} and {y} is {Add(x, y)}");
    }

    public static int Add(int x, int y) => x + y;
}