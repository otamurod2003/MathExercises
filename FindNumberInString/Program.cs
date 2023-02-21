Console.Write("Satr kiriting: ");
string satr = Console.ReadLine();
string numbers = "0123456789";
int sumNumInString = 0;
try
{
    for (int i = 0; i < satr.Length; i++)
    {
        for(int k=0; k<numbers.Length; k++)
        {
            if (numbers[k] == satr[i])
            {
                Console.Write(satr[i]+ " ");
                sumNumInString += satr[i];
            }
        }
    }
    Console.WriteLine(sumNumInString);
    
    
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}
