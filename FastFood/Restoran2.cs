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
    public partial class Restoran2 : Form
    {
        
        Zavrsna zavrsna = new Zavrsna();
        public List<string> res1 = new List<string>();
        public Restoran2()
        {
            InitializeComponent();
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
            string s = "Pommes frites\n";
            List<string> listaCheese = checkedListBox3.CheckedItems.OfType<string>().ToList();
            foreach (string el in listaCheese)
            {
                s += el + "\n";
            }
            res1.Add(s);
            checkedListBox3.ClearSelected();
        }

        private void btnSok_Click(object sender, EventArgs e)
        {
            res1.Add("Sok");
        }

        private void Voda_Click(object sender, EventArgs e)
        {
            res1.Add("Voda");
        }

        private void btnPiva_Click(object sender, EventArgs e)
        {
            res1.Add("Pivo");
        }


        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int brojNarudzbe = rnd.Next(100, 1000);
            zavrsna.richTextBox1.Text += $"Restoran 2\nBroj vaše narudžbe: {brojNarudzbe}\n\n";
            foreach (string el in res1)
            {
                zavrsna.richTextBox1.Text += el + "\n";
            }
            this.Close();
            zavrsna.Show();
        }
    }
}
