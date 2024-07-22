using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Arrays
    {
        static void ArrSum(int[,] arr1, int[,] arr2) {
            int[,] arrSum = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arrSum[i, j] = arr1[i, j] + arr2[i, j];
                    Console.Write(arrSum[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void ArrMult(int[,] arr1, int[,] arr2)
        {
            int[,] arrMult = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arrMult[i, j] = arr1[i, j] * arr2[i, j];
                    Console.Write(arrMult[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void ArrTranspose(int[,] arr1)
        {
            int[,] arrTranspose = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arrTranspose[i, j] = arr1[j, i] ;
                    Console.Write(arrTranspose[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 2] {{ 1, 2 }, { 3, 4 }};
            int[,] arr2 = new int[2, 2] {{ 5, 6 }, { 7, 8 }};
            Console.WriteLine("Array Sum - ");
            ArrSum(arr1 , arr2);
            Console.WriteLine("Array Multiplication - ");
            ArrMult(arr1, arr2);
            Console.WriteLine("Array Transpose - ");
            ArrTranspose(arr1);
        }
    }
}
