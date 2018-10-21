using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class My_BubbleSort
    {
        /// <summary>
        /// Search sum elements in rows
        /// </summary>
        /// <param name="arr">Jagged array</param>
        /// <returns>Array of sum elements in rows</returns>
        private int[] SumRows(int[][] arr)
        {
            int[] temp = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    temp[i] += arr[i][j];
                }
            }

            return temp;
        }

        /// <summary>
        /// Search max elements in rows
        /// </summary>
        /// <param name="arr">Jagged array</param>
        /// <returns>Array of max elements</returns>
        private int[] MaxElRows(int[][] arr)
        {
            int[] temp = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i][0];

                for (int j = 0; j < arr[i].Length; j++)
                {                
                    if (arr[i][j] > temp[i])
                    {
                        temp[i] = arr[i][j];
                    }
                }
            }

            return temp;
        }

        /// <summary>
        /// Search min elements in rows
        /// </summary>
        /// <param name="arr">Jagged array</param>
        /// <returns>Array of min elements</returns>
        private int[] MinElRows(int[][] arr)
        {
            int[] temp = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i][0];

                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] < temp[i])
                    {
                        temp[i] = arr[i][j];
                    }
                }
            }

            return temp;
        }

        /// <summary>
        /// Sort By Regrowth Min Element Rows
        /// </summary>
        /// <param name="arr">Jagged array</param>
        public void SortByRegrowthMinElementRows(int[][] arr)
        {
            int[] minElInRows = MinElRows(arr);

            BubbleSort(arr, minElInRows);
        }

        /// <summary>
        /// Sort By Descending Min Element Rows
        /// </summary>
        /// <param name="arr">Jagged array</param>
        public void SortByDescendingMinElementRows(int[][] arr)
        {
            int[] minElInRows = MinElRows(arr);
            minElInRows.Reverse();

            BubbleSort(arr, minElInRows);
        }

        /// <summary>
        /// Sort By Regrowth Max Element Rows
        /// </summary>
        /// <param name="arr">Jagged array</param>
        public void SortByRegrowthMaxElementRows(int[][] arr)
        {
            int[] maxElInRows = MaxElRows(arr);

            BubbleSort(arr,maxElInRows);
        }

        /// <summary>
        /// Sort By Descending Max Element Rows
        /// </summary>
        /// <param name="arr">Jagged array</param>
        public void SortByDescendingMaxElementRows(int[][] arr)
        {
            int[] maxElInRows = MaxElRows(arr);
            maxElInRows.Reverse();

            BubbleSort(arr,maxElInRows);    
        }

        /// <summary>
        /// Sort By Regrowth Sum Rows
        /// </summary>
        /// <param name="arr">Jagged array</param>
        public void SortByRegrowthSumRows(int[][] arr)
        {
            int[] sumRows = SumRows(arr);

            BubbleSort(arr, sumRows);
        }

        /// <summary>
        /// Sort By Descending Sum Rows
        /// </summary>
        /// <param name="arr">Jagged array</param>
        public void SortByDescendingSumRows(int[][] arr)
        {
            int[] sumRows = SumRows(arr);
            sumRows.Reverse();

            BubbleSort(arr, sumRows);
        }

        /// <summary>
        /// Swap array
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        private void Swap(ref int[] first, ref int[] second)
        {
            int[] temp = first;
            first = second;
            second = temp;
        }

        /// <summary>
        /// Swap elements
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        private void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }

        /// <summary>
        /// Bubble sort
        /// </summary>
        /// <param name="arr">Jagged array</param>
        /// <param name="additionalityArr">Additionality array</param>
        private void BubbleSort(int[][] arr, int[] additionalityArr)
        {
            for (int i = 0; i < additionalityArr.Length; i++)
            {
                for (int j = 0; j < additionalityArr.Length - 1; j++)
                {
                    if (additionalityArr[j] > additionalityArr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        Swap(ref additionalityArr[j], ref additionalityArr[j + 1]);
                    }
                }

            }
        }
    }
}
