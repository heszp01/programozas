using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.feladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Kilepbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Szamitbtn_Click(object sender, EventArgs e)
        {
            int[] szam = new int[2];
            szam[0] = int.Parse(számtxt.Text);
            szam[1] = int.Parse(négyzettxt.Text);
            számtxt.Text = Convert.ToString(szam[0]);
            négyzettxt.Text = Convert.ToString(szam[1]);
        }
    }
}
