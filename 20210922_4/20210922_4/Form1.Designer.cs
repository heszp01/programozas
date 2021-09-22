namespace _20210922_4
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
            this.lblelsö = new System.Windows.Forms.Label();
            this.lblmásodik = new System.Windows.Forms.Label();
            this.lblharmadik = new System.Windows.Forms.Label();
            this.btnbezár = new System.Windows.Forms.Button();
            this.btnrendez = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblelsö
            // 
            this.lblelsö.AutoSize = true;
            this.lblelsö.Location = new System.Drawing.Point(186, 143);
            this.lblelsö.Name = "lblelsö";
            this.lblelsö.Size = new System.Drawing.Size(57, 13);
            this.lblelsö.TabIndex = 0;
            this.lblelsö.Text = "Elsö szám:";
            // 
            // lblmásodik
            // 
            this.lblmásodik.AutoSize = true;
            this.lblmásodik.Location = new System.Drawing.Point(186, 206);
            this.lblmásodik.Name = "lblmásodik";
            this.lblmásodik.Size = new System.Drawing.Size(77, 13);
            this.lblmásodik.TabIndex = 1;
            this.lblmásodik.Text = "Második szám:";
            // 
            // lblharmadik
            // 
            this.lblharmadik.AutoSize = true;
            this.lblharmadik.Location = new System.Drawing.Point(186, 273);
            this.lblharmadik.Name = "lblharmadik";
            this.lblharmadik.Size = new System.Drawing.Size(82, 13);
            this.lblharmadik.TabIndex = 2;
            this.lblharmadik.Text = "Harmadik szám:";
            // 
            // btnbezár
            // 
            this.btnbezár.Location = new System.Drawing.Point(499, 385);
            this.btnbezár.Name = "btnbezár";
            this.btnbezár.Size = new System.Drawing.Size(75, 23);
            this.btnbezár.TabIndex = 3;
            this.btnbezár.Text = "bezár";
            this.btnbezár.UseVisualStyleBackColor = true;
            this.btnbezár.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnrendez
            // 
            this.btnrendez.Location = new System.Drawing.Point(189, 385);
            this.btnrendez.Name = "btnrendez";
            this.btnrendez.Size = new System.Drawing.Size(75, 23);
            this.btnrendez.TabIndex = 4;
            this.btnrendez.Text = "rendez";
            this.btnrendez.UseVisualStyleBackColor = true;
            this.btnrendez.Click += new System.EventHandler(this.Btnrendez_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(499, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(499, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(499, 266);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnrendez);
            this.Controls.Add(this.btnbezár);
            this.Controls.Add(this.lblharmadik);
            this.Controls.Add(this.lblmásodik);
            this.Controls.Add(this.lblelsö);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblelsö;
        private System.Windows.Forms.Label lblmásodik;
        private System.Windows.Forms.Label lblharmadik;
        private System.Windows.Forms.Button btnbezár;
        private System.Windows.Forms.Button btnrendez;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

