﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            for (int i = 0; i < 10000; i++)
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
    }
}