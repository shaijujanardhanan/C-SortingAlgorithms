using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static CSharpSortingAlgorithms.Algorithms;
using NUnit.Framework;
namespace CSharpSortingAlgorithmsTests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void BubbleSort_WithProperData()
        {
            int[] input = { 2, 3, 9, 1, 10, 5, 2 };
            int[] expectedResult = { 10, 9, 5, 3, 2, 2, 1 };

            int[] result = BubbleSort(input);
            Assert.IsTrue(result.SequenceEqual(expectedResult));
        }
        [Test]
        public void SelectionSort_WithProperData()
        {
            int[] input = { 2, 3, 9, 1, 10, 5, 2 };
            int[] expectedResult = { 1, 2, 2, 3, 5, 9, 10 };
            int[] result = SelectionSort(input);
            Assert.IsTrue(result.SequenceEqual(expectedResult));
        }
    }
}
