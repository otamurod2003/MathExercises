using System.Collections;
using System;
namespace ArrayOfMultiples
{
    class Program
    {
        static void Main(string[] args)
        {   //Ozgaruvchilarni elon qilamiz :
            int number, multipleArrayCount;

            //Kiritiladigan son :
            Console.Write("Qaysi sonni karralilarini ko'rmoqchisiz? ");
            number = Convert.ToInt32(Console.ReadLine());

            //Karralilari soni
            Console.Write("Nechta son ekranga chiqarilsin ? ");
            multipleArrayCount= Convert.ToInt32(Console.ReadLine());

            int[] multipleArrayNumbers = new int[multipleArrayCount];
            //multipleArrayNumbers[0] = 1;
            for (int i = 0; i < multipleArrayNumbers.Length; i++)
            {
                multipleArrayNumbers[i] = i;
                Console.WriteLine(multipleArrayNumbers[i] * number);   
            }
        }

    }  

}