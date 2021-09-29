namespace _6.feladat
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
            this.számlbl = new System.Windows.Forms.Label();
            this.negyzetlbl = new System.Windows.Forms.Label();
            this.szamitbtn = new System.Windows.Forms.Button();
            this.kilepbtn = new System.Windows.Forms.Button();
            this.számtxt = new System.Windows.Forms.TextBox();
            this.négyzettxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // számlbl
            // 
            this.számlbl.AutoSize = true;
            this.számlbl.Location = new System.Drawing.Point(201, 69);
            this.számlbl.Name = "számlbl";
            this.számlbl.Size = new System.Drawing.Size(33, 13);
            this.számlbl.TabIndex = 0;
            this.számlbl.Text = "Szám";
            // 
            // negyzetlbl
            // 
            this.negyzetlbl.AutoSize = true;
            this.negyzetlbl.Location = new System.Drawing.Point(201, 150);
            this.negyzetlbl.Name = "negyzetlbl";
            this.negyzetlbl.Size = new System.Drawing.Size(69, 13);
            this.negyzetlbl.TabIndex = 1;
            this.negyzetlbl.Text = "Négyzetgyök";
            // 
            // szamitbtn
            // 
            this.szamitbtn.Location = new System.Drawing.Point(204, 288);
            this.szamitbtn.Name = "szamitbtn";
            this.szamitbtn.Size = new System.Drawing.Size(75, 23);
            this.szamitbtn.TabIndex = 2;
            this.szamitbtn.Text = "számitás";
            this.szamitbtn.UseVisualStyleBackColor = true;
            this.szamitbtn.Click += new System.EventHandler(this.Szamitbtn_Click);
            // 
            // kilepbtn
            // 
            this.kilepbtn.Location = new System.Drawing.Point(370, 288);
            this.kilepbtn.Name = "kilepbtn";
            this.kilepbtn.Size = new System.Drawing.Size(75, 23);
            this.kilepbtn.TabIndex = 3;
            this.kilepbtn.Text = "Kilépés";
            this.kilepbtn.UseVisualStyleBackColor = true;
            this.kilepbtn.Click += new System.EventHandler(this.Kilepbtn_Click);
            // 
            // számtxt
            // 
            this.számtxt.Location = new System.Drawing.Point(370, 66);
            this.számtxt.Name = "számtxt";
            this.számtxt.Size = new System.Drawing.Size(100, 20);
            this.számtxt.TabIndex = 4;
            // 
            // négyzettxt
            // 
            this.négyzettxt.Location = new System.Drawing.Point(370, 147);
            this.négyzettxt.Name = "négyzettxt";
            this.négyzettxt.Size = new System.Drawing.Size(100, 20);
            this.négyzettxt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.négyzettxt);
            this.Controls.Add(this.számtxt);
            this.Controls.Add(this.kilepbtn);
            this.Controls.Add(this.szamitbtn);
            this.Controls.Add(this.negyzetlbl);
            this.Controls.Add(this.számlbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label számlbl;
        private System.Windows.Forms.Label negyzetlbl;
        private System.Windows.Forms.Button szamitbtn;
        private System.Windows.Forms.Button kilepbtn;
        private System.Windows.Forms.TextBox számtxt;
        private System.Windows.Forms.TextBox négyzettxt;
    }
}

