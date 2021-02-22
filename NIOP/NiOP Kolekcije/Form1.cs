using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiOP_Kolekcije

   
{
    
    public partial class Form1 : Form
    {
        List<Brkovi> lista = new List<Brkovi>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Brkovi brk = new Brkovi(textBox1.Text, textBox2.Text,
                    Convert.ToInt32(textBox3.Text),
                    Convert.ToString(comboBox1.SelectedItem));


                lista.Add(brk);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

            }
            catch (Exception greska)
                {
                MessageBox.Show("Greška");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Podatak 1" + "\t" + "Podatak 2 "
                + "\t" + "Podatak 3" + "\t" + "Podatak 4" + "\r\n";
            //richTextBox1.Text="Poda"
            foreach (Brkovi brk in lista)
            {
                richTextBox1.AppendText(brk.ToString()); 

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Brkovi brk in lista)
            {
                if(brk)
            }
        }
    }
}
