/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите количество чисел: ");
int amountOfTheNumbers = int.Parse(Console.ReadLine());//Преобразует строковое представление числа в 32-битовое целое число //
int count = 0;
for (int i = 0; i < amountOfTheNumbers; i++)
{
    Console.Write($"Введите число: {i + 1} ");
    int userNumber = int.Parse(Console.ReadLine());
    if (userNumber > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество положительных чисел: {count}");