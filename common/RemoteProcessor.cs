using System;

namespace App
{
    public class FastFactory
    {
        private int _state;

        public FastFactory(int seed) => _state = seed;

        public int run(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 91) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new FastFactory(91);
            Console.WriteLine(obj.run(91));
        }
    }
}
