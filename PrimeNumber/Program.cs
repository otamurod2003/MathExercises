//notogri ishlasa mandanmas!!
class Program
{
    static void Main(string[] args)
    {
        int i, number;
        Console.Write("Son kiriting:");
        number = Convert.ToInt32(Console.ReadLine());
        
        double limit = (int)Math.Ceiling(Math.Sqrt(number));

        if (number%3==0)
        {
            Console.WriteLine("Tub emas!!!");
        }
        for (i = 2; i <limit; i+=3)
        {
            if ((number % i) == 0)
            {
                Console.WriteLine("Tub emas");

                break;
            }

            else
            {
                Console.WriteLine("Tub"); break;

            }
        }
        
       

    }  
}