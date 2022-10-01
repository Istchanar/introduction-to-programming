// See https://aka.ms/new-console-template for more information
using IntroductionToProgramming;

int lessonNumber = LessonChoice();
startLessons(lessonNumber);

static void startLessons(int lessonNumber)
{
    int innerLessonNumber = lessonNumber;
    string exitValue;
    do
    {
        if (innerLessonNumber == 1)
        {
            var lessonOne = new FirstLesson();
            lessonOne.TaskInit();
        }

        if (innerLessonNumber == 2)
        {
            SecondLesson.TaskInit();
        }

        if (innerLessonNumber == 3)
        {
            ThirdLesson.TaskInit();
        }

        if (innerLessonNumber == 4)
        {
            FourthLesson.TaskInit();
        }

        if (innerLessonNumber == 5)
        {
            var lessonFive = new FifthLesson();
            lessonFive.TaskInit();
        }

        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("\nДля выхода набрать exit, продолжить - нажать Enter, сменить урок - change:");
        exitValue = Console.ReadLine()!;
        if (exitValue == "change")
        {
            innerLessonNumber = LessonChoice();
        }
    }
    while (exitValue != "exit");
}

static int LessonChoice()
{
    int lessonNumber;
    bool parseSuccess;
    Console.ForegroundColor = ConsoleColor.Green;
    do
    {
        Console.Write("Введите номер урока (1, 2, 3, 4, 5): ");
        parseSuccess = int.TryParse(Console.ReadLine()!, out int number);
        lessonNumber = number;
    } while (parseSuccess != true && (lessonNumber != 1 || lessonNumber != 2 || lessonNumber != 3 || lessonNumber != 4 || lessonNumber != 5));

    return lessonNumber;
}