using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_1_3_Chapter_Assignment
{
    public partial class frmBasicInput : Form
    {
        double height;
        string name;

        public frmBasicInput()
        {
            InitializeComponent();
        }

        private void frmBasicInput_Load(object sender, EventArgs e)
        {

        }

        private void btnNameEnter_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            lblNameInfo.Text = "Hello: " + name + "!!!";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHeightEnter_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(txtHeight.Text);
            lblHeightInfo.Text = ("You are " + (2.72 - height) + "m shorter than the tallest person!!!");

        }

        private void btnAgeEnter_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(numUpDownAge.Value);
            lblAgeInfo.Text = ("You are expected to live another " + (82 - age) + " years!!!");
        }
    }
}
