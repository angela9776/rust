using System;

namespace App
{
    public class FastContext
    {
        private int _state;

        public FastContext(int seed) => _state = seed;

        public int decode(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 64) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new FastContext(64);
            Console.WriteLine(obj.decode(64));
        }
    }
}
