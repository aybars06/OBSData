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

namespace Obs_Otomasyonu
{
    public partial class ogretmenSistem : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ERTAM-PC\\SQLEXPRESS;Initial Catalog=DbOBS;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataReader dr;
        public String kullaniciAdi;
        public string ogrtmnSifre;
        public ogretmenSistem()
        {

            InitializeComponent();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "akademisyenbilgileri";
            komut.Parameters.AddWithValue("@kullanici_adi", kullaniciAdi);
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
            if (textBox3.Text == ogrtmnSifre)
            {
                if (textBox4.Text == textBox5.Text)
                {
                    komut.Connection = baglanti;
                    baglanti.Open();
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.CommandText = "ogrtmnsifreguncelle";
                    komut.Parameters.AddWithValue("@sifre", (textBox4.Text));
                    komut.Parameters.AddWithValue("@kullanici_adi", kullaniciAdi);
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
            komut.CommandText = "ogretmenders";
            komut.Parameters.AddWithValue("@kullanici_adi", kullaniciAdi);
            baglanti.Open();
            DataTable dt = new DataTable();
            dt.Load(komut.ExecuteReader());
            dataGridView1.DataSource = dt;
            komut.Parameters.Clear();
            baglanti.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "dersegorenotlistele";
            komut.Parameters.AddWithValue("@kullanici_adi", kullaniciAdi);
            baglanti.Open();
            DataTable dt = new DataTable();
            dt.Load(komut.ExecuteReader());
            dataGridView2.DataSource = dt;
            komut.Parameters.Clear();
            baglanti.Close();
        }

        private void notGir_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "notgir";
            komut.Parameters.AddWithValue("no", int.Parse(txtNo.Text));
            komut.Parameters.AddWithValue("ders_id", int.Parse(txtDers_id.Text));
            komut.Parameters.AddWithValue("vize", int.Parse(txtVize.Text));
            komut.Parameters.AddWithValue("final", int.Parse(txtFinal.Text));
            baglanti.Open();
            DataTable dt = new DataTable();
            dt.Load(komut.ExecuteReader());
            dataGridView2.DataSource = dt;
            komut.Parameters.Clear();
            baglanti.Close();
        }

        private void notSil_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "notsil";
            komut.Parameters.AddWithValue("no", int.Parse(txtNo.Text));
            komut.Parameters.AddWithValue("ders_id", int.Parse(txtDers_id.Text));
            baglanti.Open();
            DataTable dt = new DataTable();
            dt.Load(komut.ExecuteReader());
            dataGridView2.DataSource = dt;
            komut.Parameters.Clear();
            baglanti.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "devamsızlıklistesi";
            komut.Parameters.AddWithValue("kullanici_adi", kullaniciAdi);
            baglanti.Open();
            DataTable dt = new DataTable();
            dt.Load(komut.ExecuteReader());
            dataGridView3.DataSource = dt;
            komut.Parameters.Clear();
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "devamsızlıkgir";
            komut.Parameters.AddWithValue("no", int.Parse(txtDevamsızlıkNO.Text));
            komut.Parameters.AddWithValue("ders_id", int.Parse(txtDevamsızlıkders.Text));
            komut.Parameters.AddWithValue("artıgunsayisi", int.Parse(txtDevamsızlık.Text));
            baglanti.Open();
            DataTable dt = new DataTable();
            dt.Load(komut.ExecuteReader());
            dataGridView3.DataSource = dt;
            komut.Parameters.Clear();
            baglanti.Close();
        }
    }
}
