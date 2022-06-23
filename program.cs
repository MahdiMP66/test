using System;

namespace ConsoleApp1
{

    class Program
    {
        public static void pow3(int a)
        {
            Console.WriteLine(a*a*a);
        }
        public static void pow2(int a)
        {
            Console.WriteLine(a*a);
        }
        static void Main(string[] args)
        {
            pow3(5);
            pow2(5);
        }
    }
}
