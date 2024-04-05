class Goldbachs_problem
{
    static bool PrimeNumber(int n)
    {
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Введите четное число больше 2: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 != 0 || number <= 2)
        {
            Console.WriteLine("Введите четное число больше 2.");
        }
        else
        {
            Console.WriteLine($"суммы двух простых чисел для числа {number}:");
            for (int i = 2; i <= number / 2; i++)
            {
                if (PrimeNumber(i) && PrimeNumber(number - i))
                {
                    Console.WriteLine($"{number} = {i} + {number - i}");
                }
            }
        }
    }
}