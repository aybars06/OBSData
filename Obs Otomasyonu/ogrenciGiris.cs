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
    public partial class ogrenciGiris : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ERTAM-PC\\SQLEXPRESS;Initial Catalog=DbOBS;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataReader dr;
        ogrenciSistem os = new ogrenciSistem();
        public ogrenciGiris()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void grsYap_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            baglanti.Open();
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "ogrgiris";
            komut.Parameters.AddWithValue("@no", Convert.ToInt32(textBox1.Text));
            os.no = textBox1.Text;
            komut.Parameters.AddWithValue("@sifre",(textBox2.Text));
            os.sifre = textBox2.Text;
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                os.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı No Veya Şifre");
                
            }
 
            komut.Parameters.Clear();
            baglanti.Close();
        }

        private void kytOl_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "ogrkayit";
            komut.Parameters.AddWithValue("@no", Convert.ToInt32(textBox4.Text));
            komut.Parameters.AddWithValue("@sifre", (textBox3.Text));
            komut.Parameters.AddWithValue("@ad", (textBox5.Text));
            komut.Parameters.AddWithValue("@soyad", (textBox6.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt İşlemi Tamamlandı...");
            komut.Parameters.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
        }
    }
}
