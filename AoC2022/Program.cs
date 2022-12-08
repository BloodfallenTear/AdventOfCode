using System;

namespace AoC2022;

internal sealed class Program
{
    private static void Main()
    {
        var day = new Day02();

        Console.WriteLine($"Part 1: {day.PartOne()}");
        Console.WriteLine($"Part 2: {day.PartTwo()}");
    }
}
