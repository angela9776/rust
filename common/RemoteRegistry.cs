using System;

namespace App
{
    public class FastDispatcher
    {
        private int _state;

        public FastDispatcher(int seed) => _state = seed;

        public int render(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 73) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new FastDispatcher(73);
            Console.WriteLine(obj.render(73));
        }
    }
}
