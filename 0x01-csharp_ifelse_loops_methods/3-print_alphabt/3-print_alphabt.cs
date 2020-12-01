using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 97; i <= 122; i++)
            {
                if ((char)i != 'e' && (char)i != 'q')
                {
                    Console.Write((char)i);
                }
            }
        }
    }
}
