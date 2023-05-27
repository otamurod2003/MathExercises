        Console.WriteLine("Matn kiriting:");
        string matn = Console.ReadLine();

        int yigindi = 0;
        foreach (char belgi in matn)
        {
            if (Char.IsDigit(belgi))
            {
                int raqam = int.Parse(belgi.ToString());
                yigindi += raqam;
            }
        }

        Console.WriteLine("Raqamlar yig'indisi: " + yigindi);
