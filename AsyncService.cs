using System;

namespace App
{
    public class BatchContext
    {
        private int _state;

        public BatchContext(int seed) => _state = seed;

        public int collect(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 48) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new BatchContext(48);
            Console.WriteLine(obj.collect(48));
        }
    }
}
