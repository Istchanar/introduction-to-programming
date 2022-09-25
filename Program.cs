// See https://aka.ms/new-console-template for more information
using IntroductionToProgramming;
using System;


var lessonOne = new FirstLesson();
var lessonTwo = new SecondLesson();
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
    } while (parseSuccess != true && (lessonNumber != 1 || lessonNumber != 2));

    return lessonNumber;
}