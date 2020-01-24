
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithm
{
    public class AlgorithmBase<T> where T : IComparable
    {
        public int SwapCount { get; protected set; } = 0;
        public int CompareCount { get; protected set; } = 0;
        public List<T> Items { get; set; } = new List<T>();
        public event EventHandler<Tuple<T, T>> CompareEvent;
        public event EventHandler<Tuple<T, T>> SwapEvent;
        public event EventHandler<Tuple<int, T>> SetEvent;
        public AlgorithmBase(IEnumerable<T> items)
        {
            Items.AddRange(items);
        }
        public AlgorithmBase() { }
        protected void Swap(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                SwapEvent?.Invoke(this, new Tuple<T, T>(Items[positionA], Items[positionB]));
                SwapCount++;
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;
            }
        }
        public TimeSpan Sort()
        {
            var timer = new Stopwatch();
            SwapCount = 0;
            timer.Start();
            MakeSort();
            timer.Stop();
            return timer.Elapsed;
        }
        protected void Set(int position, T item)
        {
            if (position < Items.Count)
            {
                SetEvent?.Invoke(this, new Tuple<int, T>(position, item));
                Items[position] = item;
            }
        }
        protected virtual void MakeSort()
        {
            Items.Sort();
        }
        protected int Compare(T a, T b)
        {
            CompareEvent?.Invoke(this, new Tuple<T, T>(a, b));
            CompareCount++;
            return a.CompareTo(b);
        }
    }
}

