// Zailyn Tamayo
// 30 October 2016

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculations_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sum button is clicked
        private void sumButton_Click(object sender, EventArgs e)
        {
            // First and second numbers entered converted
            double fn = double.Parse(fnTextbox.Text);
            double sn = double.Parse(snTextbox.Text);

            // Calculate the sum of first and second number
            double sum = fn + sn;

            // Display sum in label box
            this.resultsLabel.Text = "The sum is " + sum.ToString() + ".";  
        }

        // Diff button is clicked
        private void diffButton_Click(object sender, EventArgs e)
        {
            // First and second numbers entered converted
            double fn = double.Parse(fnTextbox.Text);
            double sn = double.Parse(snTextbox.Text);

            // Calculate the difference of first and second number
            double diff = fn - sn;

            // Display difference in label box
            this.resultsLabel.Text = "The difference is " + diff.ToString() + ".";

        }

        // Prod button is clicked
        private void prodButton_Click(object sender, EventArgs e)
        {
            // First and second numbers entered converted
            double fn = double.Parse(fnTextbox.Text);
            double sn = double.Parse(snTextbox.Text);

            // Calculate product of first and second number
            double prod = fn * sn;

            // Display product in label box
            this.resultsLabel.Text = "The product is " + prod.ToString() + ".";
        }

        private void quotButton_Click(object sender, EventArgs e)
        {
            // First and second numbers entered converted
            double fn = double.Parse(fnTextbox.Text);
            double sn = double.Parse(snTextbox.Text);

            // Calculate quotient of first and second number
            double quot = fn / sn;

            // Display quotient in label box
            this.resultsLabel.Text = "The quotient is " + quot.ToString() + ".";
        }

        // Clear button is clicked
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clears first number textbox, second number textbox and label box
            fnTextbox.Clear();
            snTextbox.Clear();
            this.resultsLabel.Text = "";
        }

        // Exit button is clicked
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exits program
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
