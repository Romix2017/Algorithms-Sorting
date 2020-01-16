using Algorithm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithms
{
    public partial class Form1 : Form
    {
        List<SortedItem> items = new List<SortedItem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddTextBox.Text, out int value))
            {
                var item = new SortedItem(value, items.Count);
                items.Add(item);
            }

            RefreshItems();

            AddTextBox.Text = "";
        }

        private void DrawItems(List<SortedItem> items)
        {
            panel5.Controls.Clear();
            foreach (var item in items)
            {
                panel5.Controls.Add(item.ProgressBar);
                panel5.Controls.Add(item.Label);
            }
            panel5.Refresh();
        }

        private void RefreshItems()
        {
            foreach (var item in items)
            {
                item.Refresh();
            }
            DrawItems(items);
        }

        private void AddRandom_Click(object sender, EventArgs e)
        {

            if (int.TryParse(AddRandomTextBox.Text, out int value))
            {
                var rnd = new Random();
                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next(100), items.Count);
                    items.Add(item);
                }
            }

            RefreshItems();

            AddRandomTextBox.Text = "";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void BubbleSortBut_Click(object sender, EventArgs e)
        {
            RefreshItems();
            panel5.Refresh();
            var bubble = new BubbleSort<SortedItem>(items);
            bubble.CompareEvent += Bubble_CompareEvent;
            bubble.SwapEvent += Bubble_SwapEvent;
            var time = bubble.Sort();
            TimeLabel.Text = "Time: " + time.Seconds;
            SwapLabel.Text = "Qty swaps: " + bubble.SwapCount;
            CompareLabel.Text = "Qty comparisons: " + bubble.CompareCount;
        }

        private void Bubble_SwapEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);
            panel5.Refresh();
            panel5.Refresh();
        }

        private void Bubble_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
            panel5.Refresh();
        }

        private void Swap(SortedItem a, SortedItem b)
        {
            a.SetColor(Color.Red);
            b.SetColor(Color.Green);
        }
    }
}
