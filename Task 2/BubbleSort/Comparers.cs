using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class Comparers
    {
        /// <summary>
        /// Comparer by regrowth min element
        /// </summary>
        public class ComparerByRegrowthMinElement : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                CheckParams(x, y);

                int xMin = x.Min();
                int yMin = y.Min();

                if (xMin == yMin)
                {
                    return 0;
                }

                return xMin > yMin ? 1 : -1;
            }
        }

        /// <summary>
        /// Comparer by descending min element
        /// </summary>
        public class ComparerByDescendingMinElement : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                CheckParams(x, y);

                int xMin = x.Min();
                int yMin = y.Min();

                if (xMin == yMin)
                {
                    return 0;
                }

                return xMin < yMin ? 1 : -1;
            }
        }

        /// <summary>
        /// Comparer by regrowth max element
        /// </summary>
        public class ComparerByRegrowthMaxElement : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                CheckParams(x, y);

                int xMax = x.Max();
                int yMax = y.Max();

                if (xMax == yMax)
                {
                    return 0;
                }

                return xMax > yMax ? 1 : -1;
            }
        }

        /// <summary>
        /// Comparer by descending max element
        /// </summary>
        public class ComparerByDescendingMaxElement : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                CheckParams(x, y);

                int xMax = x.Max();
                int yMax = y.Max();

                if (xMax == yMax)
                {
                    return 0;
                }

                return xMax < yMax ? 1 : -1;
            }
        }

        /// <summary>
        /// Comparer by regrowth sum element
        /// </summary>
        public class ComparerByRegrowthSumElement : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                CheckParams(x, y);

                int xSum = x.Sum();
                int ySum = y.Sum();

                if (xSum == ySum)
                {
                    return 0;
                }

                return xSum > ySum ? 1 : -1;
            }
        }

        /// <summary>
        /// Comparer by descending sum element
        /// </summary>
        public class ComparerByDescendingSumElement : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                CheckParams(x, y);

                int xSum = x.Sum();
                int ySum = y.Sum();

                if (xSum == ySum)
                {
                    return 0;
                }

                return xSum < ySum ? 1 : -1;
            }
        }

        /// <summary>
        /// Check input params
        /// </summary>
        /// <param name="x">First array</param>
        /// <param name="y">Second array</param>
        private static void CheckParams(int[] x, int[] y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentNullException();
            }        
        }
    }
}
