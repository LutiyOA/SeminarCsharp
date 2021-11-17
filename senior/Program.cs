/*
Почувствуй себя сеньором
*/
string[] textZadanii = new string[] {
"31. Задать массив из 8 элементов и вывести их на экран ",
"32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран ",
"33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива",
"34. Написать программу замены элементов массива на противоположные",
"35. Определить, присутствует ли в заданном массиве, некоторое число",
"36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных/четных чисел",
"37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]",
"38. Найти сумму чисел одномерного массива стоящих на нечетной позиции",
"39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.",
"40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом"
};

/*
Общие вспомогательные методы для всех заданий
*/
string printArray(int[] array)
{
    string result = string.Empty;
    foreach (int i in array)
        result += $"{i} ";

    return result;
}

string printArrayZagolovok(string zagolovok, int[] array)
{
    return zagolovok + printArray(array);
}

string printArrayDouble(string Zagolovok, double[] array)
{
    string result = Zagolovok;

    for (int i = 0; i < array.Length; i++)
        result += array[i]+" ";

    return result;
}

int[] setArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }

    return array;
}

double[] setArrayDouble(int length, int max)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * max;
    }

    return array;
}

string printTextZadachi(int z)
{
    return ($"--------------------------------\n\rТекст задания #{textZadanii[z]}");
}

int[] changeArray(int[] array, int koeff)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        result[i] = array[i] * koeff;

    return result;
}

// ----------------- Методы для заданий
// 31. Задать массив из 8 элементов и вывести их на экран 
void Zadanie31()
{
    int[] array = setArray(8, 0, new Random().Next(0, 100));
    Console.WriteLine(printArray(array));
}

void testZadanie31()
{
    Console.WriteLine(printTextZadachi(0));
    Zadanie31();
}

// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
void Zadanie32()
{
    int[] array = setArray(8, 0, 2);
    Console.WriteLine(printArray(array));
}

void testZadanie32()
{
    Console.WriteLine(printTextZadachi(1));
    Zadanie32();
}

// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. 
//     Найти сумму положительных/отрицательных элементов массива",
int[] Zadanie33()
{
    int[] array = setArray(12, -9, 10);
    Console.WriteLine(printArray(array));
    int[] result = new int[2] { 0, 0 };
    foreach (int i in array)
        if (i > 0)
            result[0] += i;
        else
            result[1] += i;

    return result;
}

void testZadanie33()
{
    Console.WriteLine(printTextZadachi(2));
    int[] res = Zadanie33();
    Console.WriteLine($"Сумма положительных значений массива: {res[0]}, отрицательных: {res[1]}");
}

// 34. Написать программу замены элементов массива на противоположные
int[] Zadanie34(int[] array)
{
    return changeArray(array, -1);
}

void testZadanie34()
{
    Console.WriteLine(printTextZadachi(3));

    int[] array = setArray(10, -100, 101);
    Console.WriteLine(printArrayZagolovok("Начальный массив: ", array));

    int[] res = Zadanie34(array);
    Console.WriteLine(printArrayZagolovok("Результирующий массив: ", res));
}

// 35. Определить, присутствует ли в заданном массиве, некоторое число"
bool Zadanie35(int[] array, int searchNumber)
{
    bool result = false;
    foreach (int i in array)
        if (i == searchNumber)
        {
            result = true;
            break;
        }

    return result;
}

void testZadanie35()
{
    Console.WriteLine(printTextZadachi(4));
    int searchNumber = -7;

    int[] array = setArray(10, -10, 11);

    Console.WriteLine(printArrayZagolovok("Начальный массив: ", array));
    Console.WriteLine($"Число {searchNumber} в данном массиве " + (Zadanie35(array, searchNumber) ? "" : "не ") + "присутствует");
}

// 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
//      Показать количество нечетных/четных чисел

int[] Zadanie36(int[] array)
{
    int[] result = new int[2] { 0, 0 };
    foreach (int i in array)
        if (i % 2 == 0) result[0]++;
        else result[1]++;

    return result;
}

void testZadanie36()
{
    Console.WriteLine(printTextZadachi(5));

    int length = 10;
    int[] array = setArray(length, 100, 1000);

    Console.WriteLine(printArrayZagolovok("Начальный массив: ", array));
    int[] res = Zadanie36(array);
    Console.WriteLine($"Количество четных чисел в данном массиве: {res[0]}, нечетных: {res[1]}");
}

// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int Zadanie37(int[] array)
{
    int result = 0;
    foreach (int i in array)
        if (i >= 10 && i <= 99)
            result++;

    return result;
}

void testZadanie37()
{
    Console.WriteLine(printTextZadachi(6));

    int length = 123;
    int[] array = setArray(length, -10, 200);

    Console.WriteLine(printArrayZagolovok("Начальный массив: ", array));

    Console.WriteLine($"Количество чисел в массиве из диапазона [10,99]: {Zadanie37(array)}");
}

// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
int Zadanie38(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i += 2)
        result += array[i];

    return result;
}

void testZadanie38()
{
    Console.WriteLine(printTextZadachi(7));

    int length = 10;
    int[] array = setArray(length, -10, 11);

    Console.WriteLine(printArrayZagolovok("Начальный массив: ", array));

    Console.WriteLine($"Сумма элементов массива, стоящих на нечетной позиции: {Zadanie38(array)}");
}

// 39. Найти произведение пар чисел в одномерном массиве. 
//      Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] Zadanie39(int[] array)
{
    int[] result = new int[array.Length / 2];

    for (int i = 0; i < array.Length / 2; i++)
        result[i] = array[i] * array[array.Length - i - 1];

    return result;
}

void testZadanie39()
{
    Console.WriteLine(printTextZadachi(8));

    int length = 11;
    int[] array = setArray(length, -5, 6);

    Console.WriteLine(printArrayZagolovok("Начальный массив: ", array));
    int[] res = Zadanie39(array);
    Console.WriteLine(printArrayZagolovok("Произведения пар элементов: ", res));
}

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double Zadanie40(double[] array)
{
    double min, max;
    min = max = array[0];
    foreach (double x in array)
    {
        if (x > max) max = x;
        if (x < min) min = x;
    }

    return max - min;
}

void testZadanie40()
{
    Console.WriteLine(printTextZadachi(9));

    int length = 10;
    double[] array = setArrayDouble(length, 5);

    Console.WriteLine(printArrayDouble("Начальный массив: ", array));

    Console.WriteLine($"Разница между max и min элементами: {Zadanie40(array)}");
}

//-----------------------------------------------------------
// Тестирование выполнения заданий

testZadanie31();
testZadanie32();
testZadanie33();
testZadanie34();
testZadanie35();
testZadanie36();
testZadanie37();
testZadanie38();
testZadanie39();
testZadanie40();

