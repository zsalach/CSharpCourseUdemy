
using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * string name = args[0];
            string surname = args[1];
            string nickname = args[2];
            Console.WriteLine($"Witaj {name} {surname} {nickname}!" );
            */

            foreach (var item in args)
            {
                Console.WriteLine($"Witaj {item}");
            }
        }
    }
}
