using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KkpProje
{
    public partial class Form2 : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=grupOdevi;Integrated Security=SSPI");
        SqlCommand komut;
        SqlDataAdapter da;
        int sayac1;
        int sayac2;
        int sayac3;
        int sayac4;
        int sayac5;
        int sayac6;
        int sayac7;
        int sayac8;
        int sayac9;
        int sayac10;
        int toplamSayac = 0;
        int ceza;
        int cezaUcreti = 500;
            
        
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        void tablogoster()
        {
            baglan.Open();     
            komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM BakiciKisiler";
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox4.Items.Add(dr["BakiciAd"]);

            }
            baglan.Close();

        }

        void tablo2goster()
        {
            baglan.Open();
            komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM BakimTalebi";
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["TalepNo"]);

            }
            baglan.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'grupOdeviDataSet13.PeriyodikBakim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.periyodikBakimTableAdapter3.Fill(this.grupOdeviDataSet13.PeriyodikBakim);
            // TODO: Bu kod satırı 'grupOdeviDataSet5.PeriyodikBakim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.periyodikBakimTableAdapter2.Fill(this.grupOdeviDataSet5.PeriyodikBakim);
            // TODO: Bu kod satırı 'grupOdeviDataSet4.PeriyodikBakim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.periyodikBakimTableAdapter1.Fill(this.grupOdeviDataSet4.PeriyodikBakim);
            // TODO: Bu kod satırı 'grupOdeviDataSet3.PeriyodikBakim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.periyodikBakimTableAdapter.Fill(this.grupOdeviDataSet3.PeriyodikBakim);


            tablogoster();
            tablo2goster();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1sec = new Form1();
            form1sec.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void Listele()
        {
            baglan = new SqlConnection("server=.; Initial Catalog=grupOdevi;Integrated Security=SSPI");
            baglan.Open();
            da = new SqlDataAdapter("Select * From PeriyodikBakim", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into PeriyodikBakim (TalepNo,GorevliBakimci,BaslangicTarihi, BitisTarihi, ToplamParcaUcreti, CezaUcreti, HataKaynagi) values (@TalepNo, @GorevliBakimci, @BaslangicTarihi, @BitisTarihi, @ToplamParcaUcreti, @CezaUcreti, @HataKaynagi)";
            komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@TalepNo", (comboBox1.Text));
            komut.Parameters.AddWithValue("@GorevliBakimci", comboBox4.Text);
            komut.Parameters.AddWithValue("@BaslangicTarihi", Convert.ToDateTime(dateTimePicker1.Text));
            komut.Parameters.AddWithValue("@BitisTarihi", Convert.ToDateTime(dateTimePicker2.Text));
            komut.Parameters.AddWithValue("@ToplamParcaUcreti", (textBox2.Text));
            komut.Parameters.AddWithValue("@CezaUcreti", (textBox1.Text));
            komut.Parameters.AddWithValue("@HataKaynagi", (comboBox2.Text));

            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            Listele();

            MessageBox.Show("Bakım Talebiniz Tamamlandı.");

            dataGridView1.Refresh();
            dataGridView1.Update();
            Form2_Load(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From PeriyodikBakim Where TalepNo=@TalepNo";
            komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@TalepNo", dataGridView1.CurrentRow.Cells[0].Value);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            Listele();

            MessageBox.Show("Kayıt Silindi!");

            dataGridView1.Refresh();
            dataGridView1.Update();
            Form2_Load(null, null);
        }

        void ParcaFiyat()
        {
            baglan = new SqlConnection("server=.; Initial Catalog=grupOdevi;Integrated Security=SSPI");
            baglan.Open();
            da = new SqlDataAdapter("Select * From YedekParcalar", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglan.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked  == true)
            {
                sayac1 = 500;
                toplamSayac = toplamSayac + sayac1;
            }

            if (checkBox2.Checked == true)
            {
                sayac2 = 5000;
                toplamSayac = toplamSayac + sayac2;
            }

            if (checkBox3.Checked == true)
            {
                sayac3 = 50;
                toplamSayac = toplamSayac + sayac3;
            }

            if (checkBox4.Checked == true)
            {
                sayac4 = 1000;
                toplamSayac = toplamSayac + sayac4;
            }

            if (checkBox5.Checked == true)
            {
                sayac5 = 750;
                toplamSayac = toplamSayac + sayac5;
            }

            if (checkBox6.Checked == true)
            {
                sayac6 = 600;
                toplamSayac = toplamSayac + sayac6;
            }

            if (checkBox7.Checked == true)
            {
                sayac7 = 100;
                toplamSayac = toplamSayac + sayac7;
            }

            if (checkBox8.Checked == true)
            {
                sayac8 = 40;
                toplamSayac = toplamSayac + sayac8;
            }

            if (checkBox9.Checked == true)
            {
                sayac9 = 10;
                toplamSayac = toplamSayac + sayac9;
            }

            if (checkBox10.Checked == true)
            {
                sayac10 = 20;
                toplamSayac = toplamSayac + sayac10;
            }

            textBox2.Text = Convert.ToString(toplamSayac);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(0);
            toplamSayac = 0;
           
        }

        public int GunFarkikBul(DateTime dt1, DateTime dt2)

        {

            TimeSpan zaman = new TimeSpan(); 

            zaman = dt2 - dt1;

            return Math.Abs(zaman.Days);

        }
        private void button6_Click(object sender, EventArgs e)
        {
            DateTime dt1 = new DateTime();
            DateTime dt2 = new DateTime();

            dt1 = dateTimePicker1.Value; 
            dt2 = dateTimePicker2.Value;

            ceza = GunFarkikBul(dt2, dt1);
            textBox1.Text = Convert.ToString(ceza * cezaUcreti);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            BakimcilarRapor brapor = new BakimcilarRapor();
            brapor.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

