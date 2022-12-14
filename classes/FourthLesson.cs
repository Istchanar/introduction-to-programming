using System.Text.RegularExpressions;

namespace IntroductionToProgramming
{
    internal class FourthLesson
    {
        public static void TaskInit()
        {
            bool isExpectedNumber;
            int taskNumber;
            Console.ForegroundColor = ConsoleColor.Magenta;

            do
            {
                Console.Write("УРОК 4. Введите номер задания (25, 27, 29): ");
                isExpectedNumber = int.TryParse(Console.ReadLine()!, out int result);
                taskNumber = result;
            }
            while (isExpectedNumber != true || !(taskNumber is (int)TaskNumber.TWENTYFIFTH or (int)TaskNumber.TWENTYSEVENTH or (int)TaskNumber.TWENTYNINTH));

            switch (taskNumber)
            {
                case (int)TaskNumber.TWENTYFIFTH:
                    TwentyfifthTask();
                    break;
                case (int)TaskNumber.TWENTYSEVENTH:
                    TwentyseventhTask();
                    break;
                default:
                    TwentyninthTask();
                    break;
            }
        }

        public static void TwentyfifthTask()
        {
            Console.WriteLine("Задача #25 Введите два числа A и В через запятую для возведения A в степень B: ");

            string twoNumbers;
            bool isTwoNumbers;
            Regex numbersString = new(@"^(\-?\d+[,])(\-?\d+)");
            do
            {
                Console.WriteLine("Введите два числа A и В, через запятую: ");
                twoNumbers = Console.ReadLine()!;
                isTwoNumbers = numbersString.Match(twoNumbers).Success;
            } while (isTwoNumbers != true);

            var numbersAandB = twoNumbers.Split(',').Select(numberInString => int.Parse(numberInString)).ToArray();

            int result = 1;

            // Цикл возведения в степень;
            for (int i = 1; i <= Math.Abs(numbersAandB[1]); i++)
            {
                result *= numbersAandB[0];
            }

            Console.WriteLine($"Результат возведения А в степень В: {result}");
        }

        public static void TwentyseventhTask()
        {
            Console.WriteLine("Задача #27 Введите число, чтобы узнать сумму цифр в числе: ");

            string number;
            bool isNumbers;
            Regex numbersString = new(@"^(\d+)");
            do
            {
                Console.WriteLine("Введите число: ");
                number = Console.ReadLine()!;
                isNumbers = numbersString.Match(number).Success;
            } while (isNumbers != true);

            var numbersInNumber = number.Select(numberInString => int.Parse(numberInString.ToString())).ToArray();
            int result = 0;
            // Цикл возведения в степень;
            for (int i = 0; i <= numbersInNumber.Length - 1; i++)
            {
                result += numbersInNumber[i];
            }

            Console.WriteLine($"Сумма чисел в числе: {result}");
        }

        public static void TwentyninthTask()
        {
            Console.WriteLine("Задача #29 Введите числа через запятую для программного преобразования их в массив и вывод на экран элементов массива: ");

            string numbers;
            bool isNumbers;
            Regex numbersString = new(@"^(?:\-?\d+[, ]*)+$");
            do
            {
                Console.WriteLine("Введите числа через запятую: ");
                numbers = Console.ReadLine()!;
                isNumbers = numbersString.Match(numbers).Success;
            } while (isNumbers != true);

            var numbersArray = numbers.Split(",").Select(numberInString => int.Parse(numberInString.ToString())).ToArray();

            Console.Write($"Результат внутрипрограммной работы: [");
            // Цикл возведения в степень;
            for (int i = 0; i <= numbersArray.Length - 1; i++)
            {
                Console.Write($" {numbersArray[i]}");
            }

            Console.WriteLine($" ]");
        }
    }
}
