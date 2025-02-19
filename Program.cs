using System.Runtime.CompilerServices;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vavedi N = ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[8];
            

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"numbers[{i}] = ");
                numbers[i]=int.Parse( Console.ReadLine() );
            }

            long sum = 0;
            long sumEven = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEven += numbers[i];
                }
                else
                {
                    Console.Write($"{numbers[i]}; ");
                }
                
            }
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Avg = {(double)sum/numbers.Length}");
            Console.WriteLine($"Sum of EVEN numbers = {sumEven}");

            for (int i = 0;i < numbers.Length;i++)
            {
                Console.Write($"{numbers[i]}, ");
            }
        }
    }
}
