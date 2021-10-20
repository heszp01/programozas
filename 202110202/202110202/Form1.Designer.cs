namespace _202110202
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
            this.lblszoveg = new System.Windows.Forms.Label();
            this.txtszoveg = new System.Windows.Forms.TextBox();
            this.btnszoveg = new System.Windows.Forms.Button();
            this.lbxeredmeny = new System.Windows.Forms.ListBox();
            this.btnkilep = new System.Windows.Forms.Button();
            this.btntorles = new System.Windows.Forms.Button();
            this.btnkiiras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblszoveg
            // 
            this.lblszoveg.AutoSize = true;
            this.lblszoveg.Location = new System.Drawing.Point(103, 65);
            this.lblszoveg.Name = "lblszoveg";
            this.lblszoveg.Size = new System.Drawing.Size(95, 13);
            this.lblszoveg.TabIndex = 0;
            this.lblszoveg.Text = "Kérem a szöveget!";
            // 
            // txtszoveg
            // 
            this.txtszoveg.Location = new System.Drawing.Point(106, 93);
            this.txtszoveg.Name = "txtszoveg";
            this.txtszoveg.Size = new System.Drawing.Size(485, 20);
            this.txtszoveg.TabIndex = 1;
            // 
            // btnszoveg
            // 
            this.btnszoveg.Location = new System.Drawing.Point(106, 191);
            this.btnszoveg.Name = "btnszoveg";
            this.btnszoveg.Size = new System.Drawing.Size(146, 23);
            this.btnszoveg.TabIndex = 2;
            this.btnszoveg.Text = "Szövegtördelés";
            this.btnszoveg.UseVisualStyleBackColor = true;
            this.btnszoveg.Click += new System.EventHandler(this.Btnszoveg_Click);
            // 
            // lbxeredmeny
            // 
            this.lbxeredmeny.Enabled = false;
            this.lbxeredmeny.FormattingEnabled = true;
            this.lbxeredmeny.Location = new System.Drawing.Point(453, 153);
            this.lbxeredmeny.Name = "lbxeredmeny";
            this.lbxeredmeny.ScrollAlwaysVisible = true;
            this.lbxeredmeny.Size = new System.Drawing.Size(138, 225);
            this.lbxeredmeny.TabIndex = 3;
            // 
            // btnkilep
            // 
            this.btnkilep.Location = new System.Drawing.Point(106, 310);
            this.btnkilep.Name = "btnkilep";
            this.btnkilep.Size = new System.Drawing.Size(146, 23);
            this.btnkilep.TabIndex = 4;
            this.btnkilep.Text = "kilépés";
            this.btnkilep.UseVisualStyleBackColor = true;
            this.btnkilep.Click += new System.EventHandler(this.Btnkilep_Click);
            // 
            // btntorles
            // 
            this.btntorles.Location = new System.Drawing.Point(106, 230);
            this.btntorles.Name = "btntorles";
            this.btntorles.Size = new System.Drawing.Size(146, 23);
            this.btntorles.TabIndex = 5;
            this.btntorles.Text = "törlés";
            this.btntorles.UseVisualStyleBackColor = true;
            this.btntorles.Click += new System.EventHandler(this.Btntorles_Click);
            // 
            // btnkiiras
            // 
            this.btnkiiras.Location = new System.Drawing.Point(106, 270);
            this.btnkiiras.Name = "btnkiiras";
            this.btnkiiras.Size = new System.Drawing.Size(146, 23);
            this.btnkiiras.TabIndex = 6;
            this.btnkiiras.Text = "kiirás";
            this.btnkiiras.UseVisualStyleBackColor = true;
            this.btnkiiras.Click += new System.EventHandler(this.Btnkiiras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnkiiras);
            this.Controls.Add(this.btntorles);
            this.Controls.Add(this.btnkilep);
            this.Controls.Add(this.lbxeredmeny);
            this.Controls.Add(this.btnszoveg);
            this.Controls.Add(this.txtszoveg);
            this.Controls.Add(this.lblszoveg);
            this.Name = "Form1";
            this.Text = "szöveg tördelése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblszoveg;
        private System.Windows.Forms.TextBox txtszoveg;
        private System.Windows.Forms.Button btnszoveg;
        private System.Windows.Forms.ListBox lbxeredmeny;
        private System.Windows.Forms.Button btnkilep;
        private System.Windows.Forms.Button btntorles;
        private System.Windows.Forms.Button btnkiiras;
    }
}

