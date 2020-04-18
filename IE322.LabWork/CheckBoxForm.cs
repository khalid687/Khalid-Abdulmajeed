using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE322.LabWork
{
    public partial class CheckBoxForm : Form
    {
        public CheckBoxForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string X = "";

            if (checkBox1.Checked == true)
            {
                X = checkBox1.Text;
            }
            if (checkBox2.Checked == true)
            {
                X = X + " " + checkBox2.Text;
            }
            if (checkBox3.Checked == true)
            {
                X = X + " " + checkBox3.Text;
            }
            if (checkBox4.Checked == true)
            {
                X = X + " " + checkBox4.Text;
            }

            if (X.Length > 0)
            {
                MessageBox.Show(X + " is selected");
            }
            if (X.Length <= 0)
            {
                MessageBox.Show("Select one of them");
            }






        }

        private void CheckBoxForm_Load(object sender, EventArgs e)
        {

        }
    }//123
}
