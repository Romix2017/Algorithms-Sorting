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
                panel5.Controls.Add(item.ProgressBar);
                panel5.Controls.Add(item.Label);
            }

            AddTextBox.Text = "";
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
                    panel5.Controls.Add(item.ProgressBar);
                    panel5.Controls.Add(item.Label);
                }
            }

            AddRandomTextBox.Text = "";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void BubbleSortBut_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            bubble.CompareEvent += Bubble_CompareEvent;
            bubble.SwapEvent += Bubble_SwapEvent;
            bubble.Sort();

        }

        private void Bubble_SwapEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {

            var temp = e.Item1.Value;
            e.Item1.SetValue(e.Item2.Value);
            e.Item2.SetValue(temp);
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
