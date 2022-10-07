namespace IntroductionToProgramming
{
    internal class FifthLesson
    {
        private readonly Random random = new();
        public void TaskInit()
        {
            bool isExpectedNumber;
            int taskNumber;
            Console.ForegroundColor = ConsoleColor.Magenta;

            do
            {
                Console.Write("УРОК 5. Введите номер задания (34, 36, 38): ");
                isExpectedNumber = int.TryParse(Console.ReadLine()!, out int result);
                taskNumber = result;
            }
            while (isExpectedNumber != true || !(taskNumber is (int)TaskNumber.THIRTYFOURTH or (int)TaskNumber.THIRTYSIXTH or (int)TaskNumber.THIRTYEIGHTH));

            switch (taskNumber)
            {
                case (int)TaskNumber.THIRTYFOURTH:
                    ThirtyfourthTask();
                    break;
                case (int)TaskNumber.THIRTYSIXTH:
                    ThirtysixthTask();
                    break;
                default:
                    ThirtyeighthTask();
                    break;
            }
        }

        public void ThirtyfourthTask()
        {
            Console.WriteLine("Задача #34 : Программно задаётся массив размерностью от 3 до 10 заполненный положительными трёхзначными числами, " +
                "\nкол-во чётных чисел в массиве: ");
            var array = ArrayWithRandomInts(100, 999);

            int countOfEvenNumbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                countOfEvenNumbers = array[i] % 2 == 0 ? countOfEvenNumbers + 1 : countOfEvenNumbers;
            }
            Console.WriteLine($"\n{countOfEvenNumbers}");
        }

        public void ThirtysixthTask()
        {
            Console.WriteLine("Задача #36 : Программно задаётся массив размерностью от 3 до 10 заполненный случайными числами " +
                "\nот -100 до 100, сумма элементов на нечётных позициях: ");

            var array = ArrayWithRandomInts(-100, 100);

            int sumOfOddNumbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sumOfOddNumbers = i % 2 != 0 ? sumOfOddNumbers + array[i] : sumOfOddNumbers;
            }

            Console.WriteLine($"\n{sumOfOddNumbers}");
        }

        public void ThirtyeighthTask()
        {
            Console.WriteLine("Задача #38 : Программно задаётся массив размерностью от 3 до 10 заполненный случайными вещественными " +
                "\nчислами от -100 до 100, разница между максимальным и минимальным элементов массива: ");

            var array = ArrayWithRandomDoubles(-100, 100);


            double max = array[0];
            double min = max;
            for (int i = 0; i < array.Length; i++)
            {
                max = array[i] > max ? array[i] : max;
                min = array[i] < min ? array[i] : min;
            }

            double difference = Math.Round(max - min, 3);
            Console.WriteLine($"\nMAX {max} MIN {min}");
            Console.WriteLine($"\n{difference}");
        }

        public int[] ArrayWithRandomInts(int minValue, int maxValue)
        {
            var array = new int[this.random.Next(3, 10)];
            Console.Write($"\n[");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = this.random.Next(minValue, maxValue);
                Console.Write($" {array[i]}");
            }
            Console.Write($" ]\n");

            return array;
        }

        public double[] ArrayWithRandomDoubles(int minValue, int maxValue)
        {
            var array = new double[this.random.Next(3, 10)];
            Console.Write($"\n[");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Round(random.NextDouble() * (maxValue - minValue) + (minValue), 3);
                Console.Write($" {array[i]}");
            }
            Console.Write($" ]\n");

            return array;
        }
    }
}
