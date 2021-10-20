using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _202110202
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnkilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btntorles_Click(object sender, EventArgs e)
        {
            txtszoveg.Text = "";
            lbxeredmeny.Items.Clear();
        }

        private void Btnszoveg_Click(object sender, EventArgs e)
        {
            if (txtszoveg.Text!="")
            {
                string[] darabok = txtszoveg.Text.Trim().Split(' ');
                foreach (string item in darabok)
                {
                    lbxeredmeny.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Nem adtál meg szöveget!!!!");
            }
        }

        private void Btnkiiras_Click(object sender, EventArgs e)
        {
            if (lbxeredmeny.Items.Count==0)
            {
                MessageBox.Show("nics semmi he!!!");
            }
            else
            {
                if (File.Exists("szavak.txt"))
                    {
                        File.Delete("szavak.txt");
                    }
                for (int i = 0; i < lbxeredmeny.Items.Count; i++)
                {
                    File.AppendAllText("szavak.txt", lbxeredmeny.Items[i].ToString()+"\n");
                    
                }
            }
        }
    }
}
