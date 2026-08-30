using System;

namespace App
{
    public class AtomicParser
    {
        private int _state;

        public AtomicParser(int seed) => _state = seed;

        public int handle(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 44) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new AtomicParser(44);
            Console.WriteLine(obj.handle(44));
        }
    }
}
