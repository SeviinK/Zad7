using System;

class Program
{
    static void Main(string[] args)
    {
        int czas = 332;
        string formatowanyCzas = FormatujCzas(czas);
        Console.WriteLine(formatowanyCzas);

        Console.ReadLine();
    }

    static string FormatujCzas(int czas)
    {
        int godziny = czas / 3600;
        int minuty = (czas % 3600) / 60;
        int sekundy = czas % 60;

        string sGodziny = godziny.ToString("D2");
        string sMinuty = minuty.ToString("D2");
        string sSekundy = sekundy.ToString("D2");

        string formatowanyCzas = $"{sGodziny}:{sMinuty}:{sSekundy}";

        return formatowanyCzas;
    }
}
