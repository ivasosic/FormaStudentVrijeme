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
    public partial class Form1 : Form
    {

        DateTime pocetno = DateTime.Now;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            DialogResult rez = frm.ShowDialog();

            if (rez == DialogResult.OK)
            {
                listBox1.Items.Add(frm.Student1.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void snimibtn_Click(object sender, EventArgs e)
        {

        }

        private void spremi_Click(object sender, EventArgs e)
        {
            const string sPath = "save.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in listBox1.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();

            MessageBox.Show("Lista spremljena!");
        }

        private void ucitaj_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Open ListBox Content";

                // Provjeri ako je oznaceno
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // prije sejvanja novi clear
                    listBox1.Items.Clear();

                    // otvori i procitaj
                    using (System.IO.StreamReader reader = new System.IO.StreamReader(openFileDialog.FileName))
                    {
                        string line;
                       
                        while ((line = reader.ReadLine()) != null)
                        {
                            listBox1.Items.Add(line); 
                        }
                    }

                    MessageBox.Show("Lista ucitana!");
                }
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear ();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Trenutno: " + DateTime.Now.ToLongTimeString();
            TimeSpan proteklo = new TimeSpan();
            proteklo = DateTime.Now - pocetno;
            toolStripStatusLabel1.Text = "Proteklo: " +
            proteklo.Hours.ToString() + ":" + proteklo.Minutes.ToString() + ":" + proteklo.Seconds.ToString();
        }
    }
}
