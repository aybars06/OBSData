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
    public partial class ogretmenGiris : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ERTAM-PC\\SQLEXPRESS;Initial Catalog=DbOBS;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataReader dr;
        ogretmenSistem ogrsistem = new ogretmenSistem();
        public ogretmenGiris()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            baglanti.Open();
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "ogretmengiris";
            komut.Parameters.AddWithValue("@kullanici_adi", (textBox1.Text));
            ogrsistem.kullaniciAdi = textBox1.Text;
            komut.Parameters.AddWithValue("@sifre", (textBox2.Text));
            ogrsistem.ogrtmnSifre = textBox2.Text;
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                ogrsistem.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre");

            }

            komut.Parameters.Clear();
            baglanti.Close();
        }

        private void kayıt_Btn_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "ogrtmnkayit";
            komut.Parameters.AddWithValue("@kullanici_adi", (textBox4.Text));
            komut.Parameters.AddWithValue("@sifre", (textBox3.Text));
            komut.Parameters.AddWithValue("@ad", (textBox5.Text));
            komut.Parameters.AddWithValue("@soyad", (textBox6.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt İşlemi Tamamlandı...");
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
