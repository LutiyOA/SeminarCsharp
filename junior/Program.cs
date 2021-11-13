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
РАЗБОР 18-й ЗАДАЧИ от С. КАМЯНЕЦКОГО
// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// x  y 
// f  f
// f  t
// t  f
// t  t

// bool 
// x = false , y = false;
// Console.WriteLine(!(x || y) == (!x && !y));
// x = false; y = true;
// Console.WriteLine(!(x || y) == (!x && !y));
// x = true; y = false;
// Console.WriteLine(!(x || y) == (!x && !y));
// x = true; y = true;
// Console.WriteLine(!(x || y) == (!x && !y));

bool f(bool arg1, bool arg2)
{
    return !(arg1 || arg2) == (!arg1 && !arg2);
}

// bool 
// x = false , y = false;
// Console.WriteLine(f(x, y));
// x = false; y = true;
// Console.WriteLine(f(x, y));
// x = true; y = false;
// Console.WriteLine(f(x, y));
// x = true; y = true;
// Console.WriteLine(f(x, y));

// bool 
// x = false , y = false;
// bool res = f(x, y);

// x = false; y = true;
// res =res && f(x, y);
// x = true; y = false;
// res =res && f(x, y);
// x = true; y = true;
// res =res && f(x, y);
// System.Console.WriteLine(res);

bool ConvertIntToBool(int arg)
{
    return arg == 1;
}
// bool res = true;
// for (int i = 0; i <= 1; i++)
// {
//     for (int j = 0; j <= 1; j++)
//     {
//         res = res && f(ConvertIntToBool(i), ConvertIntToBool(j));
//     }
// }
//System.Console.WriteLine(res);

bool Table()
{
    bool res = true;
    for (int i = 0; i <= 1; i++)
    {
        for (int j = 0; j <= 1; j++)
        {
            res = res && f(Convert.ToBoolean(i), ConvertIntToBool(j));
        }
    }
    return res;
}

Console.WriteLine(Table());


*/

// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
bool Zadanie16(int day)
{
    return day == 6 || day == 7;
}


//Console.WriteLine($"{(Zadanie16(7) ? "выходной" : "рабочий")}");

//19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int Zadanie19(int x, int y)
{
    /*
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    return 4;
    */

    int a = (5==5) ? 4 : 6;
    Console.WriteLine(a);

    return (x > 0 && y > 0) ? 1 : ( (x < 0 && y > 0) ? 2 : ((x < 0 && y < 0) ? 3 :4 ) ); 
}    

int x = 5, y = -4;
Console.WriteLine($"Номер четверти для x={x}, y={y} : {Zadanie19(x, y)}");
