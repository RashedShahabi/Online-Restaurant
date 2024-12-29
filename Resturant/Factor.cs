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
    public partial class Factor : Form
    {
        public Factor()
        {
            InitializeComponent();
        }

        private void Factor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resturanDataSet.Rezerv' table. You can move, or remove it, as needed.
            this.rezervTableAdapter.Fill(this.resturanDataSet.Rezerv);
            // TODO: This line of code loads data into the 'resturanDataSet.Rezerv' table. You can move, or remove it, as needed.
            this.rezervTableAdapter.Fill(this.resturanDataSet.Rezerv);

        }
    }
}
