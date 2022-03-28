namespace calculatrice_S4
{
    partial class calculatrice
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.un = new System.Windows.Forms.Button();
            this.resultat = new System.Windows.Forms.TextBox();
            this.deux = new System.Windows.Forms.Button();
            this.trois = new System.Windows.Forms.Button();
            this.quatre = new System.Windows.Forms.Button();
            this.cinq = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.sept = new System.Windows.Forms.Button();
            this.huit = new System.Windows.Forms.Button();
            this.neuf = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.egale = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.sous = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // un
            // 
            this.un.Location = new System.Drawing.Point(31, 69);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(67, 32);
            this.un.TabIndex = 0;
            this.un.Text = "1";
            this.un.UseVisualStyleBackColor = true;
            this.un.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // resultat
            // 
            this.resultat.Location = new System.Drawing.Point(31, 26);
            this.resultat.Name = "resultat";
            this.resultat.Size = new System.Drawing.Size(423, 23);
            this.resultat.TabIndex = 1;
            this.resultat.TextChanged += new System.EventHandler(this.resultat_TextChanged);
            // 
            // deux
            // 
            this.deux.Location = new System.Drawing.Point(104, 69);
            this.deux.Name = "deux";
            this.deux.Size = new System.Drawing.Size(75, 32);
            this.deux.TabIndex = 2;
            this.deux.Text = "2";
            this.deux.UseVisualStyleBackColor = true;
            this.deux.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // trois
            // 
            this.trois.Location = new System.Drawing.Point(185, 69);
            this.trois.Name = "trois";
            this.trois.Size = new System.Drawing.Size(75, 32);
            this.trois.TabIndex = 3;
            this.trois.Text = "3";
            this.trois.UseVisualStyleBackColor = true;
            this.trois.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // quatre
            // 
            this.quatre.Location = new System.Drawing.Point(31, 107);
            this.quatre.Name = "quatre";
            this.quatre.Size = new System.Drawing.Size(67, 32);
            this.quatre.TabIndex = 4;
            this.quatre.Text = "4";
            this.quatre.UseVisualStyleBackColor = true;
            this.quatre.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // cinq
            // 
            this.cinq.Location = new System.Drawing.Point(104, 107);
            this.cinq.Name = "cinq";
            this.cinq.Size = new System.Drawing.Size(75, 32);
            this.cinq.TabIndex = 5;
            this.cinq.Text = "5";
            this.cinq.UseVisualStyleBackColor = true;
            this.cinq.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(185, 107);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(75, 32);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // sept
            // 
            this.sept.Location = new System.Drawing.Point(31, 145);
            this.sept.Name = "sept";
            this.sept.Size = new System.Drawing.Size(67, 34);
            this.sept.TabIndex = 7;
            this.sept.Text = "7";
            this.sept.UseVisualStyleBackColor = true;
            this.sept.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // huit
            // 
            this.huit.Location = new System.Drawing.Point(104, 145);
            this.huit.Name = "huit";
            this.huit.Size = new System.Drawing.Size(75, 34);
            this.huit.TabIndex = 8;
            this.huit.Text = "8";
            this.huit.UseVisualStyleBackColor = true;
            this.huit.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // neuf
            // 
            this.neuf.Location = new System.Drawing.Point(185, 145);
            this.neuf.Name = "neuf";
            this.neuf.Size = new System.Drawing.Size(75, 34);
            this.neuf.TabIndex = 9;
            this.neuf.Text = "9";
            this.neuf.UseVisualStyleBackColor = true;
            this.neuf.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(31, 182);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(67, 32);
            this.zero.TabIndex = 10;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(266, 69);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(67, 32);
            this.reset.TabIndex = 11;
            this.reset.Text = "C";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(104, 182);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(75, 32);
            this.point.TabIndex = 12;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // egale
            // 
            this.egale.Location = new System.Drawing.Point(185, 182);
            this.egale.Name = "egale";
            this.egale.Size = new System.Drawing.Size(75, 32);
            this.egale.TabIndex = 13;
            this.egale.Text = "=";
            this.egale.UseVisualStyleBackColor = true;
            this.egale.Click += new System.EventHandler(this.buttonEqual_onClick);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(266, 107);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(67, 32);
            this.add.TabIndex = 14;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // sous
            // 
            this.sous.Location = new System.Drawing.Point(266, 147);
            this.sous.Name = "sous";
            this.sous.Size = new System.Drawing.Size(67, 32);
            this.sous.TabIndex = 15;
            this.sous.Text = "-";
            this.sous.UseVisualStyleBackColor = true;
            this.sous.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(266, 182);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(67, 32);
            this.mul.TabIndex = 16;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(339, 69);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(67, 32);
            this.div.TabIndex = 17;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // calculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 226);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sous);
            this.Controls.Add(this.add);
            this.Controls.Add(this.egale);
            this.Controls.Add(this.point);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.neuf);
            this.Controls.Add(this.huit);
            this.Controls.Add(this.sept);
            this.Controls.Add(this.six);
            this.Controls.Add(this.cinq);
            this.Controls.Add(this.quatre);
            this.Controls.Add(this.un);
            this.Controls.Add(this.deux);
            this.Controls.Add(this.resultat);
            this.Controls.Add(this.trois);
            this.Name = "calculatrice";
            this.Text = "calculatrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button un;
        private TextBox resultat;
        private Button deux;
        private Button trois;
        private Button quatre;
        private Button cinq;
        private Button six;
        private Button sept;
        private Button huit;
        private Button neuf;
        private Button zero;
        private Button reset;
        private Button point;
        private Button egale;
        private Button add;
        private Button sous;
        private Button mul;
        private Button div;
    }
}