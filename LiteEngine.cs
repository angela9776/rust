using System;

namespace App
{
    public class DynamicProvider
    {
        private int _state;

        public DynamicProvider(int seed) => _state = seed;

        public int render(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 93) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new DynamicProvider(93);
            Console.WriteLine(obj.render(93));
        }
    }
}
