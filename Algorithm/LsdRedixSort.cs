﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class LsdRedixSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public LsdRedixSort(IEnumerable<T> items) : base(items) { }
        public LsdRedixSort() { }
        protected override void MakeSort()
        {
            var groups = new List<List<T>>();
            for (int i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }
            int length = GetMaxLength();
            for (int step = 0; step < length; step++)
            {
                foreach (var item in Items)
                {
                    var i = item.GetHashCode();
                    var value = i % (int)Math.Pow(10, step + 1) / (int)Math.Pow(10, step);
                    groups[value].Add(item);
                }
                var j = 0;
                foreach (var group in groups)
                {
                    foreach (var item in group)
                    {
                        Set(j, item);
                        j++;
                    }
                }
                foreach (var group in groups)
                {
                    group.Clear();
                }
            }
        }
        private int GetMaxLength()
        {
            var length = 0;
            foreach (var item in Items)
            {
                if (item.GetHashCode() < 0)
                {
                    throw new ArgumentException("Only whole numbers are supported (>= 0 and <= 9)");
                }
                //var l = Convert.ToInt32(Math.Log10(item.GetHashCode()) + 1); Does not work with item = 0. Gives -infinity.
                var l = item.GetHashCode().ToString().Length;
                if (l > length)
                {
                    length = l;
                }
            }
            return length;
        }
    }
}
