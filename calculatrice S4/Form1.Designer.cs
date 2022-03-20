namespace calculatrice_S4
{
    partial class Form1
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
            this.un.Click += new System.EventHandler(this.un_Click);
            // 
            // resultat
            // 
            this.resultat.Location = new System.Drawing.Point(31, 26);
            this.resultat.Name = "resultat";
            this.resultat.Size = new System.Drawing.Size(423, 23);
            this.resultat.TabIndex = 1;
            // 
            // deux
            // 
            this.deux.Location = new System.Drawing.Point(104, 69);
            this.deux.Name = "deux";
            this.deux.Size = new System.Drawing.Size(75, 32);
            this.deux.TabIndex = 2;
            this.deux.Text = "2";
            this.deux.UseVisualStyleBackColor = true;
            this.deux.Click += new System.EventHandler(this.deux_Click);
            // 
            // trois
            // 
            this.trois.Location = new System.Drawing.Point(185, 69);
            this.trois.Name = "trois";
            this.trois.Size = new System.Drawing.Size(75, 32);
            this.trois.TabIndex = 3;
            this.trois.Text = "3";
            this.trois.UseVisualStyleBackColor = true;
            this.trois.Click += new System.EventHandler(this.trois_Click);
            // 
            // quatre
            // 
            this.quatre.Location = new System.Drawing.Point(31, 107);
            this.quatre.Name = "quatre";
            this.quatre.Size = new System.Drawing.Size(67, 32);
            this.quatre.TabIndex = 4;
            this.quatre.Text = "4";
            this.quatre.UseVisualStyleBackColor = true;
            this.quatre.Click += new System.EventHandler(this.quatre_Click);
            // 
            // cinq
            // 
            this.cinq.Location = new System.Drawing.Point(104, 107);
            this.cinq.Name = "cinq";
            this.cinq.Size = new System.Drawing.Size(75, 32);
            this.cinq.TabIndex = 5;
            this.cinq.Text = "5";
            this.cinq.UseVisualStyleBackColor = true;
            this.cinq.Click += new System.EventHandler(this.cinq_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(185, 107);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(75, 32);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // sept
            // 
            this.sept.Location = new System.Drawing.Point(31, 145);
            this.sept.Name = "sept";
            this.sept.Size = new System.Drawing.Size(67, 34);
            this.sept.TabIndex = 7;
            this.sept.Text = "7";
            this.sept.UseVisualStyleBackColor = true;
            this.sept.Click += new System.EventHandler(this.sept_Click);
            // 
            // huit
            // 
            this.huit.Location = new System.Drawing.Point(104, 145);
            this.huit.Name = "huit";
            this.huit.Size = new System.Drawing.Size(75, 34);
            this.huit.TabIndex = 8;
            this.huit.Text = "8";
            this.huit.UseVisualStyleBackColor = true;
            this.huit.Click += new System.EventHandler(this.huit_Click);
            // 
            // neuf
            // 
            this.neuf.Location = new System.Drawing.Point(185, 145);
            this.neuf.Name = "neuf";
            this.neuf.Size = new System.Drawing.Size(75, 34);
            this.neuf.TabIndex = 9;
            this.neuf.Text = "9";
            this.neuf.UseVisualStyleBackColor = true;
            this.neuf.Click += new System.EventHandler(this.neuf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}