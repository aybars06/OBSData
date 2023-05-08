using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
using System.Data.OleDb;

namespace Obs_Otomasyonu
{
    public partial class ogrenciSistem : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=ERTAM-PC\\SQLEXPRESS;Initial Catalog=DbOBS;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataReader dr;
        public String no;
        public string sifre;

        public ogrenciSistem()
        {
            InitializeComponent();

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "notlistele";
            komut.Parameters.AddWithValue("@no", no);
            baglanti.Open();
            DataTable dt = new DataTable();
            dt.Load(komut.ExecuteReader());
            dataGridView4.DataSource = dt;
            komut.Parameters.Clear();
            baglanti.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "dersprogrami";
            komut.Parameters.AddWithValue("@no", no);
            baglanti.Open();
            DataTable dt = new DataTable();
            dt.Load(komut.ExecuteReader());
            dataGridView1.DataSource = dt;
            komut.Parameters.Clear();
            baglanti.Close();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@no", no);
            komut.CommandText = "kulupinfo";
            baglanti.Open();
            DataTable dt = new DataTable();
            dt.Load(komut.ExecuteReader());
            dataGridView6.DataSource = dt;
            komut.Parameters.Clear();
            baglanti.Close();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "alinandersler";
            komut.Parameters.AddWithValue("@no", no);
            baglanti.Open();
            DataTable dt = new DataTable();
            dt.Load(komut.ExecuteReader());
            dataGridView2.DataSource = dt;
            komut.Parameters.Clear();
            baglanti.Close();
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "ogrencibilgi";
            komut.Parameters.AddWithValue("@no", no);
            baglanti.Open();
            DataTable dt = new DataTable();
            dt.Load(komut.ExecuteReader());
            dataGridView7.DataSource = dt;
            komut.Parameters.Clear();
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "kulupekle";
            komut.Parameters.AddWithValue("@kulup_id", int.Parse(textBox1.Text));
            komut.Parameters.AddWithValue("@id", no);
            baglanti.Open();
            DataTable dt = new DataTable();
            dt.Load(komut.ExecuteReader());
            dataGridView7.DataSource = dt;
            komut.Parameters.Clear();
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "kulupsil";
            komut.Parameters.AddWithValue("@kulup_id", int.Parse(textBox2.Text));
            komut.Parameters.AddWithValue("@id", no);
            baglanti.Open();
            DataTable dt = new DataTable();
            dt.Load(komut.ExecuteReader());
            dataGridView7.DataSource = dt;
            komut.Parameters.Clear();
            baglanti.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void sifreDegis_Click(object sender, EventArgs e)
        {

            if (textBox3.Text== sifre)
            {
                if (textBox4.Text == textBox5.Text)
                {
                    komut.Connection = baglanti;
                    baglanti.Open();
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.CommandText = "ogrsifreguncelle";
                    komut.Parameters.AddWithValue("@sifre", (textBox4.Text));
                    komut.Parameters.AddWithValue("@no", no);
                    komut.ExecuteNonQuery();
                    komut.Parameters.Clear();
                    baglanti.Close();
                    MessageBox.Show("Şifre Başarıyla Değiştirildi...");
                }
                else
                {
                    MessageBox.Show("Yeni şifreler uyuşmuyor...");
                }

            }

            else
            {
                MessageBox.Show("Eski Şifreniz Hatalı...");
            }


        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "ogrencidevamsızlık";
            komut.Parameters.AddWithValue("@no", no);
            baglanti.Open();
            DataTable dt = new DataTable();
            dt.Load(komut.ExecuteReader());
            dataGridView3.DataSource = dt;
            komut.Parameters.Clear();
            baglanti.Close();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "akademiktakvimsp";
            komut.Parameters.AddWithValue("@no", no);
            baglanti.Open();
            DataTable dt = new DataTable();
            dt.Load(komut.ExecuteReader());
            dataGridView5.DataSource = dt;
            komut.Parameters.Clear();
            baglanti.Close();
        }
    }

}
