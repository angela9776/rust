using System;

namespace App
{
    public class SimpleController
    {
        private int _state;

        public SimpleController(int seed) => _state = seed;

        public int encode(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 8) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new SimpleController(8);
            Console.WriteLine(obj.encode(8));
        }
    }
}
