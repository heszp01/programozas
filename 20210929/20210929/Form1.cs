using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210929
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            evszaklbl.Text = tb.Text;
        }

        private void Kilepbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Evszakbtn_Click(object sender, EventArgs e)
        {
            string honap = evszaklbl.Text;
            switch (honap)
            {
                case "1":
                    evszaklbl.Text












            }
        }
    }
}
