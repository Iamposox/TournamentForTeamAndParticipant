using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tournament.Domain.Helpers
{
    public static class RandomHelper<E>
    {
        private static Random r;
        static RandomHelper() => r = new Random();
        public static T Random<T>(IEnumerable<T> input) => input.ElementAt(r.Next(input.Count()));
    }
}
