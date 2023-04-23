using System;
using static System.Net.Mime.MediaTypeNames;

class MainClass
{
    public static void Main(string[] args)
    {
        int[,] array = { { -5, 6, 999, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
        int sum = 0;
        for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
        {
            for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
            {
                if (array[i, k] > 0) sum++;
            }
        }
        Console.Write($"sum = {sum}");

        //int[][] array = new int[3][];
        //array[0] = new int[2] { 1, 2 };
        //array[1] = new int[3] { 7, 82, 31 };
        //array[2] = new int[5] { 11, 2, 33, 24, 5 };

        //foreach (var num in array)
        //{
        //    foreach (var item in num)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();
        //}

        //int[] arr = { 5, 6, 999, 1, 2, 3, 4 };
        //int sum = 0;
        //foreach (int i in arr)
        //{
        //    sum += i;
        //}
        //Console.Write($"Sum = {sum}");


        //Console.WriteLine("Дай имя");
        //string YourName = Console.ReadLine();
        //Console.Write("По буквам в обратном порядке: ");
        //for (int i = YourName.Length-1; i >= 0; i--)
        //{
        //    Console.Write($"{YourName[i]} ");
        //}

        //Console.WriteLine("Дай имя");
        //string YourName = Console.ReadLine();
        //Console.Write("По буквам:");
        //foreach (var s in YourName)
        //{
        //    Console.Write($" {s}");
        //}
        //Console.Write($". Последняя буква - {YourName[YourName.Length - 1]}");

        //Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

        //int i = 1;

        //while (true)
        //{
        //    var text = (Console.ReadLine());
        //    if (text == "stop")
        //    {
        //        Console.WriteLine("Цикл остановлен");
        //        break;
        //    }
        //    switch (text)
        //    {
        //        case "red":
        //            Console.BackgroundColor = ConsoleColor.Red;
        //            Console.ForegroundColor = ConsoleColor.Black;
        //            Console.WriteLine("Your color is red!");
        //            break;

        //        case "green":
        //            Console.BackgroundColor = ConsoleColor.Green;
        //            Console.ForegroundColor = ConsoleColor.Black;
        //            Console.WriteLine("Your color is green!");
        //            break;

        //        case "cyan":
        //            Console.BackgroundColor = ConsoleColor.Cyan;
        //            Console.ForegroundColor = ConsoleColor.Black;
        //            Console.WriteLine("Your color is cyan!");
        //            break;

        //        default:
        //            Console.BackgroundColor = ConsoleColor.Yellow;
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("Your color is not in our catalogue!");
        //            break;
        //    }

        //}

        Console.ReadKey();
    }
}