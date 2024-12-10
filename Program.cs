using System.Text;

namespace Home_Work_9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = UTF8Encoding.UTF8;

            // Завдання 1 Написати програму, що знаходить другий найбільший елемент масиву.
            var rnd = new Random();

            const int arraysize = 3;
            int[] array = new int[arraysize];

            int maxValue = 0;
            int secondMaxValue = 0;

            for (int i = 0; i < arraysize; i++)
            {
                array[i] = rnd.Next(1, 100);

                if (array[i] > maxValue)
                {
                    secondMaxValue = maxValue;
                    maxValue = array[i];
                }

                if (array[i] > secondMaxValue && array[i] != maxValue)
                {
                    secondMaxValue = array[i];
                }
            }
            Console.WriteLine($"Рандомні числа в масиві {string.Join(",", array)}");
            Console.WriteLine($"Найбільше число {maxValue}, друге найбільше число {secondMaxValue}");



            //Завдання 2 Написати програму, що буде сортувати за зростанням елементи двовимірного масиву.


            int[,] sorting = new int[arraysize, arraysize];

            int sortingValue = 0;

            Console.WriteLine("Невідсортований двовимірний масив: ");

            for (int i = 0; i < arraysize; i++)
            {
                for (int j = 0; j < arraysize; j++)
                {
                    sorting[i, j] = rnd.Next(1, 100);
                    Console.Write($"{sorting[i, j]} ");
                }
                Console.WriteLine();
            }

            //Зробив з двовимірного масиву один масив щоб Array.Sort запрацював бо він приймає тільки одновимірні масиви
            // ми в одновимірному масиві зробили множення arraysize * arraysize тобто 3x3 = 9 у цьому випадку, щоб мав розмів як двовимірний масив
            int[] flatArray = new int[arraysize * arraysize];
            int index = 0;
            for (int i = 0; i < arraysize; i++)
            {
                for (int j = 0; j < arraysize; j++)
                {
                    flatArray[index] = sorting[i, j];
                    index++;
                }
            }

            //Сортування масивів за допомогою Array.Sort
            Array.Sort(flatArray);


            //Тепер відсортований одновимірний масив записуємо у двовимірний
            index = 0;
            Console.WriteLine("Відсортований двовимірний масив: ");
            for (int i = 0; i < arraysize; i++)
            {
                for (int j = 0; j < arraysize; j++)
                {
                    sorting[i, j] = flatArray[index];
                    index++;
                    Console.Write($"{sorting[i, j]} ");
                }
                Console.WriteLine();
            }

            //3 Завдання Написати програму, що буде видаляти з масиву елемент за вказаним індексом.

            int[] deleteElement = new int[arraysize];
            for (int i = 0; i < arraysize; i++)
            {
                deleteElement[i] = rnd.Next(1, 100);

                Console.WriteLine($"{deleteElement[i]} - {i} індекс");
            }
            Console.Write("Виберіть елемент по індексу який ви хочете видалити: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arraysize; i++)
            {
                if (userInput == i)
                {
                    continue;
                }
                Console.WriteLine($"{deleteElement[i]}");
            }

            // 4 Завдання Написати програму, що буде знаходити суму елементів по діагоналі у двовимірному масиві.

            int[,] diagonalSum = new int[arraysize, arraysize];

            int Sum = 0;

            for (int i = 0; i < arraysize; i++)
            {
                for (int j = 0; j < arraysize; j++)
                {
                    diagonalSum[i, j] = rnd.Next(1, 10);
                    Console.Write($"{diagonalSum[i,j]} ");

                }
                Console.WriteLine();
                // По правій діагоналі
                //Sum += diagonalSum[i, arraysize - 1 - i];
                // По лівій діагоналі
                Sum += diagonalSum[i, 0 + i]; // diagonalSum[i, arraysize -3 + i];
            }

            Console.WriteLine($"Результат: {Sum}");


        }
    }
}
