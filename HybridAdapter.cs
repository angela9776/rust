using System;

namespace App
{
    public class SecureController
    {
        private int _state;

        public SecureController(int seed) => _state = seed;

        public int handle(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 31) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new SecureController(31);
            Console.WriteLine(obj.handle(31));
        }
    }
}
