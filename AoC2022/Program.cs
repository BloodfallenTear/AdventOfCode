using System;

namespace AoC2022;

internal sealed class Program
{
    private static void Main()
    {
        var day = new Day01.Day01();

        Console.WriteLine(day.PartOne());
        Console.WriteLine(day.PartTwo());
    }
}
