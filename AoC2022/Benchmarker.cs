using System;

using BenchmarkDotNet.Attributes;

namespace AoC2022;

[MemoryDiagnoser]
public class Benchmarker
{
    private readonly Day04 _day = new Day04();

    [Benchmark] public Object Method() => this._day.PartOne();
}