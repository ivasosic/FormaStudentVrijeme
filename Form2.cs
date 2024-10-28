using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormaStudent
{
    public partial class Form2 : Form

    {
  
      public Student Student1 { get; set; }

        public Form2()
        {

            InitializeComponent();

            smjer.Items.Add("Programer");
            smjer.Items.Add("Mrežni admin");
            smjer.Items.Add("System admin");
        }

        public Form2(string text1, string text2, string text3, string text4)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studijTip = redov.Checked ? "R" : "I"; 

            Student1 = new Student(
                Ime.Text,
                Prezime.Text,
                indeks.Text,
                smjer.SelectedItem.ToString(),
                date.Value,
                studijTip
            ); 

           this.DialogResult = DialogResult.OK;
           this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void smjer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void redov_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Prezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void indeks_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
