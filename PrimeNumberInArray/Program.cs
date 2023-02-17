/*100% togri db o'ylayman*/
int[] nums;

Console.Write("Count numbers: ");
int num = Convert.ToInt32(Console.ReadLine());
nums = new int[num];
for(int i= 0; i < nums.Length; i++)
{
    Console.Write($"Enter {i+1} number: ");
    nums[i] = Convert.ToInt32(Console.ReadLine());
}
//int[] nums = { 98,12,65,87,17,13,23,43,47 };

int j;

for (int i = 0; i < nums.Length; i++)
{

    for (j = 2; j < nums[i]; j++)
        if ((nums[i] % j == 0))
        {
            Console.WriteLine("{0} : Is NOT a primenumber", +nums[i]);
            break;
        }
    if (j == nums[i])
    {
        Console.WriteLine("{0} : Is a primenumber", +nums[i]);

    }

}
