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
    
    public partial class Form3 : Form
    {
        string KullaniciAdi;
        string Sifre;
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
        private void label3_Click(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciAdi = textBox1.Text;
            Sifre = textBox2.Text;

          if (KullaniciAdi == "operator" && Sifre == "123456")
           {
                MessageBox.Show("Operator Girişi Başarılı");
                Form1 form1sec = new Form1();
                form1sec.Show();                         
            }

            else if (KullaniciAdi == "bakımcı" && Sifre == "123456")
            {
                MessageBox.Show("Bakımcı Girişi Başarılı");
                Form2 form2sec = new Form2();
                form2sec.Show();
            }

            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
