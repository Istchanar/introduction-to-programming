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
        Console.ForegroundColor = ConsoleColor.Yellow;

        switch (innerLessonNumber)
        {
            case 1:
                var lessonOne = new FirstLesson();
                lessonOne.TaskInit();
                break;
            case 2:
                SecondLesson.TaskInit();
                break;
            case 3:
                ThirdLesson.TaskInit();
                break;
            case 4:
                FourthLesson.TaskInit();
                break;
            case 5:
                var lessonFive = new FifthLesson();
                lessonFive.TaskInit();
                break;
            case 6:
                SixthLesson.TaskInit();
                break;
            case 7:
                SeventhLesson.TaskInit();
                break;
            case 8:
                EighthLesson.TaskInit();
                break;
            case 9:
                NinthLesson.TaskInit();
                break;
            default:
                Console.WriteLine("Такого урока нет.");
                break;

        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nДля выхода набрать exit, для смены урока набрать change, продолжить - нажать Enter:");
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
        Console.Write("Введите номер урока (1, 2, 3, 4, 5, 6, 7, 8, 9): ");
        parseSuccess = int.TryParse(Console.ReadLine()!, out int number);
        lessonNumber = number;
    } while (parseSuccess != true);

    return lessonNumber;
}
