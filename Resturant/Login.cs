using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Resturant
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resturanDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.resturanDataSet.Client);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (radadmin.Checked == true && txtUserName.Text == "admin" && txtPassword.Text == "1234")
            {
                AdminForm m = new AdminForm();
                m.Show();
                this.Hide();
            }
            else if (raduser.Checked == true)
            {
                string cont = (clientTableAdapter.ScalarQuery(txtUserName.Text, txtPassword.Text)).ToString();
                int x = int.Parse(cont);
                if (x > 0)
                {
                    Form1 m = new Form1(txtUserName.Text, txtPassword.Text);
                    m.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("نام کاربری یا کلمه عبور صحیح نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("نام کاربری یا کلمه عبور صحیح نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
