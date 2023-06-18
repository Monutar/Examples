// Начало нахождения суммы чисел меньше 1000 и кратных 3 или 5

Console.WriteLine("\nНачало нахождения суммы чисел меньше 1000 и кратных 3 или 5");

int Sum = 0;
int[] Massive_All = new int[1001];
int q = 0;
int[] Massive_Usloviya = new int[1001];

for (int i = 0; i < 1000; i++)
{
    double check_3 = Math.IEEERemainder(i, 3);
    double check_5 = Math.IEEERemainder(i, 5);

    if (i < 1000 && (check_3 == 0 || check_5 == 0))
    {
        Sum += i;
        q++;
    }

}

Console.WriteLine(Sum);
Console.WriteLine(q);

    /*for (int i = 0; i < Massive_All.Length; i++)
    {
        Massive_All[i] = i;

        // Если нужно вывести весь массив от 1 до 1000

        //Console.WriteLine(massa[i]);

        double check_3 = Math.IEEERemainder(Massive_All[i], 3);
        double check_5 = Math.IEEERemainder(Massive_All[i], 5);

        if (Massive_All[i] < 1000 && (check_3 == 0 || check_5 == 0))
        {
            Sum += Massive_All[i];
            Massive_Usloviya[q] = Massive_All[i];
            q += 1;
        }

    }*/

/*Console.WriteLine("\nВывод массива с числами, удовлетворяющим условиям\n");

int Sum_Check = 0;

for (int j = 0; j < q; j++)
{
    Console.WriteLine(Massive_Usloviya[j]);
    Sum_Check += Massive_Usloviya[j];
}

Console.WriteLine($"Найдено k={q} значений, которые удовлетворяют условиям");
Console.WriteLine($"Сумма значений, которые удовлетворяют условиям равна {Sum}");
Console.WriteLine($"Проверка на сумму {Sum_Check}");*/