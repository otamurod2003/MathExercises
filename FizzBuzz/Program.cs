Console.Write("Enter number : ");
int a = Convert.ToInt32(Console.ReadLine());

if(a % 3 == 0)
{
    Console.WriteLine("Fizz");
}
if(a % 5 == 0)
{
    Console.WriteLine("Buzz");
}
if ((a % 5 == 0)&&(a % 3 == 0))
{
    Console.WriteLine("Fizz Buzz");
}
else if(a%5==0 || a%3==0 || (a%3==0&&a%5==0))
{
    Console.WriteLine("not FizzBuzz");
}