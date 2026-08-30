using System;

namespace App
{
    public class DynamicContext
    {
        private int _state;

        public DynamicContext(int seed) => _state = seed;

        public int collect(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 48) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new DynamicContext(48);
            Console.WriteLine(obj.collect(48));
        }
    }
}
