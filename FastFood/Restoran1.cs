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
    public partial class Restoran1 : Form
    {
        public List<string> res1 = new List<string>();
        Zavrsna zavrsna = new Zavrsna();
        public Restoran1()
        {
            InitializeComponent();
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
                zavrsna.richTextBox1.Text += el + " ";
            }
            this.Close();
            zavrsna.Show();
        }

        private void btnHamb_Click(object sender, EventArgs e)
        {
            string s = "Hamburger ";
            List<string> listaHamb = checkedListBox1.CheckedItems.OfType<string>().ToList();
            foreach(string el in listaHamb)
            {
                s += el + " ";
            }
            res1.Add(s);
            checkedListBox1.ClearSelected();
            
            
        }

        private void Restoran1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCheese_Click(object sender, EventArgs e)
        {
            string s = "Cheeseburger ";
            List<string> listaCheese = checkedListBox1.CheckedItems.OfType<string>().ToList();
            foreach (string el in listaCheese)
            {
                s += el + " ";
            }
            res1.Add(s);
            checkedListBox1.ClearSelected();
        }

        private void btnPomes_Click(object sender, EventArgs e)
        {
            string s = "Pommes ";
            List<string> listaPommes = checkedListBox1.CheckedItems.OfType<string>().ToList();
            foreach (string el in listaPommes)
            {
                s += el + " ";
            }
            res1.Add(s);
            checkedListBox1.ClearSelected();
        }

        private void btnSok_Click(object sender, EventArgs e)
        {
            res1.Add("Sok");
        }

        private void Voda_Click(object sender, EventArgs e)
        {
            res1.Add("Piva");
        }

        private void btnPiva_Click(object sender, EventArgs e)
        {
            res1.Add("Piva");
        }
    }
}
