using System;

namespace _20211013
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnszamol = new System.Windows.Forms.Button();
            this.btnkilep = new System.Windows.Forms.Button();
            this.lbla = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.lblv = new System.Windows.Forms.Label();
            this.lvlA = new System.Windows.Forms.Label();
            this.txtV = new System.Windows.Forms.TextBox();
            this.txtfelszin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnszamol
            // 
            this.btnszamol.Location = new System.Drawing.Point(219, 341);
            this.btnszamol.Name = "btnszamol";
            this.btnszamol.Size = new System.Drawing.Size(75, 23);
            this.btnszamol.TabIndex = 0;
            this.btnszamol.Text = "számolás";
            this.btnszamol.UseVisualStyleBackColor = true;
            this.btnszamol.Click += new System.EventHandler(this.Btnszamol_Click);
            // 
            // btnkilep
            // 
            this.btnkilep.Location = new System.Drawing.Point(472, 341);
            this.btnkilep.Name = "btnkilep";
            this.btnkilep.Size = new System.Drawing.Size(75, 23);
            this.btnkilep.TabIndex = 1;
            this.btnkilep.Text = "kilépés";
            this.btnkilep.UseVisualStyleBackColor = true;
            this.btnkilep.Click += new System.EventHandler(this.Btnkilep_Click);
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(149, 98);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(13, 13);
            this.lbla.TabIndex = 2;
            this.lbla.Text = "a";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(149, 124);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(13, 13);
            this.lblb.TabIndex = 3;
            this.lblb.Text = "b";
            this.lblb.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(149, 150);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(13, 13);
            this.lblc.TabIndex = 4;
            this.lblc.Text = "c";
            this.lblc.Click += new System.EventHandler(this.Label3_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(219, 95);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 5;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(219, 121);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 6;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(219, 147);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 20);
            this.txtc.TabIndex = 7;
            // 
            // lblv
            // 
            this.lblv.AutoSize = true;
            this.lblv.Location = new System.Drawing.Point(431, 111);
            this.lblv.Name = "lblv";
            this.lblv.Size = new System.Drawing.Size(17, 13);
            this.lblv.TabIndex = 8;
            this.lblv.Text = "V:";
            // 
            // lvlA
            // 
            this.lvlA.AutoSize = true;
            this.lvlA.Location = new System.Drawing.Point(431, 137);
            this.lvlA.Name = "lvlA";
            this.lvlA.Size = new System.Drawing.Size(17, 13);
            this.lvlA.TabIndex = 9;
            this.lvlA.Text = "A:";
            // 
            // txtV
            // 
            this.txtV.Enabled = false;
            this.txtV.Location = new System.Drawing.Point(472, 108);
            this.txtV.Name = "txtV";
            this.txtV.Size = new System.Drawing.Size(100, 20);
            this.txtV.TabIndex = 10;
            // 
            // txtfelszin
            // 
            this.txtfelszin.Enabled = false;
            this.txtfelszin.Location = new System.Drawing.Point(472, 134);
            this.txtfelszin.Name = "txtfelszin";
            this.txtfelszin.Size = new System.Drawing.Size(100, 20);
            this.txtfelszin.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtfelszin);
            this.Controls.Add(this.txtV);
            this.Controls.Add(this.lvlA);
            this.Controls.Add(this.lblv);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.btnkilep);
            this.Controls.Add(this.btnszamol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnszamol;
        private System.Windows.Forms.Button btnkilep;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label lblv;
        private System.Windows.Forms.Label lvlA;
        private System.Windows.Forms.TextBox txtV;
        private System.Windows.Forms.TextBox txtfelszin;
    }
}

