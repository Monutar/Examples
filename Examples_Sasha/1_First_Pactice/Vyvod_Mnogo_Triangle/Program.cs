// Начало вывода многих треугольников с отсечкой

Console.WriteLine("\nНачало вывода многих треугольников с отсечкой\n");
Console.Write("Пожалуйста, введите количество строк \nУчитывайте, что введенное значение должно быть целым положительным числом\nN=");

int k1 = 1;
int Sum_Of_Strings = 0;
int p = 1;
int N2;
bool check;

do
{
    string? Console_Input = Console.ReadLine();
    check = int.TryParse(Console_Input, out N2);

    if (!check || N2 <= 0)
    {
        Console.Write("Недопустимое значение.\nУбедитесь, что введенное значение является целым положительным числом\nN=");
    }

} while (N2 <= 0 || !check);

Console.WriteLine("Значение принято\n");
int[] Number_Of_Strings_Massive = new int[N2];

for (int l = 0; l < N2; l++)
{
    Number_Of_Strings_Massive[l] = p;
    Sum_Of_Strings += Number_Of_Strings_Massive[l];
    p += 1;
}

Console.WriteLine($"Количество строк в общем массиве = {Sum_Of_Strings}");

string[,] massive_2 = new string[Sum_Of_Strings, 2 * N2 - 1];

Console.WriteLine();

void Triangle(int Strings_In_Triangle, int N2)
{

    for (int i = 0; i < Strings_In_Triangle; i++)
    {

        for (int j = 0; j < 2 * N2 - 1; j++)
        {

            if (j >= N2 - 1 - i && j <= N2 - 1 + i)
            {
                massive_2[i, j] = "*";
            }

            else
            {
                massive_2[i, j] = " ";
            }

            Console.Write(massive_2[i, j]);
        }

        k1 += 1;
        Console.WriteLine();
    }

}

for (int i = 2; i <= N2; i++)
{
    Triangle(i, N2);
}

// Вместо метода можно через трехмерный массив сделать еще. Чистый код есть в "Для тестовых штук". Нижний проект.

/*for (int i = 0; i < N2; i++)
{

    for (int j = 0; j <= i; j++)
    {

        for (int k = 0; k < 2 * N2 - 1; k++)
        {

            if (k >= N2 - 1 - j && k <= N2 - 1 + j)
            {
                massive_2[i, j, k] = "*";
            }

            else
            {
                massive_2[i, j, k] = " ";
            }

            Console.Write(massive_2[i, j, k]);
        }

        Console.WriteLine();
    }

}*/

Console.WriteLine("\nКонец вывода многих треугольников с отсечкой\n");
