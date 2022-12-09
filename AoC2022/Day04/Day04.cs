using System;

using AoC2022.Common;

namespace AoC2022;

internal sealed class Day04 : Day
{
    public Day04() : base(nameof(Day04)) { }

    public override Object PartOne()
    {
        var split = base.Input.Split(Environment.NewLine);

        var sum = 0;
        foreach (var pair in split)
        {
            var x = pair.Split(',');

            var leftPair = x[0];
            var rightPair = x[1];

            var leftPairSplit = leftPair.Split('-');
            var rightPairSplit = rightPair.Split('-');

            var leftPairLower = Int32.Parse(leftPairSplit[0]);
            var leftPairUpper = Int32.Parse(leftPairSplit[1]);

            var rightPairLower = Int32.Parse(rightPairSplit[0]);
            var rightPairUpper = Int32.Parse(rightPairSplit[1]);

            if ((leftPairLower <= rightPairLower && rightPairUpper <= leftPairUpper) || (rightPairLower <= leftPairLower && leftPairUpper <= rightPairUpper))
                sum++;
        }

        return sum;
    }

    public override Object PartTwo()
    {
        var split = base.Input.Split(Environment.NewLine);

        var sum = 0;
        foreach (var pair in split)
        {
            var x = pair.Split(',');

            var leftPair = x[0];
            var rightPair = x[1];

            var leftPairSplit = leftPair.Split('-');
            var rightPairSplit = rightPair.Split('-');

            var leftPairLower = Int32.Parse(leftPairSplit[0]);
            var leftPairUpper = Int32.Parse(leftPairSplit[1]);

            var rightPairLower = Int32.Parse(rightPairSplit[0]);
            var rightPairUpper = Int32.Parse(rightPairSplit[1]);

            if (leftPairUpper >= rightPairLower && leftPairLower <= rightPairUpper)
                sum++;
        }

        return sum;
    }
}
