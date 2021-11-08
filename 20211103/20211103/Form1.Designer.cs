namespace _20211103
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
            this.mentesbtn = new System.Windows.Forms.Button();
            this.evlbl = new System.Windows.Forms.Label();
            this.nevlbl = new System.Windows.Forms.Label();
            this.Szhlbl = new System.Windows.Forms.Label();
            this.orszaglbl = new System.Windows.Forms.Label();
            this.evtxt = new System.Windows.Forms.TextBox();
            this.nevtxt = new System.Windows.Forms.TextBox();
            this.szhtxt = new System.Windows.Forms.TextBox();
            this.orszagtxt = new System.Windows.Forms.TextBox();
            this.kilepbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mentesbtn
            // 
            this.mentesbtn.Location = new System.Drawing.Point(90, 355);
            this.mentesbtn.Name = "mentesbtn";
            this.mentesbtn.Size = new System.Drawing.Size(168, 23);
            this.mentesbtn.TabIndex = 0;
            this.mentesbtn.Text = "Adatok mentése";
            this.mentesbtn.UseVisualStyleBackColor = true;
            this.mentesbtn.Click += new System.EventHandler(this.Mentesbtn_Click);
            // 
            // evlbl
            // 
            this.evlbl.AutoSize = true;
            this.evlbl.Location = new System.Drawing.Point(87, 160);
            this.evlbl.Name = "evlbl";
            this.evlbl.Size = new System.Drawing.Size(23, 13);
            this.evlbl.TabIndex = 1;
            this.evlbl.Text = "Év:";
            // 
            // nevlbl
            // 
            this.nevlbl.AutoSize = true;
            this.nevlbl.Location = new System.Drawing.Point(87, 201);
            this.nevlbl.Name = "nevlbl";
            this.nevlbl.Size = new System.Drawing.Size(30, 13);
            this.nevlbl.TabIndex = 2;
            this.nevlbl.Text = "Név:";
            // 
            // Szhlbl
            // 
            this.Szhlbl.AutoSize = true;
            this.Szhlbl.Location = new System.Drawing.Point(87, 242);
            this.Szhlbl.Name = "Szhlbl";
            this.Szhlbl.Size = new System.Drawing.Size(35, 13);
            this.Szhlbl.TabIndex = 3;
            this.Szhlbl.Text = "Sz/H:";
            // 
            // orszaglbl
            // 
            this.orszaglbl.AutoSize = true;
            this.orszaglbl.Location = new System.Drawing.Point(87, 281);
            this.orszaglbl.Name = "orszaglbl";
            this.orszaglbl.Size = new System.Drawing.Size(40, 13);
            this.orszaglbl.TabIndex = 4;
            this.orszaglbl.Text = "Ország";
            // 
            // evtxt
            // 
            this.evtxt.Location = new System.Drawing.Point(158, 160);
            this.evtxt.Name = "evtxt";
            this.evtxt.Size = new System.Drawing.Size(100, 20);
            this.evtxt.TabIndex = 5;
            // 
            // nevtxt
            // 
            this.nevtxt.Location = new System.Drawing.Point(158, 198);
            this.nevtxt.Name = "nevtxt";
            this.nevtxt.Size = new System.Drawing.Size(100, 20);
            this.nevtxt.TabIndex = 6;
            // 
            // szhtxt
            // 
            this.szhtxt.Location = new System.Drawing.Point(158, 239);
            this.szhtxt.Name = "szhtxt";
            this.szhtxt.Size = new System.Drawing.Size(100, 20);
            this.szhtxt.TabIndex = 7;
            // 
            // orszagtxt
            // 
            this.orszagtxt.Location = new System.Drawing.Point(158, 274);
            this.orszagtxt.Name = "orszagtxt";
            this.orszagtxt.Size = new System.Drawing.Size(100, 20);
            this.orszagtxt.TabIndex = 8;
            // 
            // kilepbtn
            // 
            this.kilepbtn.Location = new System.Drawing.Point(90, 393);
            this.kilepbtn.Name = "kilepbtn";
            this.kilepbtn.Size = new System.Drawing.Size(168, 26);
            this.kilepbtn.TabIndex = 9;
            this.kilepbtn.Text = "Kilépés";
            this.kilepbtn.UseVisualStyleBackColor = true;
            this.kilepbtn.Click += new System.EventHandler(this.Kilepbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.kilepbtn);
            this.Controls.Add(this.orszagtxt);
            this.Controls.Add(this.szhtxt);
            this.Controls.Add(this.nevtxt);
            this.Controls.Add(this.evtxt);
            this.Controls.Add(this.orszaglbl);
            this.Controls.Add(this.Szhlbl);
            this.Controls.Add(this.nevlbl);
            this.Controls.Add(this.evlbl);
            this.Controls.Add(this.mentesbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mentesbtn;
        private System.Windows.Forms.Label evlbl;
        private System.Windows.Forms.Label nevlbl;
        private System.Windows.Forms.Label Szhlbl;
        private System.Windows.Forms.Label orszaglbl;
        private System.Windows.Forms.TextBox evtxt;
        private System.Windows.Forms.TextBox nevtxt;
        private System.Windows.Forms.TextBox szhtxt;
        private System.Windows.Forms.TextBox orszagtxt;
        private System.Windows.Forms.Button kilepbtn;
    }
}

