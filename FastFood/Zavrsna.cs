using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class Zavrsna : Form
    {
        public Zavrsna()
        {
            InitializeComponent();
        }

        private void Zavrsna_Load(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            Restoran1 r1 = new Restoran1();
            Restoran2 r2 = new Restoran2();
            Restoran3 r3 = new Restoran3();
            Restoran4 r4 = new Restoran4();

            List<string> listaa = new List<string>();
            foreach(var item in r1.res1)
            {
                richTextBox1.Text += item + " ";
            }
            foreach (var item in r2.res1)
            {
                richTextBox1.Text += item + " ";
            }
            foreach (var item in r3.res1)
            {
                richTextBox1.Text += item + " ";
            }
            foreach (var item in r4.res1)
            {
                richTextBox1.Text += item + " ";
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            string narudzba = richTextBox1.Text + "\nAdresa dostave: " + txtUnosAdrese.Text + "\nNačin plaćanja: " + cmbNacinPlacanja.SelectedItem.ToString();
            MessageBox.Show(narudzba);
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIzbornik_Click(object sender, EventArgs e)
        {
            Form1 izbornik = new Form1();
            this.Hide();
            izbornik.Show();
        }
    }
}
