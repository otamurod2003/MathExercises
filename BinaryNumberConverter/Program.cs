//Selecting numeration system
Console.Write("Qaysi sanoq tizimidan o'tkazamiz: ");
int fromSelectNumerationSystem = Convert.ToInt32(Console.ReadLine());
Console.Write("Qaysi sanoq tizimiga o'tkazamiz: ");
int doSelectNumerationSystem = Convert.ToInt32(Console.ReadLine());
if (fromSelectNumerationSystem < 2 || doSelectNumerationSystem > 16)
{
    Console.WriteLine("Notog'ri sanoq tizimlari ko'rsatildi");
}
else
{
    Console.WriteLine($"{fromSelectNumerationSystem} sanoq tizimidagi sonni kiriting: ");
    int firstNumber = int.Parse(Console.ReadLine());
    Console.WriteLine($"{doSelectNumerationSystem} sanoq tizimidagi sonni kiriting: ");
    int secondNumber = int.Parse(Console.ReadLine());
    var firstNumToStr = firstNumber.ToString();
    var secondNumToStr = secondNumber.ToString();
    foreach (int firstNumberElement in firstNumToStr)
    {
        if (firstNumberElement >= fromSelectNumerationSystem) { Console.WriteLine(firstNumberElement + "is not defined ?");
            break;
        }
        else
        {
            Console.WriteLine("Okay");
        }
    }
    foreach (int secondNumberElement in firstNumToStr)
    {
        if (secondNumberElement >= doSelectNumerationSystem)
        {
            Console.WriteLine(secondNumberElement + "is not defined ?");
            break;
        }
        else
        {
            Console.WriteLine("Okay");
        }
    }

}




