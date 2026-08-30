using System;

namespace App
{
    public class AsyncCache
    {
        private int _state;

        public AsyncCache(int seed) => _state = seed;

        public int build(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 24) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new AsyncCache(24);
            Console.WriteLine(obj.build(24));
        }
    }
}
