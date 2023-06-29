using System;

class Program
{
    static void Main(string[] args)
    {
        double x1 = 1.5;
        double y1 = 2.5;
        double x2 = 4.2;
        double y2 = 7.8;

        double dlugosc = ObliczDlugoscOdcinka(x1, y1, x2, y2);
        Console.WriteLine("Długość odcinka: " + dlugosc);

        Console.ReadLine();
    }

    static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
    {
        double dlugosc = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return dlugosc;
    }
}
