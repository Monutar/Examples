//проверка

Console.WriteLine("\nНачало вывода прямоугольного треугольника со звездами\n");
Console.Write("Пожалуйста, введите количество строк \nУчитывайте, что введенное значение должно быть целым положительным числом\nN=");

int N;
bool check;

do
{
    string? S = Console.ReadLine();
    check = int.TryParse(S, out N);

    if (!check || N <= 0) Console.Write("Недопустимое значение.\nУбедитесь, что введенное значение является целым положительным числом\nN=");
} while (N <= 0 || !check);

Console.WriteLine("Значение принято\n");

string[,] massive = new string[N, N];

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (j <= i) massive[i, j] = "*";
        Console.Write(massive[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine("\nКонец вывода треугольника со звездами\n");