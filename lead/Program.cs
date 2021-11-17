/*
Почувствуй себя лидом
*/
string[] textZadanii = new string[] {
"41. Выяснить являются ли три числа сторонами треугольника ",
"42. Определить сколько чисел больше 0 введено с клавиатуры",
"43. Написать программу преобразования десятичного числа в двоичное",
"44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы",
"45. Показать числа Фибоначчи",
"46. Написать программу масштабирования фигуры",
"47. Написать программу копирования массива"
};

// Метод считывает число с клавиатуры. Признак завершения ввода - если вводится слово "конец"
(bool, int) ReadNumber()
{
    string s = Console.ReadLine()!;
    if (s.ToLower() == "конец")
        return (false, 0);
    else
        return (true, int.Parse(s));
}

// "41. Выяснить являются ли три числа сторонами треугольника ",
bool Zadanie41(double l1, double l2, double l3)
{
    return ((l1 + l2) > l3) && ((l1 + l3) > l2) && ((l2 + l3) > l1);
}

void testZadanie41()
{
    double l1 = 8, l2 = 16, l3 = 8;
    string proverka = Zadanie41(l1, l2, l3) ? "являются" : "не являются";
    Console.WriteLine($"Числа {l1}, {l2} и {l3} " + proverka + " треугольником");
}

// "42. Определить сколько чисел больше 0 введено с клавиатуры"
int Zadanie42()
{
    (bool, int) a = (true, 0);
    int result = 0;
    while ((a = ReadNumber()).Item1 == true)
    {
        if (a.Item2 > 0)
            result++;
    }
    return result;
}

void testZadanie42()
{
    Console.WriteLine("Введите числа: ");
    Console.WriteLine($"Введено {Zadanie42()} числа больше 0");
}

// "43. Написать программу преобразования десятичного числа в двоичное"

// метод переводит одну десятичную цифру в заданную систему (не больше 16-тиричной !) 
string perevodDigit(int digit, int sistema)
{
    string result = string.Empty;
    if (sistema <= 10 || digit < 10)
        return "" + digit;
    else
    {
        switch (digit)
        {
            case 10: result = "A"; break;
            case 11: result = "B"; break;
            case 12: result = "C"; break;
            case 13: result = "D"; break;
            case 14: result = "E"; break;
            case 15: result = "F"; break;
        }
    }
    return result;
}

string Zadanie43(int num, int sistema)
{
    int number = num;
    string result = string.Empty;
    while (number != 0)
    {
        int digit = number % sistema;
        result = perevodDigit(digit, sistema) + result;
        number /= sistema;
    }
    return result;
}

void testZadanie43()
{
    int number = 255,
        sistema = 16; // Система не должна быть больше 16
    Console.WriteLine($"Число {number} в десятичной системе = {Zadanie43(number, sistema)} в {sistema}-ой системе");
}

// "44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы"
// возвращает  
// (false-если прямые параллельны, 0,0) 
// либо (true-прямые пересекаются, x- пересечение, y-пересечение)
(bool, double, double) Zadanie44((double k, double b) line1, (double k, double b) line2)
{
    if (line1.k + line2.k == 0)
        return (false, 0, 0);

    double x = (line2.b - line1.b) / (line1.k + line2.k);

    return (true, x, line1.k * x + line1.b);
}

void testZadanie44()
{
    double k1 = 1.1;
    double b1 = 0;

    double k2 = -1.1;
    double b2 = -5;
    (bool, double, double) result = Zadanie44((k1, b1), (k2, b2));

    Console.WriteLine($"Заданы уравнения: y={k1}*x+{b1} и y={k2}*x+{b2}");
    if (result.Item1)
        Console.WriteLine($"Точка пересечения = ({result.Item2}, {result.Item3})");
    else
        Console.WriteLine("Прямые параллельны");
}

testZadanie41();
testZadanie42();
testZadanie43();
testZadanie44();