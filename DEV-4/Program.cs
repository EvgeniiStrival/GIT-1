using System;

namespace SequenceNumbers
{
    class SequenceNumbersMain
    {
        static void Main(string[] args)
        {
            try
            {
                // Size of sequence
                Console.WriteLine("Enter size the sequence");
                int sizeSequence = int.Parse(Console.ReadLine());
                int[] mas = new int[sizeSequence];

                // Add the elemements 
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = int.Parse(Console.ReadLine());
                }
                bool temp = false;

                // Checking on nondecreasing
                for (int i = 0; i < mas.Length - 1; i++)
                {
                    if (mas[i + 1] < mas[i])
                    {
                        temp = true;
                        break;
                    }
                }
                if (temp)
                {
                    Console.WriteLine("Sequence not nondecreasing");
                }
                else
                {
                    Console.WriteLine("Sequence  nondecreasing");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Added not a number, try enter again");
            }
            Console.ReadKey();
        }
    }
}