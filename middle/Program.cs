/*
Семинар 11/11/2021

Почувствуй себя мидлом
23. Показать таблицу квадратов чисел от 1 до N 
24. Найти кубы чисел от 1 до N
25. Найти сумму чисел от 1 до А
26. Возведите число А в натуральную степень B используя цикл
27. Определить количество цифр в числе
28. Подсчитать сумму цифр в числе
29. Написать программу вычисления произведения чисел от 1 до N
30. Показать кубы чисел, заканчивающихся на четную цифру

*/

// 23. Показать таблицу квадратов чисел от 1 до N 
int f(int n, int stepen)
{
    return (int)Math.Pow(n, stepen);
}

string Zadanie23(int n)
{
    string result = String.Empty;
    for (int i = 1; i <= n; i++)
    {
        result += $"{f(i, 2)} ";
    }
    return result;
}

void unitTestZadanie23()
{
    int n = 10;
    Console.WriteLine(Zadanie23(n));
}

// 24. Найти кубы чисел от 1 до N
string Zadanie24(int n)
{
    string result = String.Empty;

    for (int i = 1; i <= n; i++)
        result += $"{f(i, 3)} ";

    return result;
}


void unitTestZadanie24()
{
    int n = 10;
    Console.WriteLine(Zadanie24(n));
}

// 25. Найти сумму чисел от 1 до А
(int, int) Zadanie25(int a)
{

    // result1 - Классичесский подсчет через цикл
    int result1 = 0;
    for (int i = 1; i <= a; i++)
        result1 += i;

    // result2 - через формулу арифметической прогрессии с коэффициентом 1
    // sum=(A1+An)*n/2;
    int result2 = (1 + a) * a / 2;

    // возвращаем через кортеж, чтобы убедиться, что оба результата совпадают
    return (result1, result2);
}

void unitTestZadanie25()
{
    int a = 100;
    (int, int) res = Zadanie25(a);
    Console.WriteLine($"Для A={a}: res1={res.Item1}, res2={res.Item2}");
}

// 26. Возведите число А в натуральную степень B используя цикл
int Zadanie26(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
        result *= a;

    return result;
}

void unitTestZadanie26()
{
    int a = -3,
        b = 5;

    Console.WriteLine($"Для A = {a}, B = {b} Результат ({a})^{b} = {Zadanie26(a, b)}");
}

// 27. Определить количество цифр в числе
int[] schetCifr(int n)
{
    int[] result = new int[10];
    int k = Math.Abs(n);
    while (k != 0)
    {
        int i = k % 10;
        result[i]++;
        k /= 10;
    }

    return result;
}

(int kol, int unic) Zadanie27(int n)
{
    int[] cifry = schetCifr(n);
    int kolResult = 0;
    int unicResult = 0;

    // через foreach

    foreach (int num in cifry)
    {
        kolResult += num;
        if (num != 0)
            unicResult++;
    }


    // через for
    /*
    for (int i = 0; i < cifry.Length; i++)
    {
        kolResult += cifry[i];
        if (cifry[i] != 0)
            unicResult++;
    }
    */

    return (kolResult, unicResult);
}

void unitTestZadanie27()
{
    int n = -4506080;
    (int, int) result = Zadanie27(n);
    Console.WriteLine($"Число: {n}    Количество цифр: {result.Item1} Количество уникальных цифр: {result.Item2}");
}

// 28. Подсчитать сумму цифр в числе
int Zadanie28(int n)
{
    int[] cifry = schetCifr(n);
    int sum = 0;

    for (int i = 0; i < cifry.Length; i++)
        sum += i * cifry[i];

    return sum;
}

void unitTestZadanie28()
{
    int n = -456550;

    Console.WriteLine($"Число: {n}    Сумма цифр: {Zadanie28(n)}");
}

// 29. Написать программу вычисления произведения чисел от 1 до N
ulong factorial(uint n)
{
    if (n <= 0) return 1;

    return n * factorial(n - 1);
}

ulong Zadanie29(uint n)
{
    ulong result = 1;
    for (uint i = 2; i <= n; i++)
        result *= i;

    return result;

}

void unitTestZadanie29()
{
    Console.Write("Введите n: ");
    uint n = uint.Parse(Console.ReadLine()!);

    Console.WriteLine($"Произведение чисел от 1 до {n} = {Zadanie29(n)}   Через рекурсию = {factorial(n)}");
}

// 30. Показать кубы чисел, заканчивающихся на четную цифру
// решил сделать от -n до n и условие как относящееся к вычисляемым кубам, а не просто к числам
string Zadanie30(int n)
{
    string result = string.Empty;
    for (int i = -n; i <= n; i++)
    {
        int k = (int)Math.Pow(i, 3);
        if (k % 2 == 0)
            result += $"{i}: {k}\n\r";
    }
    return result;
}



void unitTestZadanie30()
{
    int n;
    do
    {
        Console.Write("Введите n( >=0 ): ");
        n = int.Parse(Console.ReadLine()!);
    } while (n < 0);
    Console.WriteLine(Zadanie30(n));
}

// ----------------------------
// unitTestZadanie23();
// unitTestZadanie24();
// unitTestZadanie25();
// unitTestZadanie26();
// unitTestZadanie27();
// unitTestZadanie28();
// unitTestZadanie29();
unitTestZadanie30();

