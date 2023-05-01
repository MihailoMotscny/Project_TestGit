using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter x");
        double x = Convert.ToDouble(Console.ReadLine()); // замініть на бажане значення
        double beta = 1; // початкове значення добутку елементів матриці

        // розрахунок Y
        double Y = 0;
        if (x <= 3)
        {
            Y = Math.Abs(Math.Pow(3, 2 * x + 1));
        }
        else if (3 < x && x < 20)
        {
            for (int i = 0; i < 21; i++)
            {
                beta *= (i + 21) * 3 < x ? 2 : 1;
            }
            Y = Math.Abs(4 - beta);
        }
        else
        {
            for (int i = 6; i <= 3; i++)
            {
                beta *= 2;
            }
            Y = Math.Abs(beta);
        }

        Console.WriteLine("Y = " + Y);
    }
}
