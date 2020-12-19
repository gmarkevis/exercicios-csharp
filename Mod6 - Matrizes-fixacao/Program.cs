using System;

namespace Mod6___Matrizes_fixacao {
    class Program {
        static void Main(string[] args) {
            string[] MN = Console.ReadLine().Split(" ");

            int[,] mat = new int[int.Parse(MN[0]), int.Parse(MN[1])];

            for(int i = 0; i < mat.GetLength(0); i++) {
                string[] values = Console.ReadLine().Split(" ");
                for(int j = 0; j < mat.GetLength(1); j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < mat.Rank; i++) {
                for (int j = 0; j < mat.GetLength(1); j++) {
                    if(x == mat[i, j]) {
                        Console.WriteLine("Position " + i + "," + j + ":");

                        if(j > 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < mat.GetLength(1) - 1) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < mat.GetLength(0) -1) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
