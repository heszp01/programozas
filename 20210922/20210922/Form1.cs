using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210922
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Körbtn_Click(object sender, EventArgs e)
        {
            double sugar = double.Parse(textBox1.Text);
            lblkerulet.Text = "Kör kerülete";
            lblterulet.Text = "Kör területe";
            double kerulet = 2 * sugar * Math.PI;
            double terulet = Math.Pow(sugar, 2) * Math.PI;
            textBox3.Text =Convert.ToString (kerulet);
            textBox2.Text = Convert.ToString(terulet);


        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Gömbbtn_Click(object sender, EventArgs e)
        {
            double sugar = double.Parse(textBox1.Text);
            lblkerulet.Text = "gömb felszine";
            lblterulet.Text = "gömb térfogata";
            double felszin = 4 *Math.PI*Math.Pow(sugar, 2);
            double térfogata = 4*Math.PI/3*Math.Pow(sugar,3);
            textBox3.Text = Convert.ToString(felszin);
            textBox2.Text = Convert.ToString(térfogata);




        }
    }
}
