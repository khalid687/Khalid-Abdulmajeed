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
    public partial class FirstForm : Form
    {
        string username = "";
        string password = "";
        int attempts = 1;
        int Maxattempts = 3;
        bool LoggedIn = false;

        public FirstForm()
        {
            InitializeComponent();
           
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            RadioForm rdo = new RadioForm();
            rdo.ShowDialog();

        }
        //123
        private void CheckBox_Click(object sender, EventArgs e)
        {
            CheckBoxForm Chk = new CheckBoxForm();
            Chk.ShowDialog();
           
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            

            if ( ! LoggedIn )
            {
                while (attempts <= Maxattempts)
                {

                    if (Username.Text != username)
                    {
                        MessageBox.Show("You have "  + (Maxattempts - attempts) +  " tries left", "Error");
                        attempts++;
                        return;

                    }
                    else
                    {
                        if (Password.Text != password)
                        {
                            MessageBox.Show("You have " + (Maxattempts - attempts) + " tries left", "Error");
                            attempts++;
                            return;

                        }
                        else
                        {
                            attempts = 1;
                            LoggedIn = true;
                            foreach (var grp in groupBox4.Controls.OfType<GroupBox>())
                            {
                                foreach (var btn in grp.Controls.OfType<Button>())
                                {
                                    btn.Enabled = true;
                                    btn.BackColor = Color.White;
                                }
                            }
                            LoginButton.Text = "Logout";
                           toolStripStatusLabel1.Text = "Welcome back";
                            break;

                        }
                    }
                }


            }
            else
            {
                LoginButton.Text = "Login";
                LoggedIn = false;
                Username.Clear();
                Password.Clear();
                

                foreach (var grp in groupBox4.Controls.OfType<GroupBox>())
                {
                    foreach (var btn in grp.Controls.OfType<Button>())
                    {
                        btn.Enabled = false;
                        btn.BackColor = Color.Gray;

                    }
                }

                toolStripStatusLabel1.Text = "Come again";


            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var grp in groupBox4.Controls.OfType<GroupBox>())
            {
                foreach (var btn in grp.Controls.OfType<Button>())
                {
                    btn.Enabled = false;
                    btn.BackColor = Color.Gray;
                }
            }
            toolStripStatusLabel1.Text = "This is khalid's application";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ComboButton_Click(object sender, EventArgs e)
        {
            ComboBoxForm Cmb = new ComboBoxForm();
            Cmb.ShowDialog();
            
        }

        private void PictureBoxButton_Click(object sender, EventArgs e)
        {
            PictureBoxForm pic = new PictureBoxForm();
            pic.ShowDialog();
            
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            RandomForm rdm = new RandomForm();
            rdm.ShowDialog();
            
        }

        private void RandomComboButton_Click(object sender, EventArgs e)
        {
            RandomComboForm rdm2 = new RandomComboForm();
            rdm2.ShowDialog();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutForm abt = new AboutForm();
            abt.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
    

    
