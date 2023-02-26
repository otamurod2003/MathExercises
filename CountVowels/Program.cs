using System.ComponentModel.DataAnnotations;

namespace CountVowels
{
	class Program
	{
		static	void Main(string[] args)
		{
            string vowels = "aeiou";
			Console.Write("Satr kiriting: ");
			var text = Console.ReadLine();
			
			int count = 0; 
			for(int i=0;i<text.Length; i++)
			{
				if (text[i] == 'a' || text[i] == 'e' || text	[i] == 'o' || text[i] == 'u' || text[i] == 'i')
					count++;
			}

			Console.WriteLine("Count: "+ count);

			
		}
	}
}