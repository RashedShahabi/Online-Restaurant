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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            try
            {
                if(comtype.Text=="غذا")
                {
                    foodTableAdapter.Insert(int.Parse(txtfoodCode.Text), txtfoodName.Text, int.Parse(txtUnitPrice.Text), int.Parse(txtcount.Text),comtype.Text);
                    foodTableAdapter.Fill(resturanDataSet.Food);
                    foodDataGridView.DataSource = resturanDataSet.Food;
                    MessageBox.Show("اطلاعات با موفقیت ذخیره شد", "پیام سامانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (comtype.Text == "دسر")
                {
                    deserTableAdapter.Insert(int.Parse(txtfoodCode.Text), txtfoodName.Text, int.Parse(txtUnitPrice.Text), int.Parse(txtcount.Text), comtype.Text);
                    deserTableAdapter.Fill(resturanDataSet.Deser);
                    foodDataGridView.DataSource = resturanDataSet.Deser;
                    MessageBox.Show("اطلاعات با موفقیت ذخیره شد", "پیام سامانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (comtype.Text == "نوشیدنی")
                {
                    milkTableAdapter.Insert(int.Parse(txtfoodCode.Text), txtfoodName.Text, int.Parse(txtUnitPrice.Text), int.Parse(txtcount.Text), comtype.Text);
                    milkTableAdapter.Fill(resturanDataSet.Milk);
                    foodDataGridView.DataSource = resturanDataSet.Milk;
                    MessageBox.Show("اطلاعات با موفقیت ذخیره شد", "پیام سامانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (comtype.Text == "مخلفات")
                {
                    mokhalafatTableAdapter.Insert(int.Parse(txtfoodCode.Text), txtfoodName.Text, int.Parse(txtUnitPrice.Text), int.Parse(txtcount.Text), comtype.Text);
                    mokhalafatTableAdapter.Fill(resturanDataSet.Mokhalafat);
                    foodDataGridView.DataSource = resturanDataSet.Mokhalafat;
                    MessageBox.Show("اطلاعات با موفقیت ذخیره شد", "پیام سامانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("خطا در ثبت اطلاعات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resturanDataSet.Desk' table. You can move, or remove it, as needed.
            this.deskTableAdapter.Fill(this.resturanDataSet.Desk);
            // TODO: This line of code loads data into the 'resturanDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.resturanDataSet.Client);
            // TODO: This line of code loads data into the 'resturanDataSet.Deser' table. You can move, or remove it, as needed.
            this.deserTableAdapter.Fill(this.resturanDataSet.Deser);
            // TODO: This line of code loads data into the 'resturanDataSet.Mokhalafat' table. You can move, or remove it, as needed.
            this.mokhalafatTableAdapter.Fill(this.resturanDataSet.Mokhalafat);
            // TODO: This line of code loads data into the 'resturanDataSet.Milk' table. You can move, or remove it, as needed.
            this.milkTableAdapter.Fill(this.resturanDataSet.Milk);
            // TODO: This line of code loads data into the 'resturanDataSet.Food' table. You can move, or remove it, as needed.
            this.foodTableAdapter.Fill(this.resturanDataSet.Food);

        }

        private void foodDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtfoodCode.Text = foodDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtfoodName.Text = foodDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtUnitPrice.Text = foodDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcount.Text = foodDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            comtype.Text = foodDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtfoodCode.Enabled = false;
        }

        private void btnUpdateGoods_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (comtype.Text == "غذا")
                {
                    foodTableAdapter.UpdateQuery(txtfoodName.Text, int.Parse(txtUnitPrice.Text), int.Parse(txtcount.Text), comtype.Text, int.Parse(txtfoodCode.Text));
                    foodTableAdapter.Fill(resturanDataSet.Food);
                    foodDataGridView.DataSource = resturanDataSet.Food;
                    MessageBox.Show("اطلاعات با موفقیت ویرایش شد", "پیام سامانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtfoodCode.Enabled = true;
                }
                else if (comtype.Text == "دسر")
                {
                    deserTableAdapter.UpdateQuery(txtfoodName.Text, int.Parse(txtUnitPrice.Text), int.Parse(txtcount.Text), comtype.Text, int.Parse(txtfoodCode.Text));
                    deserTableAdapter.Fill(resturanDataSet.Deser);
                    foodDataGridView.DataSource = resturanDataSet.Deser;
                    MessageBox.Show("اطلاعات با موفقیت ویرایش شد", "پیام سامانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtfoodCode.Enabled = true;
                }
                else if (comtype.Text == "نوشیدنی")
                {
                    milkTableAdapter.UpdateQuery(txtfoodName.Text, int.Parse(txtUnitPrice.Text), int.Parse(txtcount.Text), comtype.Text, int.Parse(txtfoodCode.Text));
                    milkTableAdapter.Fill(resturanDataSet.Milk);
                    foodDataGridView.DataSource = resturanDataSet.Milk;
                    MessageBox.Show("اطلاعات با موفقیت ویرایش شد", "پیام سامانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtfoodCode.Enabled = true;
                }
                else if (comtype.Text == "مخلفات")
                {
                    mokhalafatTableAdapter.UpdateQuery(txtfoodName.Text, int.Parse(txtUnitPrice.Text), int.Parse(txtcount.Text), comtype.Text, int.Parse(txtfoodCode.Text));
                    mokhalafatTableAdapter.Fill(resturanDataSet.Mokhalafat);
                    foodDataGridView.DataSource = resturanDataSet.Mokhalafat;
                    MessageBox.Show("اطلاعات با موفقیت ویرایش شد", "پیام سامانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtfoodCode.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("خطا در ویرایش اطلاعات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteGoods_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا میخواهید حذف کنید؟", "پیام سامانه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (comtype.Text == "غذا")
                    {
                        foodTableAdapter.DeleteQuery(int.Parse(txtfoodCode.Text));
                        foodTableAdapter.Fill(resturanDataSet.Food);
                        foodDataGridView.DataSource = resturanDataSet.Food;
                        MessageBox.Show("اطلاعات با موفقیت حذف شد", "پیام سامانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (comtype.Text == "دسر")
                    {
                        deserTableAdapter.DeleteQuery(int.Parse(txtfoodCode.Text));
                        deserTableAdapter.Fill(resturanDataSet.Deser);
                        foodDataGridView.DataSource = resturanDataSet.Deser;
                        MessageBox.Show("اطلاعات با موفقیت حذف شد", "پیام سامانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (comtype.Text == "نوشیدنی")
                    {
                        milkTableAdapter.DeleteQuery(int.Parse(txtfoodCode.Text));
                        milkTableAdapter.Fill(resturanDataSet.Milk);
                        foodDataGridView.DataSource = resturanDataSet.Milk;
                        MessageBox.Show("اطلاعات با موفقیت حذف شد", "پیام سامانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (comtype.Text == "مخلفات")
                    {
                        mokhalafatTableAdapter.DeleteQuery(int.Parse(txtfoodCode.Text));
                        mokhalafatTableAdapter.Fill(resturanDataSet.Mokhalafat);
                        foodDataGridView.DataSource = resturanDataSet.Mokhalafat;
                        MessageBox.Show("اطلاعات با موفقیت حذف شد", "پیام سامانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("خطا در حذف اطلاعات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearGoods_Click(object sender, EventArgs e)
        {
            txtfoodCode.Enabled = true;
            txtfoodCode.Clear();
            txtfoodName.Clear();
            txtUnitPrice.Clear();
            txtcount.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comtype.Text == "غذا")
            {
                foodDataGridView.DataSource = resturanDataSet.Food;
            }
            else if (comtype.Text == "دسر")
            {
                foodDataGridView.DataSource = resturanDataSet.Deser;
            }
            else if (comtype.Text == "نوشیدنی")
            {
                foodDataGridView.DataSource = resturanDataSet.Milk;
            }
            else if (comtype.Text == "مخلفات")
            {
                foodDataGridView.DataSource = resturanDataSet.Mokhalafat;
            }
        }
        //***************************************************************************************
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                clientTableAdapter.InsertQuery(txtcodeclient.Text, txtnameclient.Text, txtfamilyclient.Text, txtCustomerPhone.Text);
                clientTableAdapter.Fill(resturanDataSet.Client);
                customerdataGridView.DataSource = resturanDataSet.Client;
                MessageBox.Show("اطلاعات با موفقیت ذخیره شد", "پیام سامانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("خطا در ثبت اطلاعات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا میخواهید حذف کنید؟", "پیام سامانه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    clientTableAdapter.DeleteQuery(txtcodeclient.Text);
                    clientTableAdapter.Fill(resturanDataSet.Client);
                    customerdataGridView.DataSource = resturanDataSet.Client;
                    MessageBox.Show("اطلاعات با موفقیت حذف شد", "پیام سامانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("خطا در حذف اطلاعات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                clientTableAdapter.UpdateQuery(txtnameclient.Text, txtfamilyclient.Text, txtCustomerPhone.Text,txtcodeclient.Text);
                clientTableAdapter.Fill(resturanDataSet.Client);
                customerdataGridView.DataSource = resturanDataSet.Client;
                MessageBox.Show("اطلاعات با موفقیت ویرایش شد", "پیام سامانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("خطا در ویرایش اطلاعات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customerdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           txtcodeclient.Text= customerdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnameclient.Text = customerdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtfamilyclient.Text = customerdataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCustomerPhone.Text = customerdataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtcodeclient.Enabled = false;
        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            txtcodeclient.Enabled = true;
            txtcodeclient.Clear();
            txtnameclient.Clear();
            txtfamilyclient.Clear();
            txtCustomerPhone.Clear();
        }
        //*********************************************************************************************
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {

                deskTableAdapter.InsertQuery(int.Parse(txtcod.Text),int.Parse(txtcapesity.Text),cmb.Text);
                deskTableAdapter.Fill(resturanDataSet.Desk);
                UserdataGridView.DataSource = resturanDataSet.Desk;
                MessageBox.Show("اطلاعات با موفقیت ذخیره شد", "پیام سامانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("خطا در ثبت اطلاعات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcod.Text = UserdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtcapesity.Text = UserdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmb.Text = UserdataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
           txtcod.Enabled = false;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {

                deskTableAdapter.UpdateQuery(int.Parse(txtcapesity.Text), cmb.Text, int.Parse(txtcod.Text));
                deskTableAdapter.Fill(resturanDataSet.Desk);
                UserdataGridView.DataSource = resturanDataSet.Desk;
                MessageBox.Show("اطلاعات با موفقیت ویرایش شد", "پیام سامانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("خطا در ویرایش اطلاعات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا میخواهید حذف کنید؟", "پیام سامانه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    deskTableAdapter.DeleteQuery(int.Parse(txtcod.Text));
                    deskTableAdapter.Fill(resturanDataSet.Desk);
                    UserdataGridView.DataSource = resturanDataSet.Desk;
                    MessageBox.Show("اطلاعات با موفقیت حذف شد", "پیام سامانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("خطا در حذف اطلاعات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearUser_Click(object sender, EventArgs e)
        {
            txtcod.Clear();
            txtcapesity.Clear();
            txtcod.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
