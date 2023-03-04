/*static void Fibonacci_Iterative(int len)
{
   int a = 0, b = 1, c = 0;
   Console.Write("{0} {1}", a, b);
   for (int i = 2; i < len; i++)
   {
       c = a + b;
       Console.Write(" {0}", c);
       a = b;
       b = c;
   }
}

Fibonacci_Iterative(20);*/


   

 static void Fibonacci_Rec_Temp(int a, int b, int counter, int len)
{
    if (counter <= len)
    {
        Console.Write("{0} ", a);
        Fibonacci_Rec_Temp(b, a + b, counter + 1, len);
    }
}
Fibonacci_Rec_Temp(0, 1, 1, 15);