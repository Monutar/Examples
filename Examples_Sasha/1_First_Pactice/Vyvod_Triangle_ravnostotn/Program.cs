// Начало вывода равностороннего треугольника со звездами

Console.WriteLine("\nНачало вывода равностороннего треугольника со звездами\n");
Console.Write("Пожалуйста, введите количество строк \nУчитывайте, что введенное значение должно быть целым положительным числом\nN=");

int N1;
bool check;

do
{
    string? Console_Input = Console.ReadLine();
    check = int.TryParse(Console_Input, out N1);

    if (!check || N1 <= 0)
    {
        Console.Write("Недопустимое значение.\nУбедитесь, что введенное значение является целым положительным числом\nN=");
    }

} while (N1 <= 0 || !check);

Console.WriteLine("Значение принято\n");

string triangle_1 = new String(' ', 2 * N1 - 1);
string zvezdy_1 = "*";

for (int i = 0; i < N1; i++)
{
    triangle_1 = triangle_1.Insert(N1 - 1 - i, zvezdy_1);
    triangle_1 = triangle_1.Remove(N1 + 1 - i,i);
    zvezdy_1 += "*";
    Console.WriteLine(triangle_1);
}

Console.WriteLine("\nКонец вывода равностороннего треугольника со звездами\n");

/*string[,] massive_1 = new string[N1, 2 * N1 - 1];

Console.WriteLine();
for (int i = 0; i < N1; i++)
{

    for (int j = 0; j < 2 * N1 - 1; j++)
    {

        if (j >= N1 - 1 - i && j <= N1 - 1 + i)
        {
            massive_1[i, j] = "*";
        }

        else
        {
            massive_1[i, j] = " ";
        }

        Console.Write(massive_1[i, j]);
    }

    Console.WriteLine();
}*/
