
namespace lab02_zad2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.wmala = new System.Windows.Forms.RadioButton();
            this.wduza = new System.Windows.Forms.RadioButton();
            this.wbduza = new System.Windows.Forms.RadioButton();
            this.pog = new System.Windows.Forms.CheckBox();
            this.poch = new System.Windows.Forms.CheckBox();
            this.pod = new System.Windows.Forms.CheckBox();
            this.czer = new System.Windows.Forms.RadioButton();
            this.nieb = new System.Windows.Forms.RadioButton();
            this.pom = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(111, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj Tkest";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "ox";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wbduza);
            this.groupBox1.Controls.Add(this.wduza);
            this.groupBox1.Controls.Add(this.wmala);
            this.groupBox1.Location = new System.Drawing.Point(120, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wielkość";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pod);
            this.groupBox2.Controls.Add(this.poch);
            this.groupBox2.Controls.Add(this.pog);
            this.groupBox2.Location = new System.Drawing.Point(321, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 159);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Styl Czcionki";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pom);
            this.groupBox3.Controls.Add(this.nieb);
            this.groupBox3.Controls.Add(this.czer);
            this.groupBox3.Location = new System.Drawing.Point(550, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 136);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pogrubienie";
            // 
            // wmala
            // 
            this.wmala.AutoSize = true;
            this.wmala.Location = new System.Drawing.Point(6, 23);
            this.wmala.Name = "wmala";
            this.wmala.Size = new System.Drawing.Size(51, 19);
            this.wmala.TabIndex = 5;
            this.wmala.TabStop = true;
            this.wmala.Text = "mala";
            this.wmala.UseVisualStyleBackColor = true;
            // 
            // wduza
            // 
            this.wduza.AutoSize = true;
            this.wduza.Location = new System.Drawing.Point(6, 48);
            this.wduza.Name = "wduza";
            this.wduza.Size = new System.Drawing.Size(50, 19);
            this.wduza.TabIndex = 0;
            this.wduza.TabStop = true;
            this.wduza.Text = "duza";
            this.wduza.UseVisualStyleBackColor = true;
            // 
            // wbduza
            // 
            this.wbduza.AutoSize = true;
            this.wbduza.Location = new System.Drawing.Point(6, 73);
            this.wbduza.Name = "wbduza";
            this.wbduza.Size = new System.Drawing.Size(89, 19);
            this.wbduza.TabIndex = 0;
            this.wbduza.TabStop = true;
            this.wbduza.Text = "bardzo duza";
            this.wbduza.UseVisualStyleBackColor = true;
            // 
            // pog
            // 
            this.pog.AutoSize = true;
            this.pog.Location = new System.Drawing.Point(6, 34);
            this.pog.Name = "pog";
            this.pog.Size = new System.Drawing.Size(90, 19);
            this.pog.TabIndex = 5;
            this.pog.Text = "Pogrubienie";
            this.pog.UseVisualStyleBackColor = true;
            // 
            // poch
            // 
            this.poch.AutoSize = true;
            this.poch.Location = new System.Drawing.Point(6, 59);
            this.poch.Name = "poch";
            this.poch.Size = new System.Drawing.Size(84, 19);
            this.poch.TabIndex = 6;
            this.poch.Text = "Pocyhelnie";
            this.poch.UseVisualStyleBackColor = true;
            // 
            // pod
            // 
            this.pod.AutoSize = true;
            this.pod.Location = new System.Drawing.Point(6, 84);
            this.pod.Name = "pod";
            this.pod.Size = new System.Drawing.Size(93, 19);
            this.pod.TabIndex = 7;
            this.pod.Text = "Podkreślenie";
            this.pod.UseVisualStyleBackColor = true;
            // 
            // czer
            // 
            this.czer.AutoSize = true;
            this.czer.Location = new System.Drawing.Point(6, 25);
            this.czer.Name = "czer";
            this.czer.Size = new System.Drawing.Size(77, 19);
            this.czer.TabIndex = 0;
            this.czer.TabStop = true;
            this.czer.Text = "Czerwony";
            this.czer.UseVisualStyleBackColor = true;
            // 
            // nieb
            // 
            this.nieb.AutoSize = true;
            this.nieb.Location = new System.Drawing.Point(6, 50);
            this.nieb.Name = "nieb";
            this.nieb.Size = new System.Drawing.Size(73, 19);
            this.nieb.TabIndex = 1;
            this.nieb.TabStop = true;
            this.nieb.Text = "Niebieski";
            this.nieb.UseVisualStyleBackColor = true;
            // 
            // pom
            // 
            this.pom.AutoSize = true;
            this.pom.Location = new System.Drawing.Point(6, 75);
            this.pom.Name = "pom";
            this.pom.Size = new System.Drawing.Size(106, 19);
            this.pom.TabIndex = 2;
            this.pom.TabStop = true;
            this.pom.Text = "Pomarańczowy";
            this.pom.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(244, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 82);
            this.button1.TabIndex = 5;
            this.button1.Text = "AKTUALIZUJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton wbduza;
        private System.Windows.Forms.RadioButton wduza;
        private System.Windows.Forms.RadioButton wmala;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox pod;
        private System.Windows.Forms.CheckBox poch;
        private System.Windows.Forms.CheckBox pog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton pom;
        private System.Windows.Forms.RadioButton nieb;
        private System.Windows.Forms.RadioButton czer;
        private System.Windows.Forms.Button button1;
    }
}

