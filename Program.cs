// See https://aka.ms/new-console-template for more information
using IntroductionToProgramming;
using System;


var lessonOne = new FirstLesson();

Console.Write("Введите номер урока: ");
int lessonNumber = Int32.Parse(Console.ReadLine()!);

string exitValue;

do
{
    lessonOne.TaskInit();

    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine("\nДля выхода набрать exit, продолжить - нажать Enter");
    exitValue = Console.ReadLine()!;
}
while (exitValue != "exit");


/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

Console.WriteLine("Задача #10 Введите трёхзначное число для получения цифры во втором разряде: ");

int numberScope;
bool lengthСheck;


do {
    Console.WriteLine("Введите трёхзначное число: ");
    lengthСheck = int.TryParse(Console.ReadLine()!, out int number);
    numberScope = number;
}
while (numberScope < 100 || numberScope > 999 || lengthСheck != true);
Console.WriteLine($"Второе число в трёхзначной цифре: {(numberScope / 10) % 10}");


Console.WriteLine("Задача #13 Введите число для получения цифры в третьем разряде: ");

do
{
    Console.WriteLine("Введите число: ");
    lengthСheck = int.TryParse(Console.ReadLine()!, out int number);
    numberScope = number;
    if (numberScope > 100) {
        Console.WriteLine($"Третье число в цифре: {(numberScope / 100) % 10}");
    }
    else if(numberScope < 100 && numberScope > -100)
    {
        Console.WriteLine($"Третьего числа нет");
    }
}
while (lengthСheck != true);
*/
