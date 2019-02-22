using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangingAreaPerAllanL
{
    public partial class frmChangingAreaPer : Form
    {
        public frmChangingAreaPer()
        {
            InitializeComponent();

            //Hiding labels
            this.lblArea.Hide();
            this.lblAreaAnswer.Hide();
            this.lblPerimeter.Hide();
            this.lblPerimeterAnswer.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Allow these words to hold numbers
            double length, width, area, perimeter;

            //convert the strings from the textbox into doubles
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);


            area = length * width;
            perimeter = 2 * length + 2 * width;

            this.lblAreaAnswer.Text = Convert.ToString(area) + " Square Meters";
            this.lblPerimeterAnswer.Text = Convert.ToString(perimeter) + " Meters";

            this.lblArea.Show();
            this.lblAreaAnswer.Show();
            this.lblPerimeter.Show();
            this.lblPerimeterAnswer.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmChangingAreaPer_Load(object sender, EventArgs e)
        {

        }

       
    }
}

