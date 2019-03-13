/*
 * Created by: Allan L
 * Created on: February 15, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - SchoolMascot
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

namespace SchoolMascotAllanL
{
    public partial class frmSchoolMascot : Form
    {
        public frmSchoolMascot()
        {
            InitializeComponent();
        }

        private void mniImmaculata_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Immaculata";
            lblMascot.Text = "Saints";
        }

        private void mniGlebe_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Glebe";
            lblMascot.Text = "Gryphons";
        }

        private void mniCantebury_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Cantebury";
            lblMascot.Text = "Chargers";
        }

        private void mniHillcrest_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Hillcrest";
            lblMascot.Text = "Hawks";
        }
    }
}
