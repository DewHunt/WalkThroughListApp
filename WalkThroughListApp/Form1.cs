using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalkThroughListApp
{
    public partial class WalkThrouhWithListUI : Form
    {
        public WalkThrouhWithListUI()
        {
            InitializeComponent();
        }

        List<double> numbers = new List<double>();

        private void addButton_Click(object sender, EventArgs e)
        {
            double numberFromTextBox = Convert.ToDouble(numberTextBox.Text);

            numbers.Add(numberFromTextBox);
            numberTextBox.Clear();
        }

        private void showAllNumberButton_Click(object sender, EventArgs e)
        {
            double total = 0;

            showAllNumberListBox.Items.Clear();

            foreach(double addnumber in numbers)
            {
                showAllNumberListBox.Items.Add(addnumber);
                total = total + addnumber;
            }

            sumResultTextBox.Text = total.ToString();
        }
    }
}
