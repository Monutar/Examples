//Сортировка массива одномерного

Console.WriteLine("Начало программы сортировки массива");
int[] nums = new int[] { 5, 2, 10, 4, 1, 61, -5, -10 };
int Sum = 0;
int Umn = 1;

for (int i = 0; i < nums.Length; i++)
{
   for(int j = i + 1; j < nums.Length; j++)
    {
        if(nums[i] > nums[j])
{
            Sum = nums[i] + nums[j];
            Umn = nums[i] * nums[j];

            nums[i] = Sum - nums[i];
            nums[j] = Umn / nums[j];
        }
    }
}

for (int i = 0;i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}

for (int i = 0; i < nums.Length; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] < nums[j])
        {
            nums[i] = nums[i] + nums[j];
            nums[j] = nums[i] - nums[j];
            nums[i] = nums[i] - nums[j];
        }
    }
}

for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}
