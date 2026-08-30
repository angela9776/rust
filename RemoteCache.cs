using System;

namespace App
{
    public class AtomicMonitor
    {
        private int _state;

        public AtomicMonitor(int seed) => _state = seed;

        public int flush(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 16) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new AtomicMonitor(16);
            Console.WriteLine(obj.flush(16));
        }
    }
}
