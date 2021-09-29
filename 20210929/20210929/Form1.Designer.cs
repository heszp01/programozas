namespace _20210929
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
            this.sorszamlbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.evszaklbl = new System.Windows.Forms.Label();
            this.evszakbtn = new System.Windows.Forms.Button();
            this.kilepbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sorszamlbl
            // 
            this.sorszamlbl.AutoSize = true;
            this.sorszamlbl.Location = new System.Drawing.Point(122, 72);
            this.sorszamlbl.Name = "sorszamlbl";
            this.sorszamlbl.Size = new System.Drawing.Size(89, 13);
            this.sorszamlbl.TabIndex = 0;
            this.sorszamlbl.Text = "Hónap sorszáma:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(418, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // evszaklbl
            // 
            this.evszaklbl.AutoSize = true;
            this.evszaklbl.Location = new System.Drawing.Point(323, 208);
            this.evszaklbl.Name = "evszaklbl";
            this.evszaklbl.Size = new System.Drawing.Size(35, 13);
            this.evszaklbl.TabIndex = 2;
            this.evszaklbl.Text = "label2";
            // 
            // evszakbtn
            // 
            this.evszakbtn.Location = new System.Drawing.Point(141, 288);
            this.evszakbtn.Name = "evszakbtn";
            this.evszakbtn.Size = new System.Drawing.Size(75, 23);
            this.evszakbtn.TabIndex = 3;
            this.evszakbtn.Text = "Évszak";
            this.evszakbtn.UseVisualStyleBackColor = true;
            // 
            // kilepbtn
            // 
            this.kilepbtn.Location = new System.Drawing.Point(469, 288);
            this.kilepbtn.Name = "kilepbtn";
            this.kilepbtn.Size = new System.Drawing.Size(75, 23);
            this.kilepbtn.TabIndex = 4;
            this.kilepbtn.Text = "Kilépés";
            this.kilepbtn.UseVisualStyleBackColor = true;
            this.kilepbtn.Click += new System.EventHandler(this.Kilepbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kilepbtn);
            this.Controls.Add(this.evszakbtn);
            this.Controls.Add(this.evszaklbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sorszamlbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sorszamlbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label evszaklbl;
        private System.Windows.Forms.Button evszakbtn;
        private System.Windows.Forms.Button kilepbtn;
    }
}

