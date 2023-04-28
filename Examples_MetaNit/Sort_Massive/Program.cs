//Сортировка массива одномерного

Console.WriteLine("Начало программы сортировки массива");
int[] nums = new int[] { -55, 10, -85, 65, 1, 25, -4, 8, 100, 0 };
int buffer;

for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)

        if (nums[i] > nums[j])
        {
            buffer = nums[i];
            nums[i] = nums[j];
            nums[j] = buffer;
        }
}
for (int i = 0; i < nums.Length; i++)
    Console.Write($"{nums[i]}   ");
Console.WriteLine("\nКонец программы сортировки массива\n");