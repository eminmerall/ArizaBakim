using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KkpProje
{
    public partial class BakimcilarRapor : Form
    {
        public BakimcilarRapor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bakımcılar bakımcılar = new Bakımcılar();
            bakımcılar.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            YedekParcalar yedekparcalar = new YedekParcalar();
            yedekparcalar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BakimTalepleri bakımtalep = new BakimTalepleri();
            bakımtalep.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PeriyodikBakim peritalep = new PeriyodikBakim();
            peritalep.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu raporu görüntülemek için yetkiniz yoktur!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu raporu görüntülemek için yetkiniz yoktur!");
        }
    }
}
