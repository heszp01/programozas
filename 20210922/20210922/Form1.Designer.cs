namespace _20210922
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
            this.körbtn = new System.Windows.Forms.Button();
            this.gömbbtn = new System.Windows.Forms.Button();
            this.lblkerulet = new System.Windows.Forms.Label();
            this.lblterulet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // körbtn
            // 
            this.körbtn.Location = new System.Drawing.Point(224, 306);
            this.körbtn.Name = "körbtn";
            this.körbtn.Size = new System.Drawing.Size(75, 23);
            this.körbtn.TabIndex = 0;
            this.körbtn.Text = "kör";
            this.körbtn.UseVisualStyleBackColor = true;
            this.körbtn.Click += new System.EventHandler(this.Körbtn_Click);
            // 
            // gömbbtn
            // 
            this.gömbbtn.Location = new System.Drawing.Point(494, 306);
            this.gömbbtn.Name = "gömbbtn";
            this.gömbbtn.Size = new System.Drawing.Size(75, 23);
            this.gömbbtn.TabIndex = 1;
            this.gömbbtn.Text = "gömb";
            this.gömbbtn.UseVisualStyleBackColor = true;
            this.gömbbtn.Click += new System.EventHandler(this.Gömbbtn_Click);
            // 
            // lblkerulet
            // 
            this.lblkerulet.AutoSize = true;
            this.lblkerulet.Location = new System.Drawing.Point(221, 227);
            this.lblkerulet.Name = "lblkerulet";
            this.lblkerulet.Size = new System.Drawing.Size(63, 13);
            this.lblkerulet.TabIndex = 2;
            this.lblkerulet.Text = "kör kerülete";
            // 
            // lblterulet
            // 
            this.lblterulet.AutoSize = true;
            this.lblterulet.Location = new System.Drawing.Point(491, 227);
            this.lblterulet.Name = "lblterulet";
            this.lblterulet.Size = new System.Drawing.Size(60, 13);
            this.lblterulet.TabIndex = 3;
            this.lblterulet.Text = "kör területe";
            this.lblterulet.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "sugár";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(494, 265);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(224, 265);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblterulet);
            this.Controls.Add(this.lblkerulet);
            this.Controls.Add(this.gömbbtn);
            this.Controls.Add(this.körbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button körbtn;
        private System.Windows.Forms.Button gömbbtn;
        private System.Windows.Forms.Label lblkerulet;
        private System.Windows.Forms.Label lblterulet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

