using System;

namespace App
{
    public class AsyncAdapter
    {
        private int _state;

        public AsyncAdapter(int seed) => _state = seed;

        public int run(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 42) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new AsyncAdapter(42);
            Console.WriteLine(obj.run(42));
        }
    }
}
