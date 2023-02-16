//Kiritilgan son tub yoki tub emasligini aniqlovchi dastur
bool isPrime(int number)
{
    if (number == 1) return false;
    if (number == 2) return true;

    var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

    for (int i = 2; i <= limit; ++i)
        if (number % i == 0)
            return false;
    return true;

}
isPrime(15);
//Ikkinchi usul
static bool IsPrime(int n)
{
    if (n > 1)
    {
        return Enumerable.Range(1, n).Where(x => n % x == 0)
                         .SequenceEqual(new[] { 1, n });
    }

    return false;
}
IsPrime(45);