using System;

namespace App
{
    public class LocalFactory
    {
        private int _state;

        public LocalFactory(int seed) => _state = seed;

        public int decode(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 16) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new LocalFactory(16);
            Console.WriteLine(obj.decode(16));
        }
    }
}
