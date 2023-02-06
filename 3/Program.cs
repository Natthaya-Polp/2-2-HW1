using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine(Periodic(x));
    }

    static double Periodic(double x)
    {
        if ( x > -1 && x <= 0 )
        {
            return Math.Sqrt(1 - Math.Pow(x , 2));
        }
        else if ( x > 0 && x <= 1 )
        {
            return -(Math.Sqrt(1 - Math.Pow(x , 2)));
        }
        else if ( x <= -1 )
        {
            return Periodic(x + 2);
        }
        else
        {
            return Periodic(x - 2);
        }
    }
}