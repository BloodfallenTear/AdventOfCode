using System;

using BenchmarkDotNet.Running;

namespace AoC2022;

internal sealed class Program
{
    private static void Main()
    {
		//BenchmarkRunner.Run<Benchmarker>();
		
        var day = new Day03();

        Console.WriteLine($"Part 1: {day.PartOne()}");
        Console.WriteLine($"Part 2: {day.PartTwo()}");
    }
}
