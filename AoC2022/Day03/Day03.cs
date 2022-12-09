using System;
using System.Diagnostics;

using AoC2022.Common;

namespace AoC2022;

internal sealed class Day03 : Day
{
    public Day03() : base(nameof(Day03)) { }

    public override Object PartOne()
    {
        var inventory = base.Input.Split(Environment.NewLine);

        var sum = 0;
        foreach (var rucksack in inventory)
        {
            var half = rucksack.Length >> 1;

            var firstCompartment = rucksack[..half];
            var secondCompartment = rucksack[half..];

            foreach (var @char in firstCompartment)
            {
                if (!secondCompartment.Contains(@char))
                    continue;

                sum += GetValue(@char);
                break;
            }
        }

        return sum;

        static Int32 GetValue(Char @char)
        {
            return @char switch
            {
                >= 'a' and <= 'z' => @char - 96,
                >= 'A' and <= 'Z' => @char - 38,
                _ => throw new UnreachableException()
            };
        }
    }

    public override Object PartTwo()
    {
        var inventory = base.Input.Split(Environment.NewLine);

        var sum = 0;
        for (var i = 0; i < inventory.Length; i += 3)
        {
            var first = inventory[i];
            var second = inventory[i + 1];
            var third = inventory[i + 2];

            foreach (var @char in first)
            {
                if (!second.Contains(@char) || !third.Contains(@char))
                    continue;

                sum += GetValue(@char);
                break;
            }
        }

        return sum;

        static Int32 GetValue(Char @char)
        {
            return @char switch
            {
                >= 'a' and <= 'z' => @char - 96,
                >= 'A' and <= 'Z' => @char - 38,
                _ => throw new UnreachableException()
            };
        }
    }
}
