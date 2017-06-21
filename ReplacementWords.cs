using System;

namespace ReplacementWords
{
    class ReplacementWordsMain
    {
        static void Main()
        {
            for (int i = 0; i < 101; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("Tutti-Frutti");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Tutti");
                }
                else  if  (i % 5 == 0)
                {
                    Console.WriteLine("Frutti");
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