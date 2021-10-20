using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnszamol_Click(object sender, EventArgs e)
        {
            try
            {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            double c = double.Parse(txtc.Text);
            if (a>0 && b>0 && c>0)
            {
                    double terfogat = a * b * c;
                    double felszin = 2 * a * b + 2 * a * c + 2 * b * c;
                    txtV.Text = terfogat.ToString();
                    txtfelszin.Text = Convert.ToString(felszin);
            }
            else
            {
                MessageBox.Show("nem jó számot adtál meg");
            }
            }
            catch (Exception)
            {

                MessageBox.Show("nem számot adtál meg");
            }

        }

        private void Btnkilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
