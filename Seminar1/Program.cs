//Домашняя работа
Console.Clear();

//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

//Решение
/*
Console.Write("Imput furst number (Введите первое число) ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput Second number (Введите второе число) ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"max {num1} min {num2}");
}
else
{
    Console.WriteLine($"max {num2} min {num1}");
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//Решение
/*
Console.Write("Imput furst number (Введите первое число) ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput Second number (Введите второе число) ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput Second number (Введите второе число) ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (num2>max)
{
    max=num2;
}
else {}
if (num3>max)
{
    max=num3;
}
else {}
 Console.WriteLine($"max {max}");
 */

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

//Решение
/*
Console.Write("Imput number (Введите число) ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1%2 == 0)

{
Console.WriteLine("да");
}
else 
{
Console.WriteLine("нет");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

//решение
/*
Console.Write("Imput number (Введите число) ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;

for (current = 1; current <= number; current++)
    if (current % 2 == 0)
        Console.Write(current + " ");
*/
