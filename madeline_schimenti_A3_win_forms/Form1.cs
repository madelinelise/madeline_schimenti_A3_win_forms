using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace madeline_schimenti_A3_win_forms
{
    public partial class Form1 : Form
    {

        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addToOrder_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numOrdered.Text) <= 0)
            {
                MessageBox.Show("Please enter a valid number!");
            }
            counter = counter + Convert.ToInt32(numOrdered.Text);
        }

        private void summary_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total tickets ordered: " + counter.ToString());
        }

        private void clear_Click(object sender, EventArgs e)
        {
            DialogResult userAnswer;
            userAnswer = MessageBox.Show("Would you like to reset your order of " + counter.ToString() + " tickets?", "Total Count", MessageBoxButtons.YesNo);
        if (userAnswer == DialogResult.Yes)
        {
            counter = 0;
        }
        }
    }
}
