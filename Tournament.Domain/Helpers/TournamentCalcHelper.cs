﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tournament.Domain.Helpers
{
    public static class EnumerableExtensions
    {
        public static T Random<T>(this IEnumerable<T> input)
        {
            return RandomHelper<T>.Random(input);
        }
    }
    public static class TournamentCalcHelper
    {
        public static bool isPowerOfTwo(int x) => ((x != 0) && ((x & (~x + 1)) == x));
        public static int CalcInitialPairCount(int count)
        {
            while (!isPowerOfTwo(count))
                count--;
            return count / 2;
        }
        public static int CalcPreQualifyPairCount(int totalCount)
        {
            int count = totalCount;
            while (!isPowerOfTwo(count))
                count--;
            return totalCount - count;
        }

        public static int CalcRounds(int totalBrackets)
        {
            int count = 0;
            while (totalBrackets > 1)
            {
                totalBrackets = totalBrackets / 2;
                count++;
            }
            return count;
        }
    }
}
