using System.Text.RegularExpressions;

namespace IntroductionToProgramming
{
    internal class SixthLesson
    {
        public static void TaskInit()
        {
            bool isExpectedNumber;
            int taskNumber;
            Console.ForegroundColor = ConsoleColor.Magenta;

            do
            {
                Console.Write("УРОК 6. Введите номер задания (41, 43): ");
                isExpectedNumber = int.TryParse(Console.ReadLine()!, out int result);
                taskNumber = result;
            }
            while (isExpectedNumber != true || !(taskNumber is (int)TaskNumber.FORTYFIRST or (int)TaskNumber.FORTYTHIRD));

            switch (taskNumber)
            {
                case (int)TaskNumber.FORTYFIRST:
                    FortyFirstTask();
                    break;
                default:
                    FortyThirdTask();
                    break;
            }
        }

        public static void FortyFirstTask()
        {
            Console.WriteLine($"Задача #41 Введите ряд числе через запятую для получения кол-ва чисел больше 0: ");
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

            int countGreaterThanZero = 0;

            for (int i = 0; i <= numbersArray.Length - 1; i++)
            {
                countGreaterThanZero = numbersArray[i] > 0 ? countGreaterThanZero + 1 : countGreaterThanZero;
            }

            Console.WriteLine($"\n{countGreaterThanZero} чисел/ла больше нуля.");
        }

        public static void FortyThirdTask()
        {

            Console.WriteLine($"Задача #43 Введите значения k1,b1 и k2,b2 через запятую для уравнений прямых " +
                $"\ny = k1 * x + b1, y = k2 * x + b2 и поиска точек пересечения: ");

            var numbersFirstLine = ArrayOfParametersKandB("Введите значения k1,b1 через запятую: ");
            var numbersSecondLine = ArrayOfParametersKandB("Введите значения k2,b2 через запятую: ");


            double[,] coefficients = new double[2, 2];

            //Так как подмассивы равны между собой, GetLength можно брать по любому индексу.
            for (int i = 0; i < coefficients.GetLength(0); i++)
            {
                coefficients[0, i] = numbersFirstLine[i];
                coefficients[1, i] = numbersSecondLine[i];
            }

            if (coefficients[0, 0] == coefficients[1, 0] && coefficients[0, 1] != coefficients[1, 1])
            {
                Console.WriteLine($"Параметр k1 равен k2. Прямые параллельны, общих точек не существует.");
            }
            else if (coefficients[0, 0] == coefficients[1, 0] && coefficients[0, 1] == coefficients[1, 1])
            {
                Console.WriteLine($"Параметры k1 равен k2, b1 равен b2. Прямые идентичны, общих точек бесконечно много.");
            }
            else
            {
                //Формулы для вывода x и y
                double x = (coefficients[1, 1] - coefficients[0, 1]) / (coefficients[0, 0] - coefficients[1, 0]);
                double y = coefficients[0, 0] * x + coefficients[0, 1];
                Console.WriteLine($"Координаты точки пересечения (x: {x}, y: {y})");
            }
        }

        public static int[] ArrayOfParametersKandB(string text)
        {
            string coefficients;
            bool isTwoNumbers;
            Regex numbersString = new(@"^(\-?\d+[,])(\-?\d+)");

            do
            {
                Console.WriteLine($"{text}");
                coefficients = Console.ReadLine()!;
                isTwoNumbers = numbersString.Match(coefficients).Success;
            } while (isTwoNumbers != true);

            return coefficients.Split(',').Select(numberInString => int.Parse(numberInString)).ToArray();
        }
    }
}

