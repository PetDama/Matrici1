using System;

namespace Matrici1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nr linii:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] matrice = new int[N, N];

            bool esteIdentitate = true;

            for (int row = 0; row < matrice.GetLength(0); row++)
            
                for (int col = 0; col < matrice.GetLength(1); col++)
                {
                    Console.Write($"[{row},{col}]:");
                    matrice[row, col] = Convert.ToInt32(Console.ReadLine());

                    if (row != col)
                    {
                        if (matrice[row, col] != 0)
                        {
                            esteIdentitate = false;
                        }
                    }
                    else if (matrice[row, col] != 1)
                    {
                        esteIdentitate = false;
                    }
                }
                if (esteIdentitate == true)
                    Console.WriteLine("Este matrice identitate!");
                else
                    Console.WriteLine("Nu este matrice identitate");

            
        }
    }
}
