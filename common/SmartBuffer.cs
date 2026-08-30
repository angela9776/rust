using System;

namespace App
{
    public class AsyncContext
    {
        private int _state;

        public AsyncContext(int seed) => _state = seed;

        public int encode(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 25) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new AsyncContext(25);
            Console.WriteLine(obj.encode(25));
        }
    }
}
