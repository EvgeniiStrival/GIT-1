using System;

namespace ChangeNum3
{
    class ChangeNum3Main
    {
        static void Main()
        {
            for (int i = 0; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("3*" + i / 3);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}

