using Algorithm;
using Algorithm.DataStructures;
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

        private void Algorithm_SwapEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Aqua);
            e.Item2.SetColor(Color.Brown);
            panel5.Refresh();
            Thread.Sleep(20);
            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);
            panel5.Refresh();
            Thread.Sleep(50);
            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            panel5.Refresh();
            Thread.Sleep(20);
        }
        private void Algorithm_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
            panel5.Refresh();
            Thread.Sleep(50);
            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            panel5.Refresh();
            Thread.Sleep(20);
        }
        private void Swap(SortedItem a, SortedItem b)
        {
            a.SetColor(Color.Red);
            b.SetColor(Color.Green);
        }
        private void Btn_Click(AlgorithmBase<SortedItem> algorithm)
        {
            RefreshItems();
            for (int i = 0; i < algorithm.Items.Count; i++)
            {
                algorithm.Items[i].SetPosition(i);
            }
            panel5.Refresh();
            algorithm.CompareEvent += Algorithm_CompareEvent;
            algorithm.SwapEvent += Algorithm_SwapEvent;
            var time = algorithm.Sort();
            TimeLabel.Text = "Time: " + time.Seconds;
            SwapLabel.Text = "Qty swaps: " + algorithm.SwapCount;
            CompareLabel.Text = "Qty comparisons: " + algorithm.CompareCount;
        }
        private void CocktailSortBut_Click(object sender, EventArgs e)
        {
            var cocktail = new CocktailSort<SortedItem>(items);
            Btn_Click(cocktail);
        }
        private void BubbleSortBut_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            Btn_Click(bubble);
        }
        private void InsertSortBut_Click(object sender, EventArgs e)
        {
            var insert = new InsertSort<SortedItem>(items);
            Btn_Click(insert);
        }
        private void ShellSortBtn_Click(object sender, EventArgs e)
        {
            var shell = new ShellSort<SortedItem>(items);
            Btn_Click(shell);
        }
        private void SelectionSortBut_Click(object sender, EventArgs e)
        {
            var select = new SelectionSort<SortedItem>(items);
            Btn_Click(select);
        }
        private void HeapSortBtn_Click(object sender, EventArgs e)
        {
            var heap = new HeapClass<SortedItem>(items);
            Btn_Click(heap);
        }
        private void GnomeSortBut_Click(object sender, EventArgs e)
        {
            var gnome = new GnomeSort<SortedItem>(items);
            Btn_Click(gnome);
        }

        private void TreeSortBtn_Click(object sender, EventArgs e)
        {
            var tree = new Tree<SortedItem>(items);
            Btn_Click(tree);
        }
    }
}
