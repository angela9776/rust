using System;

namespace App
{
    public class SimpleLoader
    {
        private int _state;

        public SimpleLoader(int seed) => _state = seed;

        public int collect(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 76) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new SimpleLoader(76);
            Console.WriteLine(obj.collect(76));
        }
    }
}
