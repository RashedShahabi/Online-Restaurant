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
    public partial class Form1 : Form
    {
        string id, name;
        public Form1(string n,string f)
        {
            this.id = n;
            this.name = f;
            InitializeComponent();
        }
        int p = 0; int s = 0;
        private void tx1_Enter(object sender, EventArgs e)
        {
            tx1.BackColor = Color.AliceBlue;
            tx2.Enabled = false;
        }

        private void tx1_Leave(object sender, EventArgs e)
        {
            tx1.BackColor = Color.White;
            DataRow[] foundRows;
            foundRows =resturanDataSet.Tables["food"].Select(" name = '"+ (comcodfood.Text)+" '");
            string price=foundRows[0]["price"].ToString();
            tx2.Text =(int.Parse(price)*(int.Parse(tx1.Text))).ToString();
            tx2.Enabled = false;
            listBox1.Items.Add(comcodfood.Text);
            listBox2.Items.Add(tx1.Text);
            listBox3.Items.Add(price);
            int a, b, c;
            a = Convert.ToInt32(tx1.Text);
            b = Convert.ToInt32(tx2.Text);
            c = a * b;
            listBox4.Items.Add(tx2.Text);
            p = p + 1;
            s = s + c;
        }

        private void tx2_Enter(object sender, EventArgs e)
        {
        }

        private void tx2_Leave(object sender, EventArgs e)
        {
            tx2.BackColor = Color.White;
            
        }

        private void tx3_Enter(object sender, EventArgs e)
        {
            tx3.BackColor = Color.AliceBlue;
        }

        private void tx3_Leave(object sender, EventArgs e)
        {
            tx3.BackColor = Color.White;
            DataRow[] foundRows;
            foundRows = resturanDataSet.Tables["Milk"].Select(" name = '" + (commilk.Text)+" '");
            string price = foundRows[0]["price"].ToString();
            tx4.Text = (int.Parse(price) * (int.Parse(tx3.Text))).ToString();
            tx4.Enabled = false;
            listBox1.Items.Add(commilk.Text);
            listBox2.Items.Add(tx3.Text);
            listBox3.Items.Add(price);
            int a, b, c;
            a = Convert.ToInt32(tx3.Text);
            b = Convert.ToInt32(price);
            c = a * b;
            listBox4.Items.Add(tx4.Text);
            p = p + 1;
            s = s + c;
        }

        private void tx4_Enter(object sender, EventArgs e)
        {
            tx4.BackColor = Color.AliceBlue;
        }

        private void tx4_Leave(object sender, EventArgs e)
        {
            tx4.BackColor = Color.White;
            listBox1.Items.Add(commilk.Text);
            listBox2.Items.Add(tx3.Text);
            listBox3.Items.Add(tx4.Text);
            int a, b, c;
            a = Convert.ToInt32(tx3.Text);
            b = Convert.ToInt32(tx4.Text);
            c = a * b;
            listBox4.Items.Add(Convert.ToString(c));
            p = p + 1;
            s = s + c;
        }

        private void tx5_Enter(object sender, EventArgs e)
        {
          // tx5.BackColor = Color.AliceBlue;
        }

        private void tx5_Leave(object sender, EventArgs e)
        {
           // tx5.BackColor = Color.White;
        }

        private void tx6_Enter(object sender, EventArgs e)
        {
           // tx6.BackColor = Color.AliceBlue;
        }

        private void tx6_Leave(object sender, EventArgs e)
        {
            
           
        }

        private void tx7_Enter(object sender, EventArgs e)
        {
            tx7.BackColor = Color.AliceBlue;
        }

        private void tx7_Leave(object sender, EventArgs e)
        {
            tx7.BackColor = Color.White;
            DataRow[] foundRows;
            foundRows = resturanDataSet.Tables["Mokhalafat"].Select(" name = '" + (commokhalafat.Text)+" '");
            string price = foundRows[0]["price"].ToString();
            tx8.Text = (int.Parse(price) * (int.Parse(tx7.Text))).ToString();
            tx8.Enabled = false;
            listBox1.Items.Add(commokhalafat.Text);
            listBox2.Items.Add(tx7.Text);
            listBox3.Items.Add(price);
            int a, b, c;
            a = Convert.ToInt32(tx7.Text);
            b = Convert.ToInt32(price);
            c = a * b;
            listBox4.Items.Add(tx8.Text);
            p = p + 1;
            s = s + c;
        }

        private void tx8_Enter(object sender, EventArgs e)
        {
            tx8.BackColor = Color.AliceBlue;
        }

        private void tx8_Leave(object sender, EventArgs e)
        {
            tx8.BackColor = Color.White;
            listBox1.Items.Add(commokhalafat.Text);
            listBox2.Items.Add(tx7.Text);
            listBox3.Items.Add(tx8.Text);
            int a, b, c;
            a = Convert.ToInt32(tx7.Text);
            b = Convert.ToInt32(tx8.Text);
            c = a * b;
            listBox4.Items.Add(Convert.ToString(c));
            p = p + 1;
            s = s + c;
        }

        private void tx9_Enter(object sender, EventArgs e)
        {
            tx9.BackColor = Color.AliceBlue;
        }

        private void tx9_Leave(object sender, EventArgs e)
        {
            tx9.BackColor = Color.White;
            DataRow[] foundRows;
            foundRows = resturanDataSet.Tables["Deser"].Select(" name = '" + (comdeser.Text)+" '");
            string price = foundRows[0]["price"].ToString();
            tx10.Text = (int.Parse(price) * (int.Parse(tx9.Text))).ToString();
            tx10.Enabled = false;
            listBox1.Items.Add(comdeser.Text);
            listBox2.Items.Add(tx9.Text);
            listBox3.Items.Add(price);
            int a, b, c;
            a = Convert.ToInt32(tx9.Text);
            b = Convert.ToInt32(price);
            c = a * b;
            listBox4.Items.Add(tx10.Text);
            p = p + 1;
            s = s + c;
        }

        private void tx10_Enter(object sender, EventArgs e)
        {
            tx10.BackColor = Color.AliceBlue;
        }

        private void tx10_Leave(object sender, EventArgs e)
        {
            tx10.BackColor = Color.White;
            listBox1.Items.Add(comdeser.Text);
            listBox2.Items.Add(tx9.Text);
            listBox3.Items.Add(tx10.Text);
            int a, b, c;
            a = Convert.ToInt32(tx9.Text);
            b = Convert.ToInt32(tx10.Text);
            c = a * b;
            listBox4.Items.Add(Convert.ToString(c));
            p = p + 1;
            s = s + c;
        }

        private void tx1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tx2.Focus();
        }

        private void tx2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                commilk.Focus();
        }

        private void tx3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tx4.Focus();
        }

        private void tx4_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void tx5_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void tx6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                commokhalafat.Focus();
        }

        private void tx7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tx8.Focus();
        }

        private void tx8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                comdeser.Focus();
        }

        private void tx9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tx10.Focus();
        }

        private void tx10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                listBox1.Focus();
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tx3.Focus();
        }

        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void comboBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tx7.Focus();
        }

        private void comboBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tx9.Focus();
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tx1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult s;
            s = MessageBox.Show("آیا مایلید خارج شوید ؟", " هشدار!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (s == DialogResult.Yes)
            {
                Login l = new Login();
                l.Show();
                this.Hide();
            }
            else MessageBox.Show("لطفا بیشتر احتیاط کنید", "توجه");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(s);
            textBox2.Text = Convert.ToString(p);

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Blue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
           
            button2.FlatStyle = FlatStyle.System;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Text);
            listBox2.Items.Remove(listBox2.Text);
            listBox3.Items.Remove(listBox3.Text);
            listBox4.Items.Remove(listBox4.Text);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Blue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.FlatStyle = FlatStyle.System;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Blue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.System;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Blue;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.FlatStyle = FlatStyle.System;
        }

        private void نوعغذاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comcodfood.Focus();
        }

        private void هزینهکلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(s);
            textBox2.Text = Convert.ToString(p);
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void نقرهایToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.Silver;
            tabPage2.BackColor = Color.Silver;
        }

        private void صورتیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.Pink;
            tabPage2.BackColor = Color.Pink;
        }

        private void نکمدادیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.LightGray;
            tabPage2.BackColor = Color.LightGray;
        }

        private void سبزچمنیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.GreenYellow;
            tabPage2.BackColor = Color.GreenYellow;
        }

        private void آبیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.Blue;
            tabPage2.BackColor = Color.Blue;
        }

        private void نارنجیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.Orange;
            tabPage2.BackColor = Color.Orange;
        }

        private void زردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.Yellow;
            tabPage2.BackColor = Color.Yellow;
        }

        private void حالتپیشفرضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.Snow;
            tabPage2.BackColor = Color.Yellow;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // comnamefood.Items.Add(t1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
           // comboBox2.Items.Add(t2.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
           // comboBox3.Items.Add(t3.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //comboBox4.Items.Add(t4.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //comboBox5.Items.Add(t5.Text);
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                x2.Focus();
            
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                x3.Focus();
           
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                x4.Focus();
            
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
           
           
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                x6.Focus();
            
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                x7.Focus();
            
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                listBox5.Focus();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string s=deskTableAdapter.ScalarQuery(int.Parse(comcoddesk.Text)).ToString();
                int x = int.Parse(s);
                if (x > 0)
                {
                    listBox5.Items.Add(x1.Text);
                    listBox5.Items.Add(x2.Text);
                    listBox5.Items.Add(x3.Text);
                    listBox5.Items.Add(x4.Text);
                    listBox5.Items.Add(x6.Text + " الی" + x7.Text);
                    rezervTableAdapter.InsertQuery(int.Parse(txtcodsefaresh.Text), int.Parse(comcoddesk.Text), x4.Text, x6.Text, x7.Text, id, comcodfood.Text,
                    int.Parse(tx1.Text), comdeser.Text, int.Parse(tx3.Text), commilk.Text, int.Parse(tx7.Text), commokhalafat.Text, int.Parse(tx9.Text));
                    MessageBox.Show("سفارش شما با موفقیت ثبت شد", "پیام سامانه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    deskTableAdapter.UpdateQuery1("پر",int.Parse(comcoddesk.Text));
                }
                else if(x==0)
                    MessageBox.Show("میز انتخابی شما قبلا رزرو شده است.میز دیگری انتخاب کنید!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("خطا در ذخیره اطلاعات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Factor f = new Factor();
            f.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resturanDataSet.Rezerv' table. You can move, or remove it, as needed.
            this.rezervTableAdapter.Fill(this.resturanDataSet.Rezerv);
            // TODO: This line of code loads data into the 'resturanDataSet.Desk' table. You can move, or remove it, as needed.
            this.deskTableAdapter.Fill(this.resturanDataSet.Desk);
            label3.Text = id + " " + name + " خوش آمدید";
            // TODO: This line of code loads data into the 'resturanDataSet.Deser' table. You can move, or remove it, as needed.
            this.deserTableAdapter.Fill(this.resturanDataSet.Deser);
            // TODO: This line of code loads data into the 'resturanDataSet.Mokhalafat' table. You can move, or remove it, as needed.
            this.mokhalafatTableAdapter.Fill(this.resturanDataSet.Mokhalafat);
            // TODO: This line of code loads data into the 'resturanDataSet.Milk' table. You can move, or remove it, as needed.
            this.milkTableAdapter.Fill(this.resturanDataSet.Milk);
            // TODO: This line of code loads data into the 'resturanDataSet.Food' table. You can move, or remove it, as needed.
            this.foodTableAdapter.Fill(this.resturanDataSet.Food);

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            x1.Text = id;
            x2.Text = name;
            x1.Enabled = false;
            x2.Enabled = false;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.deskTableAdapter.FillBy(this.resturanDataSet.Desk);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


















    }
}
