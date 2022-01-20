using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FastFood
{
    public partial class Restoran1 : Form
    {
        public List<string> res1 = new List<string>();
        Zavrsna zavrsna = new Zavrsna();
        public Restoran1()
        {
            InitializeComponent();
        }

        public int ukupnaCijena = 0;

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int brojNarudzbe = rnd.Next(100, 1000);
            zavrsna.richTextBox1.Text += $"Fast Food Buco\nBroj vaše narudžbe: {brojNarudzbe}\n\n";
            foreach (string el in res1)
            {
                zavrsna.richTextBox1.Text += el + "\n";
            }
            zavrsna.richTextBox1.Text += $"\nUkupna cijena: {ukupnaCijena}";
            this.Close();
            zavrsna.Show();
        }

        private void btnHamb_Click(object sender, EventArgs e)
        {
            ukupnaCijena += 42;
            string s = "Hamburger\n";
            List<string> listaHamb = checkedListBox1.CheckedItems.OfType<string>().ToList();
            foreach (string el in listaHamb)
            {
                s += el + "\n";
            }
            res1.Add(s);
            checkedListBox1.ClearSelected();


        }

        private void Restoran1_Load(object sender, EventArgs e)
        {

        }

        private void btnCheese_Click(object sender, EventArgs e)
        {
            ukupnaCijena += 45;
            string s = "Cheeseburger\n";
            List<string> listaCheese = checkedListBox2.CheckedItems.OfType<string>().ToList();
            foreach (string el in listaCheese)
            {
                s += el + "\n";
            }
            res1.Add(s);
            checkedListBox2.ClearSelected();
        }

        private void btnPomes_Click(object sender, EventArgs e)
        {
            ukupnaCijena += 25;
            string s = "Pommes frites\n";
            List<string> listaPommes = checkedListBox3.CheckedItems.OfType<string>().ToList();
            foreach (string el in listaPommes)
            {
                s += el + "\n";
            }
            res1.Add(s);
            checkedListBox3.ClearSelected();
        }

        private void btnSok_Click(object sender, EventArgs e)
        {
            ukupnaCijena += 15;
            res1.Add("Sok");
        }

        private void Voda_Click(object sender, EventArgs e)
        {
            ukupnaCijena += 10;
            res1.Add("Voda");
        }

        private void btnPiva_Click(object sender, EventArgs e)
        {
            ukupnaCijena += 20;
            res1.Add("Pivo");
        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
