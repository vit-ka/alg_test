﻿using System.Collections.Generic;
using NUnit.Framework;

namespace AlgorithmTest.Test
{
    [TestFixture]
    public class MergeSortTest : SortingTest
    {
        private static readonly int[][] ToSort = ToSortBase;

        [TestCaseSource("ToSort")]
        public void SimpleCases(ICollection<int> paramCollection)
        {
            var result = MergeSort.Sort(paramCollection);
            Assert.That(result, MoreThan.Sorted<int>());
        }
    }
}