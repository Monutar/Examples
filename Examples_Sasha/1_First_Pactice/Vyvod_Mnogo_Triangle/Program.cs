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

string triangle_1 = new String(' ', 2 * N2 - 1);
string zvezdy_1 = "*";

for (int i = 0; i < N2; i++)
{
    triangle_1 = triangle_1.Insert(N2 - 1 - i, zvezdy_1);
    triangle_1 = triangle_1.Remove(N2 + 1 - i, i);
    zvezdy_1 += "*";
    Console.WriteLine(triangle_1);
}




/*  ПЕРВЫЙ СПОСОБ
 * 
 * Console.WriteLine("Значение принято\n");

string triangle_1 = new String(' ', 2 * N2 - 1);
string zvezdy_1 = "*";

for (int i = 0; i < N2; i++)
{
    zvezdy_1 = "*";
    triangle_1 = new String(' ', 2 * N2 - 1);

    for (int j = 0; j <= i; j++ )
    {
        
        triangle_1 = triangle_1.Insert(N2 - 1 - j, zvezdy_1);
        triangle_1 = triangle_1.Remove(N2 + 1 - j, j);
        zvezdy_1 += "*";
        Console.WriteLine(triangle_1);
    }
      
}*/


/*  ВТОРОЙ СПОСОБ
 * 
 * int[] Number_Of_Strings_Massive = new int[N2];

for (int l = 0; l < N2; l++)
{
    Number_Of_Strings_Massive[l] = p;
    Sum_Of_Strings += Number_Of_Strings_Massive[l];
    p += 1;
}

Console.WriteLine($"Количество строк в общем массиве = {Sum_Of_Strings}");

string[,,] massive_2 = new string[Sum_Of_Strings, 2 * N2 - 1, 2 * N2 - 1];

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

// ТРЕТИЙ СПОСОБ    Вместо метода можно через трехмерный массив сделать еще.

for (int i = 0; i < N2; i++)
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
