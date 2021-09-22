using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210922_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Btnrendez_Click(object sender, EventArgs e)
        {
            int[] szamok = new int[3];
            szamok[0] = int.Parse(textBox1.Text);
            szamok[1] = int.Parse(textBox2.Text);
            szamok[2] = int.Parse(textBox3.Text);
            Array.Sort(szamok);
            textBox1.Text = Convert.ToString(szamok[0]);
            textBox2.Text = Convert.ToString(szamok[1]);
            textBox3.Text = Convert.ToString(szamok[2]);
        }
    }
}
