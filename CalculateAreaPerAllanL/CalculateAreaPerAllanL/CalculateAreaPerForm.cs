using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateAreaPerAllanL
{
    public partial class CalculateAreaPerForm : Form
    {
        public CalculateAreaPerForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblPerimeterAnswer_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare local variables
            double length, width;

            length = double.Parse(txtLength.Text);



            txtLength.Select();

            txtWidth.Select();

            this.lblPerimeterAnswer.Show();
        }
    }
}
