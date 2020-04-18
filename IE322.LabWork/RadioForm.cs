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
    public partial class RadioForm : Form
    {
        public RadioForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton5.ForeColor = Color.Brown;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton6.ForeColor = Color.Snow;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            radioButton7.ForeColor = Color.Gold;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            radioButton8.ForeColor = Color.Olive;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;

            radioButton5.ForeColor = Color.Black;
            radioButton6.ForeColor = Color.Black;
            radioButton7.ForeColor = Color.Black;
            radioButton8.ForeColor = Color.Black;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            radioButton1.ForeColor = Color.Black;
            radioButton2.ForeColor = Color.Black;
            radioButton3.ForeColor = Color.Black;
            radioButton4.ForeColor = Color.Black;


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton1.ForeColor = Color.Brown;
            }
            else
            {
                radioButton1.ForeColor = Color.Black;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton2.ForeColor = Color.Snow;
            }
            else
            {
                radioButton2.ForeColor = Color.Black;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                radioButton3.ForeColor = Color.Gold;
            }
            else
            {
                radioButton3.ForeColor = Color.Black;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                radioButton4.ForeColor = Color.Olive;
            }
            else
            {
                radioButton4.ForeColor = Color.Black;
            }
        }

        private void RadioForm_Load(object sender, EventArgs e)
        {

        }
    }
}
