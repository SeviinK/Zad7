using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] tablica = {
            { 1, 2, 3, 4 },
            { 4, 2, 3, 1 },
            { 1, 3, 2, 4 },
            { 3, 1, 4, 2 }
        };

        int[] najblizszeWiersze = ZnajdzNajblizszeWiersze(tablica);

        Console.WriteLine("Najbardziej zbliżone wiersze: " + najblizszeWiersze[0] + ", " + najblizszeWiersze[1]);

        Console.ReadLine();
    }

    static int[] ZnajdzNajblizszeWiersze(int[,] tablica)
    {
        int[] najblizszeWiersze = new int[2];
        int najmniejszaRoznica = int.MaxValue;

        int iloscWierszy = tablica.GetLength(0);

        for (int i = 0; i < iloscWierszy; i++)
        {
            for (int j = i + 1; j < iloscWierszy; j++)
            {
                int roznica = ObliczMiareZroznia(tablica, i, j);

                if (roznica < najmniejszaRoznica)
                {
                    najmniejszaRoznica = roznica;
                    najblizszeWiersze[0] = i;
                    najblizszeWiersze[1] = j;
                }
            }
        }

        return najblizszeWiersze;
    }

    static int ObliczMiareZroznia(int[,] tablica, int i, int j)
    {
        int iloscKolumn = tablica.GetLength(1);
        int roznica = 0;

        for (int k = 0; k < iloscKolumn; k++)
        {
            int aik = tablica[i, k];
            int ajk = tablica[j, k];

            roznica += (aik - ajk) * (aik - ajk);
        }

        return roznica;
    }
}
