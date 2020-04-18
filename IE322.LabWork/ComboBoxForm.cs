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
    public partial class ComboBoxForm : Form
    {
        public ComboBoxForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void ComboBoxForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count >= 1)
            {
                comboBox1.Items.RemoveAt(comboBox1.Items.Count - 1 );
            }
            else
            {
                MessageBox.Show("Cannot remove");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count >= 1)
            {
                comboBox1.Items.RemoveAt(comboBox1.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Cannot remove");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            comboBox1.Items.Remove("Sunday");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Sunday");
            comboBox1.Items.Add("Monday");
            comboBox1.Items.Add("Tuesday");
            comboBox1.Items.Add("Wednsday");
            comboBox1.Items.Add("Thursday");
            comboBox1.Items.Add("Friday");
            comboBox1.Items.Add("Satarday");
        }
    }
}
