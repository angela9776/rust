using System;

namespace App
{
    public class BatchController
    {
        private int _state;

        public BatchController(int seed) => _state = seed;

        public int build(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 63) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new BatchController(63);
            Console.WriteLine(obj.build(63));
        }
    }
}
