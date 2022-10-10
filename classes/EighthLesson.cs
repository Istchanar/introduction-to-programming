using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IntroductionToProgramming
{
    internal class EighthLesson
    {
        public static void TaskInit()
        {
            bool isExpectedNumber;
            int taskNumber;
            Console.ForegroundColor = ConsoleColor.Magenta;

            do
            {
                Console.Write("УРОК 8. Введите номер задания (54, 56, 58, 60, 62): ");
                isExpectedNumber = int.TryParse(Console.ReadLine()!, out int result);
                taskNumber = result;
            }
            while (isExpectedNumber != true ||
            !(taskNumber is 
            (int)TaskNumber.FIFTYFOURTH or
            (int)TaskNumber.FIFTYSIXTH or 
            (int)TaskNumber.FIFTYEIGHTH or 
            (int)TaskNumber.SIXTIETH or 
            (int)TaskNumber.SIXTYSECOND));

            switch (taskNumber)
            {
                case (int)TaskNumber.FIFTYFOURTH:
                    FiftyFourthTask();
                    break;
                case (int)TaskNumber.FIFTYSIXTH:
                    FiftySixthTask();
                    break;
                case (int)TaskNumber.FIFTYEIGHTH:
                    FiftyEighthTask();
                    break;
                case (int)TaskNumber.SIXTIETH:
                    SixtiethTask();
                    break;
                default:
                    SixtySecondTask();
                    break;
            }
        }
        public static void FiftyFourthTask()
        {
            Console.WriteLine("Задание #54 Программно задаётся двумерный массив размерностью от [3-10] до [3-10] и значениями " +
                "элементов от -99 до 99, в котором элементы каждой строки будут упорядочены по убыванию: ");
            Random random = new();
            int[,] array = GetRectangularArrayWithRandomValues(-99, 99, random.Next(3, 10), random.Next(3, 10));
            // Выводим неотсортированный массив
            PrintRectangularArray(array);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    // К каждой строке как к отдельному массиву применяем сортировку пузырьком;
                    for (int k = 0; k < array.GetLength(1) - 1; k++)
                    {
                        if (array[i, k] > array[i, k + 1])
                        {
                            // Сортировка строки пузырьком
                            int bufferValue = array[i, k];
                            array[i, k] = array[i, k + 1];
                            array[i, k + 1] = bufferValue;
                        }
                    }
                }
            }

            // Выводим отсортированный массив
            PrintRectangularArray(array);
        }
        public static void FiftySixthTask()
        {
            Console.WriteLine("Задание #56 Программно задаётся двумерный массив размера [3-10] на [3-10] со значениями" +
                "от -10 до 10 и выводится номер строки с наименьшей суммой: ");
            Random random = new();
            int[,] array = GetRectangularArrayWithRandomValues(-10, 10, random.Next(3, 10), random.Next(3, 10));
            // Выводим получившийся массив
            PrintRectangularArray(array);
            // Буфер для суммы, полученной в строке + массив сумм каждой строки, длинною равный кол-ву строк массива,
            // в котором суммируем строки
            int sumValuesInString = 0;
            int[] sumArray = new int[array.GetLength(0)];
            int i = 0;
            int j = 0;
            // Цикл по кол-ву строк
            while (i < array.GetLength(0)) {
                // Суммируем значения из строки
                sumValuesInString += array[i, j];
                // Если не достигли правого края, идём вправо по строке
                if (j < array.GetLength(1) - 1)
                {
                    j++;
                }
                // Если достигли правого края, переключаемся на строку ниже и обнуляем индекс строки j и сумму
                else if (j == array.GetLength(1) - 1)
                {
                    sumArray[i] = sumValuesInString;
                    sumValuesInString = 0;
                    j = 0;
                    i++;
                }
            }
            Console.Write("Ряд сумм строк данного массива: ");
            for (int k = 0; k < sumArray.Length; k++)
            {
                Console.Write($"{sumArray[k]} ");
            }
            // Поиск минимального значения в массиве сумм
            int minValue = sumArray[0];
            // Индекс строки с минимальным значением
            int numberOfMinValue = 0;
            for (int l = 0; l < sumArray.Length; l++) {
                if (sumArray[l] < minValue)
                {
                    minValue = sumArray[l];
                    numberOfMinValue = l;
                }
            }
            Console.WriteLine($"\nВ строке {numberOfMinValue} минимальная сумма элементов {minValue}");
        }
        public static void FiftyEighthTask()
        {
            Console.WriteLine("Задание #58 Программно задаются две матрицы А и В размера [3-10] на [3-10]," +
                "при этом кол-во строк матрицы А совпадает с кол-вом столцов матрицы В для корректного умножения," +
                "и заполняются числами в диапазоне от -10 до 10. Результат умножения А х В, матрица С: \n");
            Random random = new();
            int commonSide = random.Next(3, 10);
            int[,] A = GetRectangularArrayWithRandomValues(-10, 10, commonSide, random.Next(3, 10));
            int[,] B = GetRectangularArrayWithRandomValues(-10, 10, random.Next(3, 10), commonSide);

            Console.WriteLine("Матрица А: ");
            PrintRectangularArray(A);
            Console.WriteLine("Матрица B: ");
            PrintRectangularArray(B);

            int[,] C = new int[commonSide, commonSide];

            for (int j = 0; j < A.GetLength(0); j++) {
                for (int f = 0; f < B.GetLength(1); f++)
                {
                    for (int k = 0; k < B.GetLength(0); k++)
                    {
                        C[j, f] += A[j, k] * B[k, f];
                    }

                }
            }

            Console.WriteLine("Матрица C (результат умножения А х В): ");
            PrintRectangularArray(C);
        }
        public static void SixtiethTask()
        {
            Console.WriteLine("Задание #56 Программно задаётся трехмерный массив размера [2-4] на [2-4] на [2-4]" +
                "с неповторяющимися значениями от 10 до 99, с выводом координат элементов массива: ");
            // Незаполненный массив
            Random random = new();
            int[,,] array = new int[random.Next(2, 4), random.Next(2, 4), random.Next(2, 4)];
            int countOfElements = array.GetLength(0) * array.GetLength(1) * array.GetLength(2);
            // Лист с рандомными неповторяющимися значиниями в кол-ве элементов трехмерного массива i*j*k
            // в диапазоне: начинающиеся с 10 (0 элемент), и увеличивающиеся на 1 начиная с 1 элемента до 89 (90 элементов)
            List<int> selectedValues = GetSelectedRandomValuesInRange(10, 90, countOfElements);
            // Индекс элемента в листе
            int valueIndexInList = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = selectedValues[valueIndexInList];
                        valueIndexInList++;
                        Console.Write($"\t {array[i, j, k]}, \t({i}, {j}, {k})");
                    }
                    Console.WriteLine();
                }
            }
        }
        public static void SixtySecondTask()
        {
            Console.WriteLine("Задание #62 Программно задается массив размерностью от [3-10] на [3-10] заполненный по спирали: ");
            Random random = new();
            int[,] array = new int[random.Next(3, 10), random.Next(3, 10)];
            //Значение для массива;
            int value = 1;
            //Индексы массива, начинаем с нулей;
            int i = 0; 
            int j = 0;
            //Верхняя и нижняя сторона;
            int topSide = 0; 
            int buttonSide = 0; 
            //Правая и левая сторона;
            int rigthSide = 0; 
            int leftSide = 0;

            //Нужно уменьшить на 1, чтобы оставаться всегда в пределах индекса массива;
            int stringsCount = array.GetLength(0);
            int columnsCount = array.GetLength(1);

            while (value <= array.GetLength(0)*array.GetLength(1)) {
                array[i,j] = value;
                //Обход квадрата;
                //Если находимся на верхней строке, не достигли правой колонки - идем по строке вправо j++;
                if (i == topSide && j < columnsCount - rigthSide - 1)
                {
                    j++;
                }
                //Если правой колонки, и не достигли нижней строки - идем по столбцу вниз i++;
                else if (j == columnsCount - rigthSide - 1 && i < stringsCount - buttonSide - 1)
                {
                    i++;
                }
                //Если мы достигли низа, и но не достигли левой строноны - идем по строке влево j--;
                else if (i == stringsCount - buttonSide - 1 && j > leftSide)
                {
                    j--;
                }
                //Если достигли левой стороны, и не достигли верха, идем по столбцу наверх i--;
                else if(j == leftSide && i > topSide)
                {
                    i--;
                }

                //Условие выхода во внутренний меньший квадрат;
                //Если достигли второй сверху строки, нужно уйти во внутренний квадрат. 
                if (i == topSide + 1 && j == leftSide) {
                    topSide++; 
                    buttonSide++;
                    rigthSide++;
                    leftSide++;
                }
                value++;
            }

            PrintRectangularArray(array);
        }
        public static void PrintRectangularArray(int[,] array) {
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static int[,] GetRectangularArrayWithRandomValues(int minValue, int maxValue, int stringSize, int columnSize)
        {
            Random random = new();
            int[,] array = new int[stringSize, columnSize];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minValue, maxValue);
                }
            }
            return array;
        }
        public static List<int> GetSelectedRandomValuesInRange(int minRange, int countOfElements, int countOfRandomValues)
        {
            Random random = new();
            // Создаем лист допустимых значений;
            List<int> allowedValues = Enumerable.Range(minRange, countOfElements).ToList();
            List<int> selectedValues = new();
            for (int i = 0; i < countOfRandomValues; i++)
            {
                int index = random.Next(0, allowedValues.Count);
                // Из листа допустымых значений достаём рандомный элемент (по диапазону [0, размер_листа],
                // т.н. принцип перетасовки)
                selectedValues.Add(allowedValues[index]);
                // Удаляем элемент который достали из листа допустимых значений, чтобы элемент не повторился
                allowedValues.RemoveAt(index);
            }
            return selectedValues;
        }
    }
}
