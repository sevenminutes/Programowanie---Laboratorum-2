
using System;

namespace Lab02
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radiom = new System.Windows.Forms.RadioButton();
            this.radiok = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ideal = new System.Windows.Forms.CheckBox();
            this.standard = new System.Windows.Forms.CheckBox();
            this.Wynik = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj cm:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Podaj płeć:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_Text);
            // 
            // radiom
            // 
            this.radiom.AutoSize = true;
            this.radiom.Location = new System.Drawing.Point(226, 178);
            this.radiom.Name = "radiom";
            this.radiom.Size = new System.Drawing.Size(82, 19);
            this.radiom.TabIndex = 3;
            this.radiom.TabStop = true;
            this.radiom.Text = "mężczyzna";
            this.radiom.UseVisualStyleBackColor = true;
            this.radiom.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radiok
            // 
            this.radiok.AutoSize = true;
            this.radiok.Location = new System.Drawing.Point(326, 180);
            this.radiok.Name = "radiok";
            this.radiok.Size = new System.Drawing.Size(64, 19);
            this.radiok.TabIndex = 4;
            this.radiok.TabStop = true;
            this.radiok.Text = "kobieta";
            this.radiok.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ideal);
            this.groupBox1.Controls.Add(this.standard);
            this.groupBox1.Location = new System.Drawing.Point(578, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waga";
            // 
            // ideal
            // 
            this.ideal.AutoSize = true;
            this.ideal.Location = new System.Drawing.Point(21, 47);
            this.ideal.Name = "ideal";
            this.ideal.Size = new System.Drawing.Size(64, 19);
            this.ideal.TabIndex = 1;
            this.ideal.Text = "idealna";
            this.ideal.UseVisualStyleBackColor = true;
            this.ideal.CheckedChanged += new System.EventHandler(this.ideal_CheckedChanged);
            // 
            // standard
            // 
            this.standard.AutoSize = true;
            this.standard.Location = new System.Drawing.Point(21, 22);
            this.standard.Name = "standard";
            this.standard.Size = new System.Drawing.Size(94, 19);
            this.standard.TabIndex = 0;
            this.standard.Text = "standardowa";
            this.standard.UseVisualStyleBackColor = true;
            // 
            // Wynik
            // 
            this.Wynik.AutoSize = true;
            this.Wynik.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Wynik.Location = new System.Drawing.Point(57, 332);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(60, 21);
            this.Wynik.TabIndex = 6;
            this.Wynik.Text = "Wynik";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(326, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radiok);
            this.Controls.Add(this.radiom);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radiom;
        private System.Windows.Forms.RadioButton radiok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ideal;
        private System.Windows.Forms.CheckBox standard;
        private System.Windows.Forms.Label Wynik;
        private System.Windows.Forms.Button button1;
    }
}

