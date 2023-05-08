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
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
        }

        private void ogr_btn_Click(object sender, EventArgs e)
        {
            ogrenciGiris og = new ogrenciGiris();
            og.Show();
            
        }

        private void ogret_btn_Click(object sender, EventArgs e)
        {
            ogretmenGiris og = new ogretmenGiris();
            og.Show();
        }

    }
}
