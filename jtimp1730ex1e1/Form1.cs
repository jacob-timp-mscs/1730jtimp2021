using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jtimp1730ex1e1
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtAvgTest.Text = "";
            txtTest1.Text = "0";
            txtTest2.Text = "0";
            txtTest3.Text = "0";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtAvgTest.Text = 
                ((Convert.ToDecimal(txtTest1.Text) + Convert.ToDecimal(txtTest2.Text) + Convert.ToDecimal(txtTest3.Text)) / 3)
                .ToString("0.00");
        }
    }
}
