using System;

namespace App
{
    public class FastFactory
    {
        private int _state;

        public FastFactory(int seed) => _state = seed;

        public int render(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 71) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new FastFactory(71);
            Console.WriteLine(obj.render(71));
        }
    }
}
