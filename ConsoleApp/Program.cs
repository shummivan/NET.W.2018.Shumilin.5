using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polynomial;
using BubbleSort;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            My_Polynomial p1 = new My_Polynomial(4, 7, 5);
            My_Polynomial p2 = new My_Polynomial(1, 2, 1, 1);

            //Console.WriteLine((p1 - p2).ToString());

            My_BubbleSort bs = new My_BubbleSort();

            int[][] arr = new int[][]
            {
                new int[] {10,-50,8,9},
                new int[]{3,5,6 },
                new int[] {0,0,0,0},
                new int[]{1,0,0,2},
                new int[] {4,-5,-6,7}        
            };

            bs.SortByRegrowthSumRows(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            bs.SortByRegrowthMaxElementRows(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            bs.SortByRegrowthMinElementRows(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]);
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
