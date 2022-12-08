using System;
using System.Collections.Generic;

using AoC2022.Common;

namespace AoC2022;

internal sealed class Day02 : Day
{
    public Day02() : base(nameof(Day02)) { }

    public override Object PartOne()
    {
        var rounds = base.Input.Split(Environment.NewLine);

        var guide = new Dictionary<(Char, Char), Byte>
        {
            { ('A', 'X'), 4 }, // Rock (1)     + Draw (3) = 4
            { ('A', 'Y'), 8 }, // Paper (2)    + Win (6)  = 8
            { ('A', 'Z'), 3 }, // Scissors (3) + Loss (0) = 3
            { ('B', 'X'), 1 }, // Rock (1)     + Loss (0) = 1
            { ('B', 'Y'), 5 }, // Paper (2)    + Draw (3) = 5
            { ('B', 'Z'), 9 }, // Scissors (3) + Win (6)  = 9
            { ('C', 'X'), 7 }, // Rock (1)     + Win (6)  = 7
            { ('C', 'Y'), 2 }, // Paper (2)    + Loss (0) = 2
            { ('C', 'Z'), 6 }  // Scissors (3) + Draw (3) = 6
        };

        var score = 0;
        foreach (var round in rounds)
        {
            if (guide.TryGetValue((round[0], round[2]), out var value))
                score += value;
        }

        return score;
    }

    public override Object PartTwo()
    {
        var rounds = base.Input.Split(Environment.NewLine);

        var guide = new Dictionary<(Char, Char), Byte>
        {
            { ('A', 'X'), 3 }, // Scissors (3) + Loss (0) = 3
            { ('A', 'Y'), 4 }, // Rock (1)     + Draw (3) = 4
            { ('A', 'Z'), 8 }, // Paper (2)    + Win (6)  = 8

            { ('B', 'X'), 1 }, // Rock (1)     + Loss (0) = 1
            { ('B', 'Y'), 5 }, // Paper (2)    + Draw (3) = 5
            { ('B', 'Z'), 9 }, // Scissors (3) + Win (6)  = 9

            { ('C', 'X'), 2 }, // Paper (2)    + Loss (0) = 2
            { ('C', 'Y'), 6 }, // Scissors (3) + Draw (3) = 6
            { ('C', 'Z'), 7 }  // Rock (1)     + Win (6)  = 7
        };

        var score = 0;
        foreach (var round in rounds)
        {
            if (guide.TryGetValue((round[0], round[2]), out var value))
                score += value;
        }

        return score;
    }
}
