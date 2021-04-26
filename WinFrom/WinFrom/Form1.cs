using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void RegisterClick(object sender, EventArgs e)
        {

            string uname = "";
            string password = "";
            string email = "";
            string gender = "";
            string profession = "";
            string bio = "";

            string errMsg = null;
            if (txtUsername.Text.Equals(""))
            {
                errMsg += "\nUsername Required";
            }
            else
            {
                uname = txtUsername.Text;
            }

            if (txtPassword.Text.Equals(""))
            {
                errMsg += "\nPassword Required";
            }
            else
            {
                password = txtPassword.Text;
            }

            if (txtEmail.Text.Equals(""))
            {
                errMsg += "\nE-mail Required";
            }
            else
            {
                email = txtEmail.Text;
            }

            if (gbGender.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked) == null)
            {
                errMsg += "\nGender Required";
            }
            else
            {
                gender = gbGender.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
            }

            if (cbProsfession.SelectedItem ==null)
            {
                errMsg += "\nProfession Required";
            }
            else
            {
                profession = cbProsfession.SelectedItem.ToString();
            }

            bio = txtBio.Text;

            /*MessageBox.Show("Registred!!!");
            string uname = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string profession = "";
            string profession = cbProsfession.SelectedItem.ToString();
            var controls = gbGender.Controls;
            var types = controls.OfType<RadioButton>();
            var seleceted = types.FirstOrDefault(n => n.Checked);
            var gender = seleceted.Text;
            var tmp = gbGender.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
            string gender = "";
            string bio = txtBio.Text;*/

            List<string> hb = new List<string>();

            if (cbMovies.Checked) hb.Add(cbMovies.Text);
            if (cbGames.Checked) hb.Add(cbGames.Text);
            if (cbTravel.Checked) hb.Add(cbTravel.Text);
            if (cbSongs.Checked) hb.Add(cbSongs.Text);

            if (errMsg == null)
            {
                rtOutput.Text = string.Format("Username:{0}\nPassword:{1} \nE-mail:{2} \nGender:{3} \nProfession:{4} \nBio:{5} \nHobbies:{6} ", uname, password, email, gender, profession, bio, rtOutput.Text);

                foreach (var st in hb)
                {
                    rtOutput.Text += st + " ";
                }
            }
            else
            {
                MessageBox.Show(errMsg);
            }

        }

        private void dummy(object sender, EventArgs e)
        {
            MessageBox.Show("Registred from Dummy!!!");
        }

        private void Subscribe(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulation for subscribing!!!");
        }
    }
}
