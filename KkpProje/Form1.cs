using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KkpProje
{

    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        

        void Listele()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=grupOdevi;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("Select * From BakimTalebi", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);           
            baglanti.Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.bakimTalebiTableAdapter2.Fill(this.grupOdeviDataSet2.BakimTalebi);

            this.bakimTalebiTableAdapter1.Fill(this.grupOdeviDataSet1.BakimTalebi);
            this.bakimTalebiTableAdapter.Fill(this.grupOdeviDataSet.BakimTalebi);
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.;Initial Catalog=grupOdevi;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Preshane as P inner join Operatorler as O on P.OperatorID = O.OperatorID";
           
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["TezgahAd"]);
                comboBox3.Items.Add(dr["OperatorAd"]);
            }
            baglanti.Close();


            Listele();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into BakimTalebi (TezgahAd,BakimSebebi,OperatorAd, ArizaSeviyesi, TalepTarihi) values (@TezgahAd, @BakimSebebi, @OperatorAd, @ArizaSeviyesi, @TalepTarihi)";
            komut = new SqlCommand(sorgu, baglanti);           
            komut.Parameters.AddWithValue("@TezgahAd", (comboBox1.Text));
            komut.Parameters.AddWithValue("@BakimSebebi", comboBox2.Text);
            komut.Parameters.AddWithValue("@OperatorAd", comboBox3.Text);
            komut.Parameters.AddWithValue("@ArizaSeviyesi", comboBox4.Text);
            komut.Parameters.AddWithValue("@TalepTarihi", Convert.ToDateTime(dateTimePicker1.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();

            MessageBox.Show("Ekleme başarıyla tamamlandı!");

            dataGridView1.Refresh();
            dataGridView1.Update();
            Form1_Load(null, null);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2sec = new Form2();
            form2sec.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From BakimTalebi Where TalepNo=@TalepNo";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@TalepNo", dataGridView1.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
            MessageBox.Show("Kayıt Silindi!");

            dataGridView1.Refresh();
            dataGridView1.Update();
            Form1_Load(null, null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
