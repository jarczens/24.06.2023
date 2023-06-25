using System;

namespace Ćw_6_zajęcia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj rozmiar tablicy: ");
            int rozmiar = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[rozmiar, rozmiar];

            int currentCol = 0;
            int currentRow = 0;
            int direction = 0; // 0 - prawo; 1 - dół; 2 - lewo; 3 - góra

            for (int currentNumber = 1; currentNumber <= rozmiar * rozmiar; currentNumber++)
            {
                array[currentRow, currentCol] = currentNumber;
                switch (direction)
                {
                    case 0: //right
                        if (currentCol + 1 >= rozmiar || array[currentRow, currentCol + 1] != 0)
                        {
                            direction = 1;
                            currentRow++;
                        }
                        else
                        {
                            currentCol++;
                        }
                        break;
                    case 1: //down
                        if (currentRow + 1 >= rozmiar || array[currentRow + 1, currentCol] != 0)
                        {
                            direction = 2;
                            currentCol--;
                        }
                        else
                        {
                            currentRow++;
                        }
                        break;
                    case 2: //left
                        if (currentCol - 1 < 0 || array[currentRow, currentCol - 1] != 0)
                        {
                            direction = 3;
                            currentRow--;
                        }
                        else
                        {
                            currentCol--;
                        }
                        break;
                    case 3: //up
                        if (array[currentRow - 1, currentCol] != 0)
                        {
                            direction = 0;
                            currentCol++;
                        }
                        else
                        {
                            currentRow--;
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Tablica {0}x{0}:", rozmiar);
            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    Console.Write("{0,3} ", array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}