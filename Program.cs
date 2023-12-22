// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 


using System;



class Program

{
    static void Main(string[] args)

    {

        int m, n;

        Console.Write("Введите значение m: ");

        m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");

        n = int.Parse(Console.ReadLine());



        int result = Ackermann(m, n);

    static int Ackermann(int m, int n)

    {

        if (m == 0)

        {

            return n + 1;

        }

        else if (m > 0 && n == 0)


        {

            return Ackermann(m - 1, 1);

        }

        else

        {

            return Ackermann(m - 1, Ackermann(m, n - 1));

        }

    }

        Console.WriteLine("Значение функции Аккермана для m={0} и n={1}: {2}", m, n, result);
        Console.ReadLine();

    }

}















