/*
Почувствуй себя джуном
15. Дано число. Проверить кратно ли оно 7 и 23
16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
17. По двум заданным числам проверять является ли одно квадратом другого
18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
20. Задать номер четверти, показать диапазоны для возможных координат
21. Программа проверяет пятизначное число на палиндромом.
22. Найти расстояние между точками в пространстве 2D/3D

Вот задача: 
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять 
площадь круга по радиусу и треугольника по трем сторонам. 
Дополнительно к работоспособности оценим:
  Юнит-тесты
  Легкость добавления других фигур
  Вычисление площади фигуры без знания типа фигуры в compile-time
  Проверку на то, является ли треугольник прямоугольным

---------------------------------------------------------------------------------
*/

// 15. Дано число. Проверить кратно ли оно 7 и 23
bool Zadanie15(int number)
{
    return (number % 7 == 0 && number % 23 == 0);
}

// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
// true - выходной, false - рабочий
bool Zadanie16(int day)
{
    return day == 6 || day == 7;
}

// 17. По двум заданным числам проверять является ли одно квадратом другого
bool Zadanie17(int num1, int num2)
{
    return (num1 * num1 == num2 || num2 * num2 == num1);
}

// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool Zadanie18(bool x, bool y)
{
    return (!(x || y) == (!x && !y));
}

//19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
int Zadanie19(int x, int y)
{
    /*
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    return 4;
    */

    return (x > 0 && y > 0) ? 1 : ((x < 0 && y > 0) ? 2 : ((x < 0 && y < 0) ? 3 : 4));
}

// 20. Задать номер четверти, показать диапазоны для возможных координат
string[] Zadanie20(int chetvert)
{
    if (chetvert == 1) return new string[2] { "x = (0, +бесконечность)", "y = (0, +бесконечность)" };
    if (chetvert == 2) return new string[2] { "x = (-бесконечность, 0)", "y = (0, +бесконечность)" };
    if (chetvert == 3) return new string[2] { "x = (-бесконечность, 0)", "y = (-бесконечность, 0)" };
    if (chetvert == 4) return new string[2] { "x = (0, +бесконечность)", "y = (-бесконечность, 0)" };

    return new string[2] { "номер четверти задан некорректно", "номер четверти задан некорректно" };
}

// 21. Программа проверяет пятизначное число на палиндромом.
bool Zadanie21(int number)
{
    return 
    // сравниваем 1-ю цифру с 5-й
    (number / 10000 == number % 10) 
    && 
    // сравниваем 2-ю цифру с 4-й
    ((number / 1000) % 10 == (number / 10) % 10);
}

// 22. Найти расстояние между точками в пространстве 2D/3D
double Zadanie22(double[] t1, double[] t2)
{
    return Math.Sqrt(Math.Pow(t2[0] - t1[0], 2) + Math.Pow(t2[1] - t1[1], 2) + Math.Pow(t2[2] - t1[2], 2));
}

//------------------------------------------------------------
// проверка задания #15
int number = 7 * 23 + 1;
Console.WriteLine($"Число {number} делится на 7 и 23: {Zadanie15(number)}");

//------------------------------------------------------------
// проверка задания #16
int day = 5;
Console.WriteLine($"День недели: {day} является {(Zadanie16(day) ? "выходным" : "рабочим")}");

//------------------------------------------------------------
// проверка задания #17
int num1 = 5;
int num2 = 25;
Console.WriteLine($"Одно из чисел {num1} или {num2} являются квадратом второго: {Zadanie17(num1, num2)}");

//------------------------------------------------------------
// проверка задания #18
Console.WriteLine($"Результат истинности утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y: {Zadanie18(true, true) && Zadanie18(true, false) && Zadanie18(false, true) && Zadanie18(false, false)}");

//------------------------------------------------------------
// проверка задания #19
int x = -5, y = -4;
Console.WriteLine($"Номер четверти для x={x}, y={y} : {Zadanie19(x, y)}");

//------------------------------------------------------------
// проверка задания #20
int chetvert = 3;
string[] result20 = Zadanie20(chetvert);
Console.WriteLine($"Для четверти: {chetvert} диапазон {result20[0]} и {result20[1]}");

//------------------------------------------------------------
// проверка задания #21
int number21 = 12322;
Console.WriteLine($"Число {number21} является палиндромом: {Zadanie21(number21)}");

//------------------------------------------------------------
// проверка задания #22
double[] t1 = new double[] { 1.0, 1.0, 1.0 };
double[] t2 = new double[] { 2.0, 2.0, 2.0 };
Console.WriteLine($"Расстояние между точкой ({t1[0]},{t1[1]},{t1[2]}) - ({t2[0]},{t2[1]},{t2[2]}) = {Zadanie22(t1, t2)}");
