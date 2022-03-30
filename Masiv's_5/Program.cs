using System.Diagnostics;

Stopwatch stopWatch = new Stopwatch();
int[] mas = { 2, 13, 21312, 21321, 352, 547, 65, 85, 54, 432, 8, 54 };
/*int[] mas = new int[10001];
Random Rnd = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = Rnd.Next(0, 10000);
}*/
Console.Write("Не отсортированный массив: ");
for (int i = 0; i < mas.Length; i++) Console.Write($"{mas[i]} ");
Console.WriteLine();

// Сортировка выбором???
int[] mas1 = mas;
int swap;
stopWatch.Start();
for (int i = 0; i < mas1.Length - 1; i++)
{
    for (int j = i + 1; j < mas1.Length; j++)
    {
        if (mas1[i] < mas1[j])
        {
            swap = mas1[i];
            mas1[i] = mas1[j];
            mas1[j] = swap;
        }
    }
}
stopWatch.Stop();
Console.Write("\nСортировка выбором???");
Console.Write("\nОтсортированный массив: ");
for (int i = 0; i < mas1.Length; i++) Console.Write($"{mas1[i]} ");
Console.Write("\nСкорость выполнения: ");
Console.Write(stopWatch.Elapsed);
stopWatch.Reset();

// Сортировка пузырьковым методом.
int[] mas2 = mas;
stopWatch.Start();
for (int i = 0; i < mas2.Length; i++)
{
    for (int j = 0; j < mas2.Length - 1; j++)
    {
        if (mas2[j] > mas2[j + 1])
        {
            swap = mas2[j + 1];
            mas2[j + 1] = mas2[j];
            mas2[j] = swap;
        }
    }
}
stopWatch.Stop();
Console.Write("\n\nСортировка пузырьковым методом.");
Console.Write("\nОтсортированный массив: ");
for (int i = 0; i < mas2.Length; i++) Console.Write($"{mas2[i]} ");
Console.Write("\nСкорость выполнения: ");
Console.Write(stopWatch.Elapsed);
stopWatch.Reset();

// Сортировка выбором.
int[] mas3 = mas;
int Max = int.MaxValue, ix = 0, dlin = mas3.Length, pol = mas3.Length/2;
stopWatch.Start();
for (int j = 0; j < mas3.Length; j++)
{
    for (int i = 0; i < dlin; i++)
    {
        if (mas3[i] < Max)
        {
            Max = mas3[i];
            ix = i;
        }
    }
    swap = mas3[dlin - 1];
    mas3[dlin - 1] = Max;
    mas3[ix] = swap;
    Max = int.MaxValue;
    dlin--;
}
stopWatch.Stop();
Console.Write("\n\nСортировка выбором");
Console.Write("\nОтсортированный массив: ");
for (int i = 0; i < mas3.Length; i++) Console.Write($"{mas3[i]} ");
Console.Write("\nСкорость выполнения: ");
Console.Write(stopWatch.Elapsed);
stopWatch.Reset();

// Сортировка перемешиванием (шейкерная сортировка).
int[] mas4 = mas;
stopWatch.Start();
for (int i = 0; i < mas4.Length; i++)
{
    for (int j = 0; j < mas4.Length - 1; j++)
    {
        if (mas4[j] > mas4[j + 1])
        {
            swap = mas4[j + 1];
            mas4[j + 1] = mas4[j];
            mas4[j] = swap;
        }
    }

    for (int kon = mas4.Length; kon < 1; kon--)
    {
        if (mas4[kon] > mas4[kon - 1])
        {
            swap = mas4[kon - 1];
            mas4[kon - 1] = mas4[kon];
            mas4[kon] = swap;
        }
    }

}
stopWatch.Stop();
Console.Write("\n\nСортировка перемешиванием (шейкерная сортировка).");
Console.Write("\nОтсортированный массив: ");
for (int i = 0; i < mas4.Length; i++) Console.Write($"{mas4[i]} ");
Console.Write("\nСкорость выполнения: ");
Console.Write(stopWatch.Elapsed);
stopWatch.Reset();

// Сортировка расчёской.
int[] mas5 = mas;
double ras = mas5.Length;
bool rasch = true;
stopWatch.Start();
while (ras > 1 || rasch)
{
    ras /= 1.247330950103979;
    if (ras < 1) ras = 1;
    int i = 0;
    rasch = false;
    while (i + ras < mas5.Length)
    {
        int igap = i + (int)ras;
        if (mas5[i] < mas5[igap])
        {
            swap = mas5[i];
            mas5[i] = mas5[igap];
            mas5[igap] = swap;
            rasch = true;
        }
        i++;
    }
}
stopWatch.Stop();
Console.Write("\n\nСортировка расчёской.");
Console.Write("\nОтсортированный массив: ");
for (int i = 0; i < mas5.Length; i++) Console.Write($"{mas5[i]} ");
Console.Write("\nСкорость выполнения: ");
Console.Write(stopWatch.Elapsed);
stopWatch.Reset();

// Сортировка вставками.
int[] mas6 = mas;
stopWatch.Start();
for ( int i = 1; i < mas6.Length;++i)
{
    int x = mas6[i];
    int j = i;
    while (j > 0 && mas6[j - 1] > x)
    {
        mas6[j] = mas[j - 1]; 
        j--;
    }
    mas6[j] = x;
}
stopWatch.Stop();
Console.Write("\n\nСортировка вставками.");
Console.Write("\nОтсортированный массив: ");
for (int i = 0; i < mas6.Length; i++) Console.Write($"{mas6[i]} ");
Console.Write("\nСкорость выполнения: ");
Console.Write(stopWatch.Elapsed);
stopWatch.Reset();
Console.Write("\n");