using System;
using System.IO;

namespace AoC2022.Common;

internal abstract class Day
{
    protected String Input { get; private init; }

    protected Day(String typename)
    {
        // Each input.txt file is set to Build Action: Content and Copy to Output Directory: Copy always
        using (var fs = new FileStream($"{typename}/input.txt", FileMode.Open))
        using (var sr = new StreamReader(fs))
        {
            this.Input = sr.ReadToEnd();
        }
    }

    public abstract Object PartOne();

    public abstract Object PartTwo();
}