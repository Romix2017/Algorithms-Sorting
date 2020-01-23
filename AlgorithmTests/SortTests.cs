using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.DataStructures;

namespace Algorithm.Tests
{
    [TestClass()]
    public class SortTests
    {
        Random rnd = new Random();
        List<int> Items = new List<int>();
        List<int> Sorted = new List<int>();
        [TestInitialize]
        public void Init()
        {
            Items.Clear();
            for (int i = 0; i < 1000; i++)
            {
                Items.Add(rnd.Next(0, 100));
            }
            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }
        [TestMethod()]
        public void InsertSortTest()
        {
            // arrange
            var insert = new InsertSort<int>();
            // act
            insert.Items.AddRange(Items);
            insert.Sort();
            // assert
            for (int i = 0; i < insert.Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insert.Items[i]);
            }
        }
        [TestMethod()]
        public void BubbleTest()
        {
            // arrange
            var bubble = new BubbleSort<int>();
            bubble.Items.AddRange(Items);
            // act
            bubble.Sort();
            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bubble.Items[i]);
            }
        }
        [TestMethod()]
        public void CocktailSortTest()
        {
            // arrange
            var cocktail = new CocktailSort<int>();
            cocktail.Items.AddRange(Items);
            // act
            cocktail.Sort();
            // assert
            for (int i = 0; i < cocktail.Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], cocktail.Items[i]);
            }
        }
        [TestMethod()]
        public void ShellSortTest()
        {
            // arrange
            var shell = new ShellSort<int>();
            shell.Items.AddRange(Items);
            // act
            shell.Sort();
            // assert
            for (int i = 0; i < shell.Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], shell.Items[i]);
            }
        }
        [TestMethod()]
        public void BaseSortTest()
        {
            // arrange
            var bases = new AlgorithmBase<int>();
            bases.Items.AddRange(Items);
            // act
            bases.Sort();
            // assert
            for (int i = 0; i < bases.Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bases.Items[i]);
            }
        }
        [TestMethod()]
        public void TreeSortTest()
        {
            // arrange
            var tree = new Tree<int>(Items);
            // act
            tree.Sort();
            // assert
            for (int i = 0; i < tree.Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], tree.Items[i]);
            }
        }
        [TestMethod()]
        public void HeapSortTest()
        {
            // arrange
            var heap = new HeapClass<int>(Items);
            // act
            heap.Sort();
            // assert
            for (int i = 0; i < heap.Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], heap.Items[i]);
            }
        }
        [TestMethod()]
        public void SelectionSortTest()
        {
            // arrange
            var selection = new SelectionSort<int>();
            selection.Items.AddRange(Items);
            // act
            selection.Sort();
            // assert
            for (int i = 0; i < selection.Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], selection.Items[i]);
            }
        }
        [TestMethod()]
        public void GnomeSortTest()
        {
            // arrange
            var gnome = new GnomeSort<int>();
            gnome.Items.AddRange(Items);
            // act
            gnome.Sort();
            // assert
            for (int i = 0; i < gnome.Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], gnome.Items[i]);
            }
        }
        [TestMethod()]
        public void LsdRadixSortTest()
        {
            // arrange
            var lsdRadix = new LsdRedixSort<int>();
            lsdRadix.Items.AddRange(Items);
            // act
            lsdRadix.Sort();
            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], lsdRadix.Items[i]);
            }
        }
        [TestMethod()]
        public void MsdRadixSortTest()
        {
            // arrange
            var msdRadix = new MsdRedixSort<int>();
            msdRadix.Items.AddRange(Items);
            // act
            msdRadix.Sort();
            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], msdRadix.Items[i]);
            }
        }
    }
}