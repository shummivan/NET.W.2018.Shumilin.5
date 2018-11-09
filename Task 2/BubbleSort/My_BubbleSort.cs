using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public static class My_BubbleSort
    {
        /// <summary>
        /// Bubble sort
        /// </summary>
        /// <param name="arr">Jagged array</param>
        /// <param name="additionalityArr">Additionality array</param>
        public static void BubbleSort(int[][] arr, Comparison<int[]> comparision)
        {
            if (arr == null || comparision == null)
            {
                throw new ArgumentNullException();
            }
            if (arr.Length == 0)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (comparision(arr[j], arr[j + 1]) > 0)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        /// <summary>
        /// Bubble sort
        /// </summary>
        /// <param name="arr">Jagged array</param>
        /// <param name="additionalityArr">Additionality array</param>
        public static void BubbleSort(int[][] arr, IComparer<int[]> comparer)
        {
            if (arr == null || comparer == null)
            {
                throw new ArgumentNullException();
            }
            if (arr.Length == 0)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (comparer.Compare(arr[j], arr[j + 1]) > 0)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }

            }
        }

        /// <summary>
        /// Swap elements
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        private static void Swap(ref int[] first, ref int[] second)
        {
            var temp = first;
            first = second;
            second = temp;
        }
    }
}
