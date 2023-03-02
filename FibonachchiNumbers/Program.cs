class Program
{
    static void Main(string[] args)
    {
        int[] numbers=null;
        int[] fibonaci=null;
        numbers[0] = 1;
        numbers[1] = 2;

        for(int i=2; i<10; i++)
        {
            numbers[i] = numbers[i] + numbers[i-1];
            fibonaci[i]= numbers[i];
        }

        Console.WriteLine(fibonaci);
    }
}
