class Program
{
    public static void Main(string[] args)
    {


        Console.WriteLine("Enter the number of combat rounds: "); //Jang roundlari sonini kiriting
        int rounds = int.Parse(Console.ReadLine());

        int[] firstScore = new int[rounds];
        int[] secondScore = new int[rounds];

        Thread.Sleep(1000);
        Console.WriteLine("Enter the first fighter scores: "); //Birinchi jangchi ballarini kiritish
        for (int i = 0; i < rounds; i++)
        {
            Console.Write($"{i + 1} round: ");
            firstScore[i] = int.Parse(Console.ReadLine());
            Thread.Sleep(1000);
        }
        Console.WriteLine("Okay");
        Thread.Sleep(1000);
        Console.WriteLine("Enter the second fighter scores: "); //Ikkinchi jangchi ballarini kiritish
        for (int i = 0; i < rounds; i++)
        {
            Console.Write($"{i + 1} round: ");
            secondScore[i] = int.Parse(Console.ReadLine());
            Thread.Sleep(1000);
        }
        Thread.Sleep(1000);
        Console.WriteLine("Okay");
        string result = ScoreCalculator(firstScore, secondScore);
        Console.WriteLine(result);

    }


    static string ScoreCalculator(int[] firstScore, int[] secondScore)
    {
        int firstFighterPoints = 0, secondFighterPoints = 0, rounds = firstScore.Length;
        for (int i = 0; i < rounds; i++)
        {
            if (firstScore[i] < secondScore[i])
            {
                secondFighterPoints++;
            }
            else if (firstScore[i] > secondScore[i])
            {
                firstFighterPoints++;
            }
            else
            {
                secondFighterPoints++;
                firstFighterPoints++;
            }
        }

        if (firstFighterPoints == secondFighterPoints)
        {
            return "Equality";
        }
        else if (firstFighterPoints > secondFighterPoints)
        {
            return "First fighter win !!!";
        }
        else
        {
            return "Second fighter win !!!";
        }
    }
}