namespace SumOfArrayElements
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nechta raqam kiritasiz:  \n");
            int number = int.Parse(Console.ReadLine());
            var numbers = new int[number];
            
            for (int num = 0; num < numbers.Length; num++)
            {
                Console.Write($"Number {num + 1}:");
                numbers[num] = int.Parse(Console.ReadLine());
                
            }

           int result =  getSum(numbers);
            Console.WriteLine("Natija: " + result);
        }

        static int getSum(int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
