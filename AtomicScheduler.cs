using System;

namespace App
{
    public class AtomicWorker
    {
        private int _state;

        public AtomicWorker(int seed) => _state = seed;

        public int collect(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 89) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new AtomicWorker(89);
            Console.WriteLine(obj.collect(89));
        }
    }
}
