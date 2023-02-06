using System;

class Program
{
    static void Main()
    {
        double Cx = double.Parse(Console.ReadLine());
        double Cy = double.Parse(Console.ReadLine());
        double Px = double.Parse(Console.ReadLine());
        double Py = double.Parse(Console.ReadLine());
        double n = double.Parse(Console.ReadLine());
        Circle(Cx,Cy,Px,Py,n);
    }

    static void Circle(double Cx , double Cy , double Px , double Py , double n)
    {
        double r = Math.Sqrt(Math.Pow(Math.Abs(Px - Cx),2) + Math.Pow(Math.Abs(Py - Cy),2));
        double seta = Math.Atan( Math.Abs(Py - Cy) / Math.Abs(Px - Cx));
        double Loopx = 0;
        double Loopy = 0;

        for ( int i = 0; i <= n; i++ )
        {
            Loopx = Cx;
            Loopy = Cy;
            Cx = Cx + ((r / (2 * i)) * Math.Cos(seta + (Math.PI / 2) * i));
            Cy = Cy + ((r / (2 * i)) * Math.Sin(seta + (Math.PI / 2) * i));
            Px = Loopx + (r * Math.Cos(seta + (Math.PI / 2) * i));
            Py = Loopy + (r * Math.Sin(seta + (Math.PI / 2) * i));
        }

        Console.WriteLine("{0:F2}",Cx);
        Console.WriteLine("{0:F2}",Cy);
        Console.WriteLine("{0:F2}",Px);
        Console.WriteLine("{0:F2}",Py);
    }
}