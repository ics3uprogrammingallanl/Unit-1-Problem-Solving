/*
 * Created by: Allan Leveille
 * Created on: 22 February, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #12 - Pseudocode
 * This program calculates the price of a pizza using its diameter in inches and the subtotal. 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCircumferenceAllanL
{
    public partial class frmPizzaCircumference : Form
    {
        public frmPizzaCircumference()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //State all variables
            double diameter, subtotal, total;

            //Convert the diameter to a double
            diameter = double.Parse(txtDiameter.Text);

            //Calculate the subtotal and total
            subtotal = 0.75 + 0.99 + 0.50 * diameter;
            total = subtotal * 1.13;

            //Display the total
            lblTotalPrice.Text = String.Format("${0:0.00}", total);

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
