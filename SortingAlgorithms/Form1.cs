using Algorithm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                var item = new SortedItem(value);
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
                    var item = new SortedItem(value);
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
    }
}
