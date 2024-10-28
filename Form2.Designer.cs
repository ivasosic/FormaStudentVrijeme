namespace FormaStudent
{
    partial class Form2
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
            this.Ime = new System.Windows.Forms.TextBox();
            this.Prezime = new System.Windows.Forms.TextBox();
            this.indeks = new System.Windows.Forms.TextBox();
            this.snimibtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.smjer = new System.Windows.Forms.ComboBox();
            this.redov = new System.Windows.Forms.RadioButton();
            this.izvan = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ime
            // 
            this.Ime.Location = new System.Drawing.Point(36, 79);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(183, 20);
            this.Ime.TabIndex = 0;
            this.Ime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Prezime
            // 
            this.Prezime.Location = new System.Drawing.Point(36, 162);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(183, 20);
            this.Prezime.TabIndex = 1;
            this.Prezime.TextChanged += new System.EventHandler(this.Prezime_TextChanged);
            // 
            // indeks
            // 
            this.indeks.Location = new System.Drawing.Point(319, 79);
            this.indeks.Name = "indeks";
            this.indeks.Size = new System.Drawing.Size(203, 20);
            this.indeks.TabIndex = 3;
            this.indeks.TextChanged += new System.EventHandler(this.indeks_TextChanged);
            // 
            // snimibtn
            // 
            this.snimibtn.Location = new System.Drawing.Point(36, 315);
            this.snimibtn.Name = "snimibtn";
            this.snimibtn.Size = new System.Drawing.Size(75, 23);
            this.snimibtn.TabIndex = 5;
            this.snimibtn.Text = "Snimi";
            this.snimibtn.UseVisualStyleBackColor = true;
            this.snimibtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Otkazi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Smjer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Broj indeksa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Datum rodenja";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(322, 162);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 12;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // smjer
            // 
            this.smjer.FormattingEnabled = true;
            this.smjer.Location = new System.Drawing.Point(36, 246);
            this.smjer.Name = "smjer";
            this.smjer.Size = new System.Drawing.Size(183, 21);
            this.smjer.TabIndex = 13;
            this.smjer.SelectedIndexChanged += new System.EventHandler(this.smjer_SelectedIndexChanged);
            // 
            // redov
            // 
            this.redov.AutoSize = true;
            this.redov.Location = new System.Drawing.Point(6, 42);
            this.redov.Name = "redov";
            this.redov.Size = new System.Drawing.Size(65, 17);
            this.redov.TabIndex = 14;
            this.redov.TabStop = true;
            this.redov.Text = "Redovni";
            this.redov.UseVisualStyleBackColor = true;
            this.redov.CheckedChanged += new System.EventHandler(this.redov_CheckedChanged);
            // 
            // izvan
            // 
            this.izvan.AutoSize = true;
            this.izvan.Location = new System.Drawing.Point(6, 19);
            this.izvan.Name = "izvan";
            this.izvan.Size = new System.Drawing.Size(74, 17);
            this.izvan.TabIndex = 15;
            this.izvan.TabStop = true;
            this.izvan.Text = "Izvanredni";
            this.izvan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.izvan);
            this.groupBox1.Controls.Add(this.redov);
            this.groupBox1.Location = new System.Drawing.Point(322, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 68);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vrsta studija:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 406);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.smjer);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.snimibtn);
            this.Controls.Add(this.indeks);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.Ime);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.TextBox Prezime;
        private System.Windows.Forms.TextBox indeks;
        private System.Windows.Forms.Button snimibtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox smjer;
        private System.Windows.Forms.RadioButton redov;
        private System.Windows.Forms.RadioButton izvan;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}