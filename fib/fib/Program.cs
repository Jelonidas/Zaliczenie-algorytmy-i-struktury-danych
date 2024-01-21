using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Fib(4)); // Powinno zwrócić 3
    }

    static int Fib(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }

        int[] fibSeries = new int[n + 1];
        fibSeries[0] = 0;
        fibSeries[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            fibSeries[i] = fibSeries[i - 1] + fibSeries[i - 2];
        }

        return fibSeries[n];
    }
}