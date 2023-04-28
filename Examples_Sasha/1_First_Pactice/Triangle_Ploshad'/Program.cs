// Начало расчета площади треугольника

Console.WriteLine("\nНачало расчета площади треугольника\n");

double a, b;
bool Check_A, Check_B;
double Ploshad_Tr;

do
{
    Console.Write("Пожалуйста, введите первую сторону треугольника\nУчитывайте, что введенное значение должно быть целым положительным числом\na=");
    string? A = Console.ReadLine();
    Console.Write("Пожалуйста, введите вторую сторону треугольника \nУчитывайте, что введенное значение должно быть целым положительным числом\nb=");
    string? B = Console.ReadLine();
    Check_A = double.TryParse(A, out a);
    Check_B = double.TryParse(B, out b);

    if (!Check_A || !Check_B || a <= 0 || b <= 0)
    {
        Console.Write("Введенные данные недопустимы\nУбедитесь, что оба введенных значения являются целыми положительными числоми\n");
    }

} while (!Check_A || !Check_B || a <= 0 || b <= 0);

Console.WriteLine("\nЗначения приняты");
Console.WriteLine($"\nПервая сторона a={a}\nВторая сторона b={b}");

Ploshad_Tr = a * b / 2;

Console.WriteLine($"\nПлощадь треугольника равна {Ploshad_Tr}");
Console.WriteLine("\nКонец расчета площади треугольника\n");
