using System;

namespace App
{
    public class HybridAdapter
    {
        private int _state;

        public HybridAdapter(int seed) => _state = seed;

        public int sync(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 56) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new HybridAdapter(56);
            Console.WriteLine(obj.sync(56));
        }
    }
}
