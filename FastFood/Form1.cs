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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRes1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Restoran1 res1 = new Restoran1();
            res1.Show();

        }

        private void btnRes2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Restoran2 res2 = new Restoran2();
            res2.Show();
        }

        private void btnRes3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Restoran3 res3 = new Restoran3();
            res3.Show();
        }

        private void btnRes4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Restoran4 res4 = new Restoran4();
            res4.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Zavrsna zavrsna = new Zavrsna();
            
        }

        private void btnPogledajLokacijuDostavljaca_Click(object sender, EventArgs e)
        {
            Dostavljac dostavljac = new Dostavljac();
            this.Hide();
            dostavljac.Show();
        }
    }
}
