using System;

using AoC2022.Common;

namespace AoC2022;

internal sealed class Day01 : Day
{
    public Day01() : base(nameof(Day01)) { }

    public override Object PartOne()
    {
        var totalInventory = base.Input.Split(Environment.NewLine + Environment.NewLine);

        var max = 0;
        foreach (var inventory in totalInventory)
        {
            var sum = 0;
            foreach (var item in inventory.Split(Environment.NewLine))
                sum += Int32.Parse(item);

            max = Math.Max(max, sum);
        }

        return max;
    }

    public override Object PartTwo()
    {
        var totalInventory = base.Input.Split(Environment.NewLine + Environment.NewLine);

        var max = new Int32[] { 0, 0, 0 };
        foreach (var inventory in totalInventory)
        {
            var sum = 0;
            foreach (var item in inventory.Split(Environment.NewLine))
                sum += Int32.Parse(item);

            if (sum > max[0]) // Not very pretty, but should be one of the fastest ways
            {
                max[2] = max[1];
                max[1] = max[0];
                max[0] = sum;
            }
            else if (sum > max[1])
            {
                max[2] = max[1];
                max[1] = sum;
            }
            else if (sum > max[2])
                max[2] = sum;
        }

        return max[0] + max[1] + max[2];
    }
}
