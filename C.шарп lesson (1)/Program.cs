namespace ConsoleApp2
{
    class Program
    {
        enum DaysWeek
        {
            Monday = 5, Tuesday = 10, Wednesday, Friday
        }

        static void Main(string[] args)
        {
            DaysWeek day = DaysWeek.Monday;
            Console.WriteLine(day);

            int[] arr = new int[3] { 1, 2, 3 };
            int[,] arr2 = new int[16, 16];
            int[][] arr3 = new int[2][];

            string str = "Hello"; // Строки в C# не изменны.

            arr3[0] = new int[] { 1, 2 };
            arr3[1] = new int[] { 3, 4 };

            Console.WriteLine(arr3[1][0]);

            int sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }

            Console.WriteLine(sum);

        }
    }
}


/*namespace ConsoleApp3
{
    class Program1
    {
        static void Main(string[] args)
        {

            // Random rnd = new Random(); Как сделать рандомные числа.
            // int RandomNum = rnd.Next(1, 10);

            int sum = 0;
            int length = 0;
            string str;
            int[] arr = new int[10] { 111, 222, 315, 412, 555, 642, 771, 848, 931, 1022 };

            foreach (int i in arr)
            {

                int[] arr1 = new int[5] { 111, 315, 555, 771, 931 };
                int[] arr2 = new int[5] { 222, 412, 642, 848, 1022 };

                if (i >= arr[0])
                {
                    sum++;
                    sum = arr[i - 1];

                    Console.WriteLine(sum);
                }

            }

        }
    }
}
*/


/*namespace ConsoleApp4
{
    class Program2
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int RandomNum = rnd.Next(1, 10);
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int[] arr2 = new int[size];

            int Chet = 0, NeChet = 0, unique = 0;

            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(1, 10);
                Console.WriteLine("Элемент массива " + i + " = " + arr[i]);
            }

            foreach ( int i in arr)
            {
                if ( i % 2 == 0)
                {
                    Chet++;
                }
               
                if (i % 2 != 0)
                {
                    NeChet++;
                }
            }
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    unique++;
                }
                count = 0;
            }
            Console.WriteLine("Четные: " + Chet);
            Console.WriteLine("Не четные: " + NeChet);
            Console.WriteLine("Уникальные: " + unique);
        }
    }
}
*/

/*
namespace ConsoleApp5
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");

            //string? str; // Не может быть налом.

            string[] textMass;
            string text = Console.ReadLine();
            textMass = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Количество слов: ");
            Console.WriteLine(textMass.Length);
            Console.ReadLine();

        }
    }
}
*/


namespace ConsoleApp5
{
    class Program2
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int[] arr = new int[10];

            int min, max;

            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(1, 10);
                Console.WriteLine(arr[i]);
            }
            min = arr[0];
            max = arr[0];
            foreach (int i in arr)
            {
                if (min > i)
                {
                    min = i;
                }

                if (max < i)
                {
                    max = i;
                }
            }
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
        }

    }
}