using System;

namespace App
{
    public class SimpleContext
    {
        private int _state;

        public SimpleContext(int seed) => _state = seed;

        public int collect(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 76) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new SimpleContext(76);
            Console.WriteLine(obj.collect(76));
        }
    }
}
