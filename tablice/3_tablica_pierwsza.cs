using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj rozmiar tablicy: ");
        int rozmiar = Convert.ToInt32(Console.ReadLine());

        int[,] tablica = new int[rozmiar, rozmiar];

        for (int i = 0; i < rozmiar; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    tablica[i, j] = (i * rozmiar) + j + 1;
                }
            }
            else
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    tablica[i, j] = (i * rozmiar) + rozmiar - j;
                }
            }
        }

        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < rozmiar; j++)
            {
                Console.Write(tablica[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}