// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//Console.WriteLine("Введите число A");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число B");
//int b = Convert.ToInt32(Console.ReadLine());
//int step = a;

//for (int i = 1; i < b; i++)
//{
//step = step * a;
//}
//Console.WriteLine("A в степени B равно: " + step);


// Домашняя работа. Задача 27: Напишите программу, которая принимает на вход число и
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//Console.WriteLine("Введите число");
//int i = Convert.ToInt32(Console.ReadLine());
//int sum = 0;

//while (i > 0)
//{
//int num = i % 10;
//i = i / 10;
//sum = sum + num;
//}
//Console.WriteLine("сумма цифр в числе равна: " + sum);

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

void RandomArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

RandomArray(array);

PrintArray(array);
