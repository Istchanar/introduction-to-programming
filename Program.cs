// See https://aka.ms/new-console-template for more information
using IntroductionToProgramming;
using System;

/*
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

*/
Console.WriteLine("Задача #15 Введите номер дня недели, для проверки является ли день выходным");
string number;
bool stringСheck;
int nums;
do
{
    Console.WriteLine("Введите номер дня недели: ");
    number = Console.ReadLine()!;
    stringСheck = int.TryParse(number, out int num);
    nums = num;
    if (nums >= 1 && nums <= 7) {
        Console.WriteLine((nums == 6 || nums == 7) ? "Выходной" : "Будний" );
    }
} while (true || nums < 1 || nums > 7);
/*

Console.WriteLine("Задача #10 Введите трёхзначное число для получения цифры во втором разряде: ");

int numberScope;
bool stringСheck;
string number;

do
{
    Console.WriteLine("Введите трёхзначное число: ");
    number = Console.ReadLine()!;
    stringСheck = int.TryParse(number, out int num);
    numberScope = num;
}
while (stringСheck != true || number.Length != (numberScope < 0 ? 4 : 3));
Console.WriteLine($"Второе число в трёхзначной цифре: {(Math.Abs(numberScope) / 10) % 10}");
*/


/*
Console.WriteLine("Задача #13 Введите число для получения цифры в третьем разряде (max/min - long): ");

string stringNumber;
bool stringСheck;
long numberFromString;
int stringLength;

do
{
    Console.WriteLine("Введите число: ");
    stringNumber = Console.ReadLine()!;
    stringLength = stringNumber.Length;
    stringСheck = long.TryParse(stringNumber, out long numberValue);
    numberFromString = numberValue;
    int strs;
    strs = numberFromString < 0 ? stringLength - 1 : stringLength;
    
    long digit = 1;

    for (int i = 0; i < strs - 3; i++) {
        digit *= 10;
    }

    if (numberValue > 99 || numberValue < -99) {
        Console.WriteLine($"Третье число в цифре: {Math.Abs((numberValue / digit) % 10)}");
    }
    else if(stringСheck == true)
    {
        Console.WriteLine($"Третьего числа нет");
    }
}
while (true || stringLength > (numberFromString < 0 ? 20 : 19) || (numberFromString == 0 && (stringLength > 19)));
*/