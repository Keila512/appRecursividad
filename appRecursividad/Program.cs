using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appRecursividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat1 = new int[3, 3];
            int[,] mat2 = new int[3, 3];
            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mat1[i, j] = rnd.Next(1, 1000);
                    mat2[i, j] = rnd.Next(1, 1000);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mat1[i,j]+ "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mat2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("THE SUM OF THE DATA OF THE MATRIXES IS: " + matricesRecursiveSum(mat1,mat2,2,2));
            Console.ReadKey();
        }
        static int matricesRecursiveSum(int[,]mat1, int[,]mat2, int nf, int nc)
        {
            if ((nf == 0) && (nc == 0))
            return mat1[nf, nc] + mat2[nf, nc];
            
            else 
            {
                if (nf > -1)
                {
                    nc--;
                    if (nc >= -1)
                    { return mat1[nf, nc + 1] + mat2[nf, nc + 1] + matricesRecursiveSum(mat1, mat2, nf, nc); }
                    else
                    { return matricesRecursiveSum(mat1, mat2, nf - 1, 2); }
                }
                else return 0;
            }
        }
    }
}
