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

namespace _20211103
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

        private void Mentesbtn_Click(object sender, EventArgs e)
        {
            if (evtxt.Text!="" && nevtxt.Text!="" && szhtxt.Text!="" & orszagtxt.Text!="")
            {
                if (int.Parse(evtxt.Text)<1989)
                {
                    MessageBox.Show("hiba rosz évszám kuglifejü" ,"mentés");
                }
                else
                {
                    try
                    {
                        File.WriteAllText("uj_dijazott.txt", "Év;Név;SzületésHalálozás;országkód");
                        string kiir = evtxt.Text + ";" + nevtxt.Text + ";" + szhtxt.Text + ";" + orszagtxt.Text + ";" + ();
                        File.AppendAllText("uj_dijazott.txt", kiir);
                        evtxt.Text = "";
                        nevtxt.Text = "";
                        szhtxt.Text = "";
                        orszagtxt.Text = "";
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("hiba az állomány irásánál");
                    }
                }
            }
            else
            {

            }
        }
    }
}
