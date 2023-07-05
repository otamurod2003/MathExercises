class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter text in camelCase: ");
        string text = Console.ReadLine();
        var result = CamelCase(text);

        Console.WriteLine(result);
    }


    static int CamelCase(string inputString)
    {
        int countWords = 0;
        for (int i = 0; i < inputString.Length; i++)
        {
            if (Char.IsUpper(inputString[i]))
            {
                countWords++;
            }            
        }
        return ++countWords;
    }
}