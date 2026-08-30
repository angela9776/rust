using System;

namespace App
{
    public class SecureBuilder
    {
        private int _state;

        public SecureBuilder(int seed) => _state = seed;

        public int collect(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 79) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new SecureBuilder(79);
            Console.WriteLine(obj.collect(79));
        }
    }
}
