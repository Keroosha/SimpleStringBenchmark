using System;
using BenchmarkDotNet.Attributes;

namespace StringBenchmark
{
    public class EqualityBenchmark
    {
        private readonly string[,] _values = new string[100, 2];

        public EqualityBenchmark()
        {
            var random = new Random();
            for (var i = 0; i < 100; i++)
            {
                for (var k = 0; k < 2; k++)
                {
                    _values[i, k] = random.Next().ToString();
                }
            }
        }

        public bool EqualityByEquals(string a, string b)
        {
            return string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        }

        public bool EqualityToUpper(string a, string b)
        {
            return a.ToUpper() == b.ToUpper();
        }

        [Benchmark]
        public void ByEqualsBenchmark()
        {
            for (int i = 0; i < 10000; i++)
            {
                for (var arrayIndex = 0; arrayIndex < 100; arrayIndex++)
                {
                    EqualityByEquals(_values[arrayIndex, 0], _values[arrayIndex, 1]);
                }
            }
        }

        [Benchmark]
        public void ToUpperBenchmark()
        {
            for (int i = 0; i < 10000; i++)
            {
                for (var arrayIndex = 0; arrayIndex < 100; arrayIndex++)
                {
                    EqualityToUpper(_values[arrayIndex, 0], _values[arrayIndex, 1]);
                }
            }
        }
    }
}