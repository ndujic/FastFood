using System;
using System.Collections.Generic;
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
            foreach (var item in r1.res1)
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
            while (txtUnosAdrese.Text == "")
            {
                MessageBox.Show("Morate unijeti vašu adresu!");
                break;
            }
            while (cmbNacinPlacanja.SelectedIndex != 0)
            {
                MessageBox.Show("Morate odabrati način plaćanja!");
                break;
            }
            if (txtUnosAdrese.Text != "" && cmbNacinPlacanja.SelectedIndex == 0)
            { 
            string narudzba = richTextBox1.Text + "\nAdresa dostave: " + txtUnosAdrese.Text + "\nNačin plaćanja: " + cmbNacinPlacanja.SelectedItem.ToString() + "\nOkvirno vrijeme dostave: 30-40 min";
            MessageBox.Show(narudzba);
            }
            

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

        private void txtUnosAdrese_TextChanged(object sender, EventArgs e)
        {

          

        }

        private void cmbNacinPlacanja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
