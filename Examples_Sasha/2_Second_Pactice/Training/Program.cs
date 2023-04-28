Console.WriteLine("jioioijo");



//сортировка массива одномерного
Console.WriteLine("Начало программы сортировки массива");
int[] nums = new int[] {-55,10,-85,65,1,25,-4,8,100,0};
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


//Начало красивого вывода 3Д массива
Console.WriteLine("Начало красивого вывода 3Д массива");
int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };
Console.Write("{");
for (int i = 0; i < mas.GetLength(0); i++)
{
    Console.Write("{");
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Console.Write("{");
        for (int k = 0; k < mas.GetLength(2); k++)
        {
            Console.Write($"{mas[i, j, k]}");

            if (k < mas.GetLength(2) - 1)
            {
                Console.Write(" , ");
            }

        }
        Console.Write("}");
        
        if (j < mas.GetLength(1) - 1)
        {
            Console.Write(" , ");
        }

    }   
    Console.Write("}");
    
    if (i < mas.GetLength(0) - 1)
    {
        Console.Write(" , ");
    }

}
Console.Write("}");
Console.WriteLine("\nКонец красивого вывода 3Д массива\n");

//Начало расчета площади треугольника

Console.WriteLine("\nНачало расчета площади треугольника\n");

double a,b;
bool CheckA,CheckB;
double PloshadTr;

do
{
    Console.Write("Пожалуйста, введите первую сторону треугольника\nУчитывайте, что введенное значение должно быть целым положительным числом\na=");
    string? A = Console.ReadLine();
    Console.Write("Пожалуйста, введите вторую сторону треугольника \nУчитывайте, что введенное значение должно быть целым положительным числом\nb=");
    string? B = Console.ReadLine();
    CheckA = double.TryParse(A, out a);
    CheckB = double.TryParse(B, out b);

    if (!CheckA || !CheckB || a <= 0 || b <= 0)
    {
        Console.Write("Введенные данные недопустимы\nУбедитесь, что оба введенных значения являются целыми положительными числоми\n");
    }
    
} while (!CheckA || !CheckB || a <= 0 || b <= 0 );

Console.WriteLine("\nЗначения приняты\n");
Console.WriteLine($"Первая сторона a={a}\nВторая сторона b={b}");

PloshadTr = a * b / 2;

Console.WriteLine($"\nПлощадь треугольника равна {PloshadTr}");
Console.WriteLine("\nКонец расчета площади треугольника\n");


//Начало вывода треугольника в виде изображения
Console.WriteLine("\nНачало вывода прямоугольного треугольника со звездами\n");
Console.Write("Пожалуйста, введите количество строк \nУчитывайте, что введенное значение должно быть целым положительным числом\nN=");

int N;
bool check;

do
{
    string? S = Console.ReadLine();
    check = int.TryParse(S, out N);

    if (!check || N <= 0)
    {
        Console.Write("Недопустимое значение.\nУбедитесь, что введенное значение является целым положительным числом\nN=");
    }

} while (N <= 0 || !check);

Console.WriteLine("Значение принято\n");

string[,] massive = new string[N, N];

for (int i = 0;i < N;i++)
{
    for (int j = 0;j < N;j++)
    {
        
        if (j <= i) massive[i, j] = "*";
        {
            Console.Write(massive[i, j]);
        }

    }
    Console.WriteLine();
}
Console.WriteLine("\nКонец вывода треугольника со звездами\n");

//Начало вывода равностороннего треугольника со звездами

Console.WriteLine("\nНачало вывода равностороннего треугольника со звездами\n");
Console.Write("Пожалуйста, введите количество строк \nУчитывайте, что введенное значение должно быть целым положительным числом\nN=");

int N1;

do
{
    string? S = Console.ReadLine();
    check = int.TryParse(S, out N1);

    if (!check || N1 <= 0)
    {
        Console.Write("Недопустимое значение.\nУбедитесь, что введенное значение является целым положительным числом\nN=");
    }

} while (N1 <= 0 || !check);

Console.WriteLine("Значение принято\n");

string[,] massive1 = new string[N1, 2 * N1 - 1];

Console.WriteLine();
for (int i = 0; i < N1; i++)
{
    for (int j = 0; j < 2 * N1 - 1; j++)
    {

        if (j >= N1 - 1 - i && j <= N1 - 1 + i)
        {
            massive1[i, j] = "*";
        }
        
        else
        {
            massive1[i, j] = " ";
        }

        Console.Write(massive1[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine("\nКонец вывода равностороннего треугольника со звездами\n");


//Начало вывода многих треугольников с отсечкой

Console.WriteLine("\nНачало вывода многих треугольников с отсечкой\n");
Console.Write("Пожалуйста, введите количество строк \nУчитывайте, что введенное значение должно быть целым положительным числом\nN=");

int k1 = 1;
int N_sum = 0;
int p = 1;
int N2;

do
{
    string? S = Console.ReadLine();
    check = int.TryParse(S, out N2);

    if (!check || N2 <= 0)
    {
        Console.Write("Недопустимое значение.\nУбедитесь, что введенное значение является целым положительным числом\nN=");
    }

} while (N2 <= 0 || !check);

Console.WriteLine("Значение принято\n");
int[] massive_l = new int[N2];

for ( int l = 0; l < N2; l++)
{
    massive_l[l] = p;
    N_sum += massive_l[l];
    p += 1;
}

Console.WriteLine($"Количество строк в общем массиве = {N_sum}");

string[,] massive2 = new string[N_sum, 2 * N2 - 1];

Console.WriteLine();

void Triangle (int N_sum, int N2)
{
    for (int i = 0; i < N_sum; i++)
    {
        for (int j = 0; j < 2 * N2 - 1; j++)
        {
           
            if (j >= N2 - 1 - i && j <= N2 - 1 + i)
            {
                massive2[i, j] = "*";
            }

            else
            {
                massive2[i, j] = " ";
            }

            Console.Write(massive2[i, j]);
        }
        k1 += 1;
        Console.WriteLine();
    }
}

for (int i = 0;i <= N2 ; i++)
{
    Triangle (i, N2);
}

Console.WriteLine("\nКонец вывода многих треугольников с отсечкой\n");


//Начало нахождения суммы чисел меньше 1000 и кратных 3 или 5

int Sum = 0;
int[] massa = new int[1001];
int q = 0;
int[] MassSum = new int[1001];
for (int i = 0; i <= massa.Length - 1; i++)
{
    massa[i] = i;
                                                                                            //Console.WriteLine(massa[i]);
    double check_3 = Math.IEEERemainder(massa[i], 3);
    double check_5 = Math.IEEERemainder(massa[i], 5);
    
    if (massa[i] < 1000 && (check_3 == 0 || check_5 == 0))
    {
        Sum += massa[i];
        MassSum[q] = massa[i];
        q += 1;
    } 
    
}

Console.WriteLine("\nВывод массива с числами, удовлетворяющим условиям\n");

int SumCheck = 0;

for (int j = 0; j < q; j++)
{
    Console.WriteLine(MassSum[j]);
    SumCheck += MassSum[j];
}
Console.WriteLine($"Найдено k={q} значений, которые удовлетворяют условиям");
Console.WriteLine($"Сумма значений, которые удовлетворяют условиям равна {Sum}");
Console.WriteLine($"Проверка на сумму {SumCheck}");