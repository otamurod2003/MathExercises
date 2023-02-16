//Kiritilgan son tub yoki tub emasligini aniqlovchi dastur

int number;

Console.Write("Son kiriting: ");
number = Convert.ToInt32(Console.ReadLine());

var yaxlit = Math.Ceiling(Math.Sqrt(number));
if(number == 0 || number==1)
    Console.WriteLine("Tub son emas");
else
{
    for (int i = 2; i < yaxlit; i++)
    {
        if(yaxlit % i == 0)
        {
            Console.WriteLine("Tub son emas");
        }
        else
        {
            Console.WriteLine($"{i} Tub son");
        }
    }
}
