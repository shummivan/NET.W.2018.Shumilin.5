using System;
using NUnit.Framework;
using BubbleSort;

namespace Polynomial.Tests
{
    [TestFixture]
    public class Tests
    {
        private int[][] arr = new int[][]
        {
                new int[] {10,-50,8,9},
                new int[]{3,5,6 },
                new int[] {0,0,0,0},
                new int[]{1,0,0,2},
                new int[] {4,-5,-6,7}
        };

        [Test]
        public void BubbleSort_NullParams_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => My_BubbleSort.BubbleSort(null, new Comparers.ComparerByDescendingMaxElement()));
            Assert.Throws<ArgumentNullException>(() => My_BubbleSort.BubbleSort(arr, (Comparison<int[]>)null));
        }

        [Test]
        public void SortDescendingMax_CorrectParams_CorrectAnswer()
        {
            int[][] expected = new int[][]
            {
                new int[] {10, -50, 8, 9},
                new int[] {4, -5, -6, 7},
                new int[]{3, 5, 6},                
                new int[]{1, 0, 0, 2},
                new int[] {0, 0, 0, 0},
            };

            My_BubbleSort.BubbleSort(arr, new Comparers.ComparerByDescendingMaxElement());
            CollectionAssert.AreEqual(expected, arr);
        }

        [Test]
        public void SortRegrowthMax_CorrectParams_CorrectAnswer()
        {
            int[][] expected = new int[][]
            {
                new int[] {0, 0, 0, 0},
                new int[]{1, 0, 0, 2},
                new int[]{3, 5, 6},
                new int[] {4, -5, -6, 7},
                new int[] {10, -50, 8, 9}             
            };

            My_BubbleSort.BubbleSort(arr, new Comparers.ComparerByRegrowthMaxElement());
            CollectionAssert.AreEqual(expected, arr);
        }

        [Test]
        public void SortRegrowthMin_CorrectParams_CorrectAnswer()
        {
            int[][] expected = new int[][]
            {
                new int[] {10, -50, 8, 9},
                new int[] {4, -5, -6, 7},
                new int[] {0, 0, 0, 0},
                new int[]{1, 0, 0, 2},
                new int[]{3, 5, 6},                             
            };

            My_BubbleSort.BubbleSort(arr, new Comparers.ComparerByRegrowthMinElement());
            CollectionAssert.AreEqual(expected, arr);
        }

        [Test]
        public void SortDescendingMin_CorrectParams_CorrectAnswer()
        {
            int[][] expected = new int[][]
            {
                new int[]{3, 5, 6},
                new int[]{1, 0, 0, 2},
                new int[] {0, 0, 0, 0},
                new int[] {4, -5, -6, 7},
                new int[] {10, -50, 8, 9},   
            };

            My_BubbleSort.BubbleSort(arr, new Comparers.ComparerByDescendingMinElement());
            CollectionAssert.AreEqual(expected, arr);
        }

        [Test]
        public void SortDescendingSum_CorrectParams_CorrectAnswer()
        {
            int[][] expected = new int[][]
            {
                new int[]{3, 5, 6},
                new int[]{1, 0, 0, 2},
                new int[] {0, 0, 0, 0},
                new int[] {4, -5, -6, 7},
                new int[] {10, -50, 8, 9},
            };

            My_BubbleSort.BubbleSort(arr, new Comparers.ComparerByDescendingSumElement());
            CollectionAssert.AreEqual(expected, arr);
        }

        [Test]
        public void SortRegrowthSum_CorrectParams_CorrectAnswer()
        {
            int[][] expected = new int[][]
            {
                new int[] {10, -50, 8, 9},
                new int[] {4, -5, -6, 7},
                new int[] {0, 0, 0, 0},
                new int[]{1, 0, 0, 2},
                new int[]{3, 5, 6},
            };

            My_BubbleSort.BubbleSort(arr, new Comparers.ComparerByRegrowthSumElement());
            CollectionAssert.AreEqual(expected, arr);
        }
    }
}
