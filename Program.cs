// See https://aka.ms/new-console-template for more information
using IntroductionToProgramming;
using System;
using System.Text.RegularExpressions;

var lessonOne = new FirstLesson();
var lessonTwo = new SecondLesson();
var lessonThree = new ThirdLesson();
var lessonFour = new FourthLesson();
int lessonNumber = LessonChoice();
string exitValue;

do
{
    if (lessonNumber == 1)
    {
        lessonOne.TaskInit();
    }
    else if (lessonNumber == 2)
    {
        lessonTwo.TaskInit();
    }
    else if (lessonNumber == 3)
    {
        lessonThree.TaskInit();
    }
    else if (lessonNumber == 4)
    {
        lessonFour.TaskInit();
    }

    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine("\nДля выхода набрать exit, продолжить - нажать Enter");
    exitValue = Console.ReadLine()!;
}
while (exitValue != "exit");

static int LessonChoice() {
    int lessonNumber;
    bool parseSuccess;
    do
    {
        Console.Write("Введите номер урока: ");
        parseSuccess = int.TryParse(Console.ReadLine()!, out int number);
        lessonNumber = number;
    } while (parseSuccess != true && (lessonNumber != 1 || lessonNumber != 2 || lessonNumber != 3 || lessonNumber != 4));

    return lessonNumber;
}