using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine(Recursive(x));
    }

    static double Recursive(double x)
    {
        if ( Math.Pow( x , 2 ) <= 4 )
        {
            return 2;
        }
        else
        {
            return 1 + Recursive( x - ( (4 * Math.Abs(x)) / x ));
        }
    }
}