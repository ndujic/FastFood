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
    public partial class Restoran4 : Form
    {
        public List<string> res1 = new List<string>();
        Zavrsna zavrsna = new Zavrsna();

        public Restoran4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHamb_Click(object sender, EventArgs e)
        {
            string s = "Hamburger\n";
            List<string> listaHamb = checkedListBox1.CheckedItems.OfType<string>().ToList();
            foreach (string el in listaHamb)
            {
                s += el + "\n";
            }
            res1.Add(s);
            checkedListBox1.ClearSelected();
        }

        private void btnCheese_Click(object sender, EventArgs e)
        {
            string s = "Cheeseburger\n";
            List<string> listaCheese = checkedListBox3.CheckedItems.OfType<string>().ToList();
            foreach (string el in listaCheese)
            {
                s += el + "\n";
            }
            res1.Add(s);
            checkedListBox3.ClearSelected();
        }

        private void btnPommes_Click(object sender, EventArgs e)
        {
            string s = "Pommes frites\n";
            List<string> listaPommes = checkedListBox2.CheckedItems.OfType<string>().ToList();
            foreach (string el in listaPommes)
            {
                s += el + "\n";
            }
            res1.Add(s);
            checkedListBox2.ClearSelected();
        }

        private void Restoran4_Load(object sender, EventArgs e)
        {

        }

        private void btnSok_Click(object sender, EventArgs e)
        {
            res1.Add("\nSok");
        }

        private void btnVoda_Click(object sender, EventArgs e)
        {
            res1.Add("\nVoda");
        }

        private void btnPivo_Click(object sender, EventArgs e)
        {
            res1.Add("\nPivo");
        }

        private void btnJosRest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 pocetna = new Form1();
            pocetna.Show();
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            foreach (string el in res1)
            {
                zavrsna.richTextBox1.Text += el + "\n";
            }
            this.Close();
            zavrsna.Show();
        }
    }
}
